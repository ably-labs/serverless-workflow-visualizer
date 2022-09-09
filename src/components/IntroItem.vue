<script setup lang="ts">
import FlagIcon from "./icons/FlagIcon.vue";
import { pizzaProcessStore } from "../stores";
import { v4 as uuidv4 } from "uuid";
import { MenuItemType, type Order } from "@/types/Order";
import { storeToRefs } from "pinia";

const store = pizzaProcessStore();
const { disableOrdering } = storeToRefs(store);

async function placeOrder() {
  // store.disableOrdering = true;
  const clientId = store.clientId === "" ? uuidv4() : store.clientId;
  const today = new Date();
  const timeStamp = `${today.getHours()}:${today.getMinutes()}:${today.getSeconds()}`;
  const orderId = `${timeStamp}-${getRandomID()}`;
  const order: Order = {
    id: orderId,
    customerName: "Ada",
    customerAddress: "Amsterdam",
    menuItems: [
      {
        type: MenuItemType.Pizza,
        name: "Pepperoni pizza",
      },
      {
        type: MenuItemType.Drink,
        name: "Ice tea",
      },
    ],
  };
  store.start(clientId, order);
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
      <button @click="placeOrder" :disabled="disableOrdering">
        Place order
      </button>
    </div>
    <div class="flex-center">
      <details>
        <summary>More info about the workflow...</summary>
        <p>
          The serverless workflow is implemented using
          <a
            href="https://docs.microsoft.com/azure/azure-functions/durable/durable-functions-overview"
          >
            Azure Durable Functions
          </a>
          . The <code>PizzaWorkflowOrchestrator</code> function calls 5 activity
          functions in sequence. Each of these functions publishes a message via
          <a href="https://ably.com/docs/quick-start-guide">Ably</a> which is
          received by this website so you can see how far the workflow has
          progressed in real-time.
        </p>
      </details>
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
  font-family: "Comic Sans MS", cursive, sans-serif;
  transition: all 0.4s ease-out;
}

button:hover:enabled {
  box-shadow: 0px 0px 10px var(--vt-c-green-dark);
  transition: all 0.1s ease-out;
}

button:disabled {
  border-color: var(--vt-c-divider-dark-2);
  background-color: var(--vt-c-text-dark-2);
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

.flex-center {
  margin-top: 10px;
  display: flex;
  justify-content: center;
  text-align: left;
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

  .flex-center {
    display: flex;
    justify-content: left;
    text-align: left;
  }
}
</style>
