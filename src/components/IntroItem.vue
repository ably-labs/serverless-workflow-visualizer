<script setup lang="ts">
import FlagIcon from "./icons/FlagIcon.vue";
</script>

<template>
  <div class="greetings">
    <h1>
      <FlagIcon />
      <span class="title word-1"> Serverless </span>
      <span class="title word-2">Pizza </span>
      <span class="title word-3">Workflow </span>
      <span class="title word-4">Visualizer </span>
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
  font-weight: bold;
  font-size: 2.6rem;
  top: -10px;
  color: var(--color-heading);
  border-bottom: 0.2rem solid var(--color-accent);
}

h3 {
  font-weight: normal;
  font-size: 1.2rem;
  color: var(--color-text);
}

button {
  background-color: var(--vt-c-green-light);
  border-color: var(--vt-c-green-dark);
  border-radius: 0.5rem;
  padding: 0.7rem;
  font-size: 1.2rem;
  margin-top: 1rem;
  font-family: 'Comic Sans MS', cursive, sans-serif;
  transition: all 0.4s ease-out;
}

button:hover {
  box-shadow: 0px 0px 10px var(--vt-c-green-dark);
  transition: all 0.1s ease-out;
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
