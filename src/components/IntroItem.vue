<script setup lang="ts">
import FlagIcon from "./icons/FlagIcon.vue";
import { pizzaProcessStore } from "../stores";
import { v4 as uuidv4 } from "uuid";
const store = pizzaProcessStore();

async function placeOrder() {
  const clientId = store.clientId === "" ? uuidv4() : store.clientId;
  const orderId = getRandomID();
  store.placeOrder(clientId, orderId);
}

function getRandomID() {
  const min = Math.ceil(1000);
  const max = Math.floor(9999);
  return Math.floor(Math.random() * (max - min) + min).toString();
}


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
    <div class="flex-row">
      <h3>
        Place an order and see the progress of the serverless pizza workflow.
      </h3>
      <button @click="placeOrder">Place order</button>
    </div>
    <details>
        <summary>More info about the workflow...</summary>
        <p>
        The serverless workflow is implemented using <a href="https://docs.microsoft.com/azure/azure-functions/durable/durable-functions-overview">Azure Durable Functions</a>.
        The <code>PizzaWorkflowOrchestrator</code> function calls 5 activity functions in sequence. 
        Each of these functions publishes a message via <a href="https://ably.com/docs/quick-start-guide">Ably</a> which is received by this website so you can see how far the workflow has progressed in real-time.
      </p>
      </details>
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
  font-family: "Comic Sans MS", cursive, sans-serif;
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

.flex-row {
  display: flex;
  flex-direction: column;
  align-items: center;
  justify-content: center;
}

details {
  cursor: pointer;
}

@media (min-width: 1024px) {
  .greetings h1,
  .greetings h3 {
    text-align: left;
  }

  .flex-row {
    display: flex;
    flex-direction: row;
    align-items: center;
    justify-content: center;
}
}
</style>
