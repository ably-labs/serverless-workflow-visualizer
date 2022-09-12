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
  <ProgressItem :state="(orderReceivedState as WorkflowState)" />
  <ProgressItem :state="(kitchenInstructionsState as WorkflowState)" />
  <ProgressItem :state="(preparationState as WorkflowState)" />
  <ProgressItem :state="(collectionState as WorkflowState)" />
  <ProgressItem :state="(deliveryState as WorkflowState)" />
</template>
