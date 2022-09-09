<script setup lang="ts">
import type { WorkflowState } from "@/types/WorkflowState";
import GreenDot from "../assets/GreenDot.png";
const props = defineProps({
  workflowState: Object,
});
const state: WorkflowState = props.workflowState as WorkflowState;
</script>

<template>
  <div class="item">
    <div class="green-dot">
      <img
        v-bind:class="{ disabled: state.isDisabled, transition: true }"
        :src="GreenDot"
        height="32"
      />
    </div>
    <div class="details">
      <img
        v-bind:class="{ disabled: state.isDisabled, transition: true }"
        :src="state.image"
      />
      <p v-bind:class="{ disabled: state.isDisabled }">
        {{
          state.isDisabled
            ? "Waiting for your order..."
            : `${state.timestamp} - ${state.title} (${state.orderId}.split("-")[1]})`
        }}
      </p>
    </div>
  </div>
</template>

<style scoped>
.item {
  margin-top: 2rem;
  display: flex;
}

.details {
  flex: 1;
  margin-left: 1rem;
}

.disabled {
  filter: grayscale(100%);
  color: grey;
}

.transition {
  transition: all 0.4s ease-in-out;
}

.green-dot {
  display: flex;
  place-items: center;
  place-content: center;
  width: 32px;
  height: 32px;

  color: var(--color-text);
}

h3 {
  font-size: 1.2rem;
  font-weight: 500;
  margin-bottom: 0.4rem;
  color: var(--color-heading);
}

@media (min-width: 1024px) {
  .item {
    margin-top: 0;
    padding: 0.4rem 0 1rem calc(var(--section-gap) / 2);
  }

  .green-dot {
    top: calc(50% - 25px);
    left: -26px;
    position: absolute;
    border: 1px solid var(--color-border);
    background: var(--color-background);
    border-radius: 8px;
    width: 50px;
    height: 50px;
  }

  .item:before {
    content: " ";
    border-left: 1px solid var(--color-border);
    position: absolute;
    left: 0;
    bottom: calc(50% + 25px);
    height: calc(50% - 25px);
  }

  .item:after {
    content: " ";
    border-left: 1px solid var(--color-border);
    position: absolute;
    left: 0;
    top: calc(50% + 25px);
    height: calc(50% - 25px);
  }

  .item:first-of-type:before {
    display: none;
  }

  .item:last-of-type:after {
    display: none;
  }
}
</style>
