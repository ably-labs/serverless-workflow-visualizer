<script setup lang="ts">
import ProgressItem from "./ProgressItem.vue";
import { storeToRefs } from "pinia";
import { pizzaProcessStore } from "../stores";
import type { WorkflowState } from "@/types/WorkflowState";

const store = pizzaProcessStore();
const {
  orderReceivedState,
  kitchenInstructionsState,
  preparationState,
  collectionState,
  deliveryState,
} = storeToRefs(store);
</script>

<template>
  <ProgressItem
    :workflow-state="orderReceivedState as WorkflowState"
    :order-i-d="store.orderId"
  />
  <ProgressItem
    :workflow-state="kitchenInstructionsState"
    :order-i-d="store.orderId"
  />
  <ProgressItem :workflow-state="preparationState" :order-i-d="store.orderId" />
  <ProgressItem :workflow-state="collectionState" :order-i-d="store.orderId" />
  <ProgressItem :workflow-state="deliveryState" :order-i-d="store.orderId" />
</template>
