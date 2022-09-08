orderIdorderIdorderIdorderIdorderId<script setup lang="ts">
import ProgressItem from "./ProgressItem.vue";
import { pizzaProcessStore } from "../stores";
const store = pizzaProcessStore();
</script>

<template>
  <ProgressItem
    :workflow-state="store.orderReceivedState"
    :order-i-d="store.orderId"
  />
  <ProgressItem
    :workflow-state="store.kitchenInstructionsState"
    :order-i-d="store.orderId"
  />
  <ProgressItem
    :workflow-state="store.preparationState"
    :order-i-d="store.orderId"
  />
  <ProgressItem
    :workflow-state="store.collectionState"
    :order-i-d="store.orderId"
  />
  <ProgressItem
    :workflow-state="store.deliveryState"
    :order-i-d="store.orderId"
  />
</template>
