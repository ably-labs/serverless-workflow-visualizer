import { ref, computed } from "vue";
import { defineStore } from "pinia";
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
actions: {}
});
