<script setup lang="ts">
import ProgressItem from "./ProgressItem.vue";

import OrderImage from "../assets/Order.png";
import PizzaAndDrinkImage from "../assets/PizzaAndDrink.png";
import PizzaInOvenImage from "../assets/PizzaInOven.png";
import BoxAndDrinkImage from "../assets/BoxAndDrink.png";
import DeliveryImage from "../assets/Delivery.png";

let p1 = {
  title: "Order {ID} received",
  image: OrderImage,
  orderID: "123456789",
  isDisabled: true,
};

let p2 = {
  title: "Sending instructions to the kitchen",
  image: PizzaAndDrinkImage,
  orderID: "123456789",
  isDisabled: true,
};

let p3 = {
  title: "Preparing your pizza",
  image: PizzaInOvenImage,
  orderID: "123456789",
  isDisabled: true,
};

let p4 = {
  title: "Collecting your order",
  image: BoxAndDrinkImage,
  orderID: "123456789",
  isDisabled: true,
};

let p5 = {
  title: "Delivering your order",
  image: DeliveryImage,
  orderID: "123456789",
  isDisabled: true,
};
</script>

<template>
  <ProgressItem :title="p1.title" :order-i-d="p1.orderID" :image="p1.image" :is-disabled="p1.isDisabled"  />
  <ProgressItem :title="p2.title" :order-i-d="p2.orderID" :image="p2.image" :is-disabled="p2.isDisabled"  />
  <ProgressItem :title="p3.title" :order-i-d="p3.orderID" :image="p3.image" :is-disabled="p3.isDisabled"  />
  <ProgressItem :title="p4.title" :order-i-d="p4.orderID" :image="p4.image" :is-disabled="p4.isDisabled"  />
  <ProgressItem :title="p5.title" :order-i-d="p5.orderID" :image="p5.image" :is-disabled="p5.isDisabled"  />
</template>
