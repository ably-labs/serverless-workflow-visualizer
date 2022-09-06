<script setup lang="ts">
import FlagIcon from "./icons/FlagIcon.vue";
</script>

<template>
  <div class="greetings">
    <h1>
      <FlagIcon />
      Serverless Pizza Workflow Visualizer
      <FlagIcon />
    </h1>
    <div class="row">
      <h3>
        Place an order and see the progress of the serverless pizza workflow.
      </h3>
      <button>Place order</button>
    </div>
  </div>
</template>

<style scoped>
h1 {
  font-weight: 600;
  font-size: 2.6rem;
  top: -10px;
  color: var(--color-heading);
  border-bottom: 0.2rem solid var(--color-accent);
}

h3 {
  font-size: 1.2rem;
  color: var(--color-text);
}

.row {
  grid-auto-rows: row;
  justify-content: space-between;
}

button {
  background-color: var(--vt-c-green-light);
  border-color: var(--vt-c-green-dark);
  border-radius: 0.5rem;
  padding: 0.7rem;
  font-size: 1.2rem;
  margin-top: 1rem;
  font-family: 'Comic Sans MS', cursive, sans-serif;
}

.greetings h1,
.greetings h3 {
  text-align: center;
}

@media (min-width: 1024px) {
  .greetings h1,
  .greetings h3 {
    text-align: left;
  }
}
</style>
