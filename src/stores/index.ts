import { ref, computed } from "vue";
import { defineStore, storeToRefs } from "pinia";
import type { Types } from "ably";
import { Realtime } from "ably/promises";
import type { PizzaWorkflow } from "@/types/PizzaWorkflow";
import OrderImage from "../assets/Order.png";
import PizzaAndDrinkImage from "../assets/PizzaAndDrink.png";
import PizzaInOvenImage from "../assets/PizzaInOven.png";
import BoxAndDrinkImage from "../assets/BoxAndDrink.png";
import DeliveryImage from "../assets/Delivery.png";
import type { Order } from "@/types/Order";

export const pizzaProcessStore = defineStore("pizza-process", {
  state: (): PizzaWorkflow => ({
    realtimeClient: undefined,
    channelInstance: undefined,
    isConnected: false,
    channelPrefix: "pizza-process",
    clientId: "",
    orderId: "",
    disableOrdering: false,
    isWorkflowComplete: false,
    isOrderPlaced: false,
    orderReceivedState: {
      timestamp: "",
      title: "Order Received",
      orderId: "",
      image: OrderImage,
      isDisabled: true,
      isCurrentState: false,
    },
    kitchenInstructionsState: {
      timestamp: "",
      title: "Sending instructions to the kitchen",
      orderId: "",
      image: PizzaAndDrinkImage,
      isDisabled: true,
      isCurrentState: false,
    },
    preparationState: {
      timestamp: "",
      title: "Preparing your pizza",
      orderId: "",
      image: PizzaInOvenImage,
      isDisabled: true,
      isCurrentState: false,
    },
    collectionState: {
      timestamp: "",
      title: "Collecting your order",
      orderId: "",
      image: BoxAndDrinkImage,
      isDisabled: true,
      isCurrentState: false,
    },
    deliveryState: {
      timestamp: "",
      title: "Delivering your order",
      orderId: "",
      image: DeliveryImage,
      isDisabled: true,
      isCurrentState: false,
    },
  }),
  actions: {
    async start(clientId: string, order: Order) {
      this.$reset();
      this.$state.clientId = clientId;
      this.$state.orderId = order.id;
      this.$state.disableOrdering = true;
      await this.createRealtimeConnection(clientId, order);
    },
    async createRealtimeConnection(clientId: string, order: Order) {
      if (!this.isConnected) {
        this.realtimeClient = new Realtime.Promise({
          authUrl: `/api/CreateTokenRequest/${clientId}`,
          echoMessages: false,
        });
        this.realtimeClient.connection.on(
          "connected",
          async (message: Types.ConnectionStateChange) => {
            this.isConnected = true;
            this.attachToChannel(order.id);
            if (!this.isOrderPlaced) {
              await this.placeOrder(order);
              this.$state.isOrderPlaced = true;
            }
          }
        );

        this.realtimeClient.connection.on("disconnected", () => {
          this.$state.isConnected = false;
        });
        this.realtimeClient.connection.on("closed", () => {
          this.$state.isConnected = false;
        });
      } else {
        this.attachToChannel(this.orderId);
      }
    },

    disconnect() {
      this.realtimeClient?.connection.close();
    },

    async placeOrder(order: Order) {
      const response = await window.fetch("/api/PlaceOrder", {
        method: "POST",
        headers: {
          "Content-Type": "application/json",
        },
        body: JSON.stringify(order),
      });
      if (response.ok) {
        const payload = await response.json();
        this.$state.orderId = payload.result;
        console.log(`Order ID: ${this.orderId}`);
      } else {
        this.$state.disableOrdering = false;
        console.log(response.statusText);
      }
    },

    attachToChannel(orderId: string) {
      const channelName = `pizza-workflow:${orderId}`;
      this.$state.channelInstance = this.realtimeClient?.channels.get(
        channelName,
        { params: { rewind: "2m" } }
      );
      this.subscribeToMessages();
    },

    subscribeToMessages() {
      this.channelInstance?.subscribe(
        "receive-order",
        (message: Types.Message) => {
          this.handleOrderReceived(message);
        }
      );
      this.channelInstance?.subscribe(
        "send-instructions-to-kitchen",
        (message: Types.Message) => {
          this.handleSendInstructions(message);
        }
      );
      this.channelInstance?.subscribe(
        "prepare-pizza",
        (message: Types.Message) => {
          this.handlePreparePizza(message);
        }
      );
      this.channelInstance?.subscribe(
        "collect-order",
        (message: Types.Message) => {
          this.handleCollectOrder(message);
        }
      );
      this.channelInstance?.subscribe(
        "deliver-order",
        (message: Types.Message) => {
          this.handleDeliverOrder(message);
        }
      );
    },

    handleOrderReceived(message: Types.Message) {
      this.$patch({
        orderReceivedState: {
          timestamp: convertToTime(message.timestamp),
          orderId: message.data.id,
          isDisabled: false,
          isCurrentState: true,
        },
      });
    },

    handleSendInstructions(message: Types.Message) {
      this.$patch({
        kitchenInstructionsState: {
          timestamp: convertToTime(message.timestamp),
          orderId: message.data[0].orderId,
          isDisabled: false,
          isCurrentState: true,
        },
        orderReceivedState: {
          isCurrentState: false,
        },
      });
    },

    handlePreparePizza(message: Types.Message) {
      this.$patch({
        preparationState: {
          timestamp: convertToTime(message.timestamp),
          orderId: message.data.orderId,
          isDisabled: false,
          isCurrentState: true,
        },
        kitchenInstructionsState: {
          isCurrentState: false,
        },
      });
    },

    handleCollectOrder(message: Types.Message) {
      this.$patch({
        collectionState: {
          timestamp: convertToTime(message.timestamp),
          orderId: message.data.id,
          isDisabled: false,
          isCurrentState: true,
        },
        preparationState: {
          isCurrentState: false,
        },
      });
    },

    handleDeliverOrder(message: Types.Message) {
      this.$patch({
        deliveryState: {
          timestamp: convertToTime(message.timestamp),
          orderId: message.data.id,
          isDisabled: false,
          isCurrentState: true,
        },
        collectionState: {
          isCurrentState: false,
        },
        isWorkflowComplete: true,
      });
      setTimeout(() => {
        this.disableOrdering = false;
      }, 2000);
    },
  },
});

function convertToTime(timestamp: number) {
  const date = new Date(timestamp);
  const hours = date.getHours();
  const minutes = date.getMinutes();
  const seconds = date.getSeconds();
  return `${hours}:${minutes}:${seconds}`;
}
