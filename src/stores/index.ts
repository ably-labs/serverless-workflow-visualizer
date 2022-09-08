import { ref, computed } from "vue";
import { defineStore } from "pinia";
import type { Types } from "ably";
import { Realtime } from "ably/promises";
import type { PizzaWorkflow } from "@/types/PizzaWorkflow";
import OrderImage from "../assets/Order.png";
import PizzaAndDrinkImage from "../assets/PizzaAndDrink.png";
import PizzaInOvenImage from "../assets/PizzaInOven.png";
import BoxAndDrinkImage from "../assets/BoxAndDrink.png";
import DeliveryImage from "../assets/Delivery.png";

export const pizzaProcessStore = defineStore("pizza-process", {
  state: (): PizzaWorkflow => ({
    realtimeClient: undefined,
    channelInstance: undefined,
    isConnected: false,
    channelPrefix: "pizza-process",
    clientId: "",
    orderId: "123",
    isWorkflowComplete: false,
    orderReceivedState: {
      title: "Order Received",
      orderID: "",
      image: OrderImage,
      isDisabled: true,
      isCurrentState: false,
    },
    kitchenInstructionsState: {
      title: "Sending instructions to the kitchen",
      orderID: "",
      image: PizzaAndDrinkImage,
      isDisabled: true,
      isCurrentState: false,
    },
    preparationState: {
      title: "Preparing your pizza",
      orderID: "",
      image: PizzaInOvenImage,
      isDisabled: true,
      isCurrentState: false,
    },
    collectionState: {
      title: "Collecting your order",
      orderID: "",
      image: BoxAndDrinkImage,
      isDisabled: true,
      isCurrentState: false,
    },
    deliveryState: {
      title: "Delivering your order",
      orderID: "",
      image: DeliveryImage,
      isDisabled: true,
      isCurrentState: false,
    },
  }),
  actions: {
    async placeOrder(clientId: string, orderId: string) {
      this.$reset();
      this.clientId = clientId;
      this.orderId = orderId;
    },
    async createRealtimeConnection() {
      if (!this.isConnected) {
        this.realtimeClient = new Realtime.Promise({
          authUrl: `/api/CreateTokenRequest/${this.clientId}`,
          echoMessages: false,
        });
        this.realtimeClient.connection.on(
          "connected",
          async (message: Types.ConnectionStateChange) => {
            this.isConnected = true;
            await this.attachToChannel(this.orderId);
          }
        );

        this.realtimeClient.connection.on("disconnected", () => {
          this.isConnected = false;
        });
        this.realtimeClient.connection.on("closed", () => {
          this.isConnected = false;
        });
      } else {
        await this.attachToChannel(this.orderId);
      }
    },

    disconnect() {
      this.realtimeClient?.connection.close();
    },

    async attachToChannel(orderID: string) {
      const channelName = `pizza-workfkow:${orderID}`;
      this.channelInstance = this.realtimeClient?.channels.get(channelName);
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
          orderID: message.data.orderId,
          isDisabled: false,
        },
      });
    },

    handleSendInstructions(message: Types.Message) {
      this.$patch({
        kitchenInstructionsState: {
          orderID: message.data.orderId,
          isDisabled: false,
        },
      });
    },

    handlePreparePizza(message: Types.Message) {
      this.$patch({
        preparationState: {
          orderID: message.data.orderId,
          isDisabled: false,
        },
      });
    },

    handleCollectOrder(message: Types.Message) {
      this.$patch({
        preparationState: {
          orderID: message.data.orderId,
          isDisabled: false,
        },
      });
    },

    handleDeliverOrder(message: Types.Message) {
      this.$patch({
        deliveryState: {
          orderID: message.data.orderId,
          isDisabled: false,
        },
      });
    },
    reset() {
      const clientId = this.clientId;
      this.$reset();
      this.clientId = clientId;
    },
  },
});
