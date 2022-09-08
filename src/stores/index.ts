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
    orderID: "123",
    orderReceivedState: {
      title: "Order Received",
      orderID: "123",
      image: OrderImage,
      isDisabled: false,
    },
    kitchenInstructionsState: {
      title: "Sending instructions to the kitchen",
      orderID: "",
      image: PizzaAndDrinkImage,
      isDisabled: true,
    },
    preparationState: {
      title: "Preparing your pizza",
      orderID: "",
      image: PizzaInOvenImage,
      isDisabled: true,
    },
    collectionState: {
      title: "Collecting your order",
      orderID: "",
      image: BoxAndDrinkImage,
      isDisabled: true,
    },
    deliveryState: {
      title: "Delivering your order",
      orderID: "",
      image: DeliveryImage,
      isDisabled: true,
    },
  }),
  actions: {
    async createRealtimeConnection(clientId: string, orderID: string) {
      if (!this.isConnected) {
        const realtimeClient = new Realtime.Promise({
          authUrl: `/api/CreateTokenRequest/${clientId}`,
          echoMessages: false,
        });
        this.realtimeClient = realtimeClient;
        realtimeClient.connection.on(
          "connected",
          async (message: Types.ConnectionStateChange) => {
            this.isConnected = true;
            await this.attachToChannel(orderID);
          }
        );

        this.realtimeClient.connection.on("disconnected", () => {
          this.isConnected = false;
        });
        this.realtimeClient.connection.on("closed", () => {
          this.isConnected = false;
        });
      }
    },
    disconnect() {
      this.realtimeClient?.connection.close();
    },
    async attachToChannel(channelName: string) {
      const channelInstance = this.realtimeClient?.channels.get(channelName);
      this.channelInstance = channelInstance;
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
      // TODO
    },
    handleSendInstructions(message: Types.Message) {
      // TODO
    },
    handlePreparePizza(message: Types.Message) {
      // TODO
    },
    handleCollectOrder(message: Types.Message) {
      // TODO
    },
    handleDeliverOrder(message: Types.Message) {
      // TODO
    },
  },
});
