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
    <div class="flex-row">
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
  cursor: url("data:image/svg+xml,%3Csvg width='40' height='36' xmlns='http://www.w3.org/2000/svg' shape-rendering='crispEdges'%3E%3Crect x='12' y='0' width='2' height='2' fill='%23ABDD64' /%3E%3Crect x='14' y='0' width='2' height='2' fill='%235BA675' /%3E%3Crect x='0' y='2' width='2' height='2' fill='%23ABDD64' /%3E%3Crect x='2' y='2' width='2' height='2' fill='%23ABDD64' /%3E%3Crect x='4' y='2' width='2' height='2' fill='%236BC96C' /%3E%3Crect x='10' y='2' width='2' height='2' fill='%23ABDD64' /%3E%3Crect x='12' y='2' width='2' height='2' fill='%235BA675' /%3E%3Crect x='2' y='4' width='2' height='2' fill='%235BA675' /%3E%3Crect x='4' y='4' width='2' height='2' fill='%235BA675' /%3E%3Crect x='6' y='4' width='2' height='2' fill='%236BC96C' /%3E%3Crect x='8' y='4' width='2' height='2' fill='%23ABDD64' /%3E%3Crect x='10' y='4' width='2' height='2' fill='%236BC96C' /%3E%3Crect x='12' y='4' width='2' height='2' fill='%235BA675' /%3E%3Crect x='4' y='6' width='2' height='2' fill='%235BA675' /%3E%3Crect x='6' y='6' width='2' height='2' fill='%235BA675' /%3E%3Crect x='8' y='6' width='2' height='2' fill='%23ABDD64' /%3E%3Crect x='10' y='6' width='2' height='2' fill='%236BC96C' /%3E%3Crect x='12' y='6' width='2' height='2' fill='%235BA675' /%3E%3Crect x='14' y='6' width='2' height='2' fill='%23EA6262' /%3E%3Crect x='16' y='6' width='2' height='2' fill='%23EA6262' /%3E%3Crect x='18' y='6' width='2' height='2' fill='%23EA6262' /%3E%3Crect x='20' y='6' width='2' height='2' fill='%23EA6262' /%3E%3Crect x='22' y='6' width='2' height='2' fill='%23EA6262' /%3E%3Crect x='4' y='8' width='2' height='2' fill='%23ABDD64' /%3E%3Crect x='6' y='8' width='2' height='2' fill='%23ABDD64' /%3E%3Crect x='8' y='8' width='2' height='2' fill='%235BA675' /%3E%3Crect x='10' y='8' width='2' height='2' fill='%236BC96C' /%3E%3Crect x='12' y='8' width='2' height='2' fill='%236BC96C' /%3E%3Crect x='14' y='8' width='2' height='2' fill='%23F79470' /%3E%3Crect x='16' y='8' width='2' height='2' fill='%23FFB879' /%3E%3Crect x='18' y='8' width='2' height='2' fill='%23FFB879' /%3E%3Crect x='20' y='8' width='2' height='2' fill='%23F79470' /%3E%3Crect x='22' y='8' width='2' height='2' fill='%23FFB879' /%3E%3Crect x='24' y='8' width='2' height='2' fill='%23EA6262' /%3E%3Crect x='26' y='8' width='2' height='2' fill='%23EA6262' /%3E%3Crect x='2' y='10' width='2' height='2' fill='%23ABDD64' /%3E%3Crect x='4' y='10' width='2' height='2' fill='%236BC96C' /%3E%3Crect x='6' y='10' width='2' height='2' fill='%236BC96C' /%3E%3Crect x='8' y='10' width='2' height='2' fill='%236BC96C' /%3E%3Crect x='10' y='10' width='2' height='2' fill='%235BA675' /%3E%3Crect x='12' y='10' width='2' height='2' fill='%23FFB879' /%3E%3Crect x='14' y='10' width='2' height='2' fill='%23F79470' /%3E%3Crect x='16' y='10' width='2' height='2' fill='%23FFB879' /%3E%3Crect x='18' y='10' width='2' height='2' fill='%23FFB879' /%3E%3Crect x='20' y='10' width='2' height='2' fill='%23F79470' /%3E%3Crect x='22' y='10' width='2' height='2' fill='%23FFB879' /%3E%3Crect x='24' y='10' width='2' height='2' fill='%23FFB879' /%3E%3Crect x='26' y='10' width='2' height='2' fill='%23F79470' /%3E%3Crect x='28' y='10' width='2' height='2' fill='%23EA6262' /%3E%3Crect x='30' y='10' width='2' height='2' fill='%23EA6262' /%3E%3Crect x='0' y='12' width='2' height='2' fill='%23ABDD64' /%3E%3Crect x='2' y='12' width='2' height='2' fill='%235BA675' /%3E%3Crect x='4' y='12' width='2' height='2' fill='%235BA675' /%3E%3Crect x='6' y='12' width='2' height='2' fill='%235BA675' /%3E%3Crect x='8' y='12' width='2' height='2' fill='%236BC96C' /%3E%3Crect x='10' y='12' width='2' height='2' fill='%23F79470' /%3E%3Crect x='12' y='12' width='2' height='2' fill='%23F79470' /%3E%3Crect x='14' y='12' width='2' height='2' fill='%23F79470' /%3E%3Crect x='16' y='12' width='2' height='2' fill='%23F79470' /%3E%3Crect x='18' y='12' width='2' height='2' fill='%23F79470' /%3E%3Crect x='20' y='12' width='2' height='2' fill='%23F79470' /%3E%3Crect x='22' y='12' width='2' height='2' fill='%23F79470' /%3E%3Crect x='24' y='12' width='2' height='2' fill='%23F79470' /%3E%3Crect x='26' y='12' width='2' height='2' fill='%23F79470' /%3E%3Crect x='28' y='12' width='2' height='2' fill='%23F79470' /%3E%3Crect x='30' y='12' width='2' height='2' fill='%23F79470' /%3E%3Crect x='32' y='12' width='2' height='2' fill='%23EA6262' /%3E%3Crect x='0' y='14' width='2' height='2' fill='%235BA675' /%3E%3Crect x='6' y='14' width='2' height='2' fill='%23EA6262' /%3E%3Crect x='8' y='14' width='2' height='2' fill='%23F79470' /%3E%3Crect x='10' y='14' width='2' height='2' fill='%23FFB879' /%3E%3Crect x='12' y='14' width='2' height='2' fill='%23FFB879' /%3E%3Crect x='14' y='14' width='2' height='2' fill='%23F79470' /%3E%3Crect x='16' y='14' width='2' height='2' fill='%23FFB879' /%3E%3Crect x='18' y='14' width='2' height='2' fill='%23FFB879' /%3E%3Crect x='20' y='14' width='2' height='2' fill='%23F79470' /%3E%3Crect x='22' y='14' width='2' height='2' fill='%23FFB879' /%3E%3Crect x='24' y='14' width='2' height='2' fill='%23FFB879' /%3E%3Crect x='26' y='14' width='2' height='2' fill='%23F79470' /%3E%3Crect x='28' y='14' width='2' height='2' fill='%23FFB879' /%3E%3Crect x='30' y='14' width='2' height='2' fill='%23FFB879' /%3E%3Crect x='32' y='14' width='2' height='2' fill='%23F79470' /%3E%3Crect x='34' y='14' width='2' height='2' fill='%23EA6262' /%3E%3Crect x='6' y='16' width='2' height='2' fill='%23EA6262' /%3E%3Crect x='8' y='16' width='2' height='2' fill='%23F79470' /%3E%3Crect x='10' y='16' width='2' height='2' fill='%23FFB879' /%3E%3Crect x='12' y='16' width='2' height='2' fill='%23FFB879' /%3E%3Crect x='14' y='16' width='2' height='2' fill='%23F79470' /%3E%3Crect x='16' y='16' width='2' height='2' fill='%23FFB879' /%3E%3Crect x='18' y='16' width='2' height='2' fill='%23FFB879' /%3E%3Crect x='20' y='16' width='2' height='2' fill='%23F79470' /%3E%3Crect x='22' y='16' width='2' height='2' fill='%23FFB879' /%3E%3Crect x='24' y='16' width='2' height='2' fill='%23FFB879' /%3E%3Crect x='26' y='16' width='2' height='2' fill='%23F79470' /%3E%3Crect x='28' y='16' width='2' height='2' fill='%23FFB879' /%3E%3Crect x='30' y='16' width='2' height='2' fill='%23FFB879' /%3E%3Crect x='32' y='16' width='2' height='2' fill='%23F79470' /%3E%3Crect x='34' y='16' width='2' height='2' fill='%23FFB879' /%3E%3Crect x='36' y='16' width='2' height='2' fill='%23EA6262' /%3E%3Crect x='6' y='18' width='2' height='2' fill='%23EA6262' /%3E%3Crect x='8' y='18' width='2' height='2' fill='%23F79470' /%3E%3Crect x='10' y='18' width='2' height='2' fill='%23F79470' /%3E%3Crect x='12' y='18' width='2' height='2' fill='%23F79470' /%3E%3Crect x='14' y='18' width='2' height='2' fill='%23F79470' /%3E%3Crect x='16' y='18' width='2' height='2' fill='%23F79470' /%3E%3Crect x='18' y='18' width='2' height='2' fill='%23F79470' /%3E%3Crect x='20' y='18' width='2' height='2' fill='%23F79470' /%3E%3Crect x='22' y='18' width='2' height='2' fill='%23F79470' /%3E%3Crect x='24' y='18' width='2' height='2' fill='%23F79470' /%3E%3Crect x='26' y='18' width='2' height='2' fill='%23F79470' /%3E%3Crect x='28' y='18' width='2' height='2' fill='%23F79470' /%3E%3Crect x='30' y='18' width='2' height='2' fill='%23F79470' /%3E%3Crect x='32' y='18' width='2' height='2' fill='%23F79470' /%3E%3Crect x='34' y='18' width='2' height='2' fill='%23F79470' /%3E%3Crect x='36' y='18' width='2' height='2' fill='%23EA6262' /%3E%3Crect x='6' y='20' width='2' height='2' fill='%23EA6262' /%3E%3Crect x='8' y='20' width='2' height='2' fill='%23F79470' /%3E%3Crect x='10' y='20' width='2' height='2' fill='%23FFB879' /%3E%3Crect x='12' y='20' width='2' height='2' fill='%23FFB879' /%3E%3Crect x='14' y='20' width='2' height='2' fill='%23F79470' /%3E%3Crect x='16' y='20' width='2' height='2' fill='%23FFB879' /%3E%3Crect x='18' y='20' width='2' height='2' fill='%23FFB879' /%3E%3Crect x='20' y='20' width='2' height='2' fill='%23F79470' /%3E%3Crect x='22' y='20' width='2' height='2' fill='%23FFB879' /%3E%3Crect x='24' y='20' width='2' height='2' fill='%23FFB879' /%3E%3Crect x='26' y='20' width='2' height='2' fill='%23F79470' /%3E%3Crect x='28' y='20' width='2' height='2' fill='%23FFB879' /%3E%3Crect x='30' y='20' width='2' height='2' fill='%23FFB879' /%3E%3Crect x='32' y='20' width='2' height='2' fill='%23F79470' /%3E%3Crect x='34' y='20' width='2' height='2' fill='%23FFB879' /%3E%3Crect x='36' y='20' width='2' height='2' fill='%23FFB879' /%3E%3Crect x='38' y='20' width='2' height='2' fill='%23EA6262' /%3E%3Crect x='8' y='22' width='2' height='2' fill='%23EA6262' /%3E%3Crect x='10' y='22' width='2' height='2' fill='%23FFB879' /%3E%3Crect x='12' y='22' width='2' height='2' fill='%23FFB879' /%3E%3Crect x='14' y='22' width='2' height='2' fill='%23F79470' /%3E%3Crect x='16' y='22' width='2' height='2' fill='%23FFB879' /%3E%3Crect x='18' y='22' width='2' height='2' fill='%23FFB879' /%3E%3Crect x='20' y='22' width='2' height='2' fill='%23F79470' /%3E%3Crect x='22' y='22' width='2' height='2' fill='%23FFB879' /%3E%3Crect x='24' y='22' width='2' height='2' fill='%23FFB879' /%3E%3Crect x='26' y='22' width='2' height='2' fill='%23F79470' /%3E%3Crect x='28' y='22' width='2' height='2' fill='%23FFB879' /%3E%3Crect x='30' y='22' width='2' height='2' fill='%23FFB879' /%3E%3Crect x='32' y='22' width='2' height='2' fill='%23F79470' /%3E%3Crect x='34' y='22' width='2' height='2' fill='%23FFB879' /%3E%3Crect x='36' y='22' width='2' height='2' fill='%23FFB879' /%3E%3Crect x='38' y='22' width='2' height='2' fill='%23EA6262' /%3E%3Crect x='8' y='24' width='2' height='2' fill='%23EA6262' /%3E%3Crect x='10' y='24' width='2' height='2' fill='%23F79470' /%3E%3Crect x='12' y='24' width='2' height='2' fill='%23F79470' /%3E%3Crect x='14' y='24' width='2' height='2' fill='%23F79470' /%3E%3Crect x='16' y='24' width='2' height='2' fill='%23F79470' /%3E%3Crect x='18' y='24' width='2' height='2' fill='%23F79470' /%3E%3Crect x='20' y='24' width='2' height='2' fill='%23F79470' /%3E%3Crect x='22' y='24' width='2' height='2' fill='%23F79470' /%3E%3Crect x='24' y='24' width='2' height='2' fill='%23F79470' /%3E%3Crect x='26' y='24' width='2' height='2' fill='%23F79470' /%3E%3Crect x='28' y='24' width='2' height='2' fill='%23F79470' /%3E%3Crect x='30' y='24' width='2' height='2' fill='%23F79470' /%3E%3Crect x='32' y='24' width='2' height='2' fill='%23F79470' /%3E%3Crect x='34' y='24' width='2' height='2' fill='%23F79470' /%3E%3Crect x='36' y='24' width='2' height='2' fill='%23F79470' /%3E%3Crect x='38' y='24' width='2' height='2' fill='%23EA6262' /%3E%3Crect x='10' y='26' width='2' height='2' fill='%23EA6262' /%3E%3Crect x='12' y='26' width='2' height='2' fill='%23FFB879' /%3E%3Crect x='14' y='26' width='2' height='2' fill='%23F79470' /%3E%3Crect x='16' y='26' width='2' height='2' fill='%23FFB879' /%3E%3Crect x='18' y='26' width='2' height='2' fill='%23FFB879' /%3E%3Crect x='20' y='26' width='2' height='2' fill='%23F79470' /%3E%3Crect x='22' y='26' width='2' height='2' fill='%23FFB879' /%3E%3Crect x='24' y='26' width='2' height='2' fill='%23FFB879' /%3E%3Crect x='26' y='26' width='2' height='2' fill='%23F79470' /%3E%3Crect x='28' y='26' width='2' height='2' fill='%23FFB879' /%3E%3Crect x='30' y='26' width='2' height='2' fill='%23FFB879' /%3E%3Crect x='32' y='26' width='2' height='2' fill='%23F79470' /%3E%3Crect x='34' y='26' width='2' height='2' fill='%23FFB879' /%3E%3Crect x='36' y='26' width='2' height='2' fill='%23FFB879' /%3E%3Crect x='38' y='26' width='2' height='2' fill='%23EA6262' /%3E%3Crect x='12' y='28' width='2' height='2' fill='%23EA6262' /%3E%3Crect x='14' y='28' width='2' height='2' fill='%23F79470' /%3E%3Crect x='16' y='28' width='2' height='2' fill='%23FFB879' /%3E%3Crect x='18' y='28' width='2' height='2' fill='%23FFB879' /%3E%3Crect x='20' y='28' width='2' height='2' fill='%23F79470' /%3E%3Crect x='22' y='28' width='2' height='2' fill='%23FFB879' /%3E%3Crect x='24' y='28' width='2' height='2' fill='%23FFB879' /%3E%3Crect x='26' y='28' width='2' height='2' fill='%23F79470' /%3E%3Crect x='28' y='28' width='2' height='2' fill='%23FFB879' /%3E%3Crect x='30' y='28' width='2' height='2' fill='%23FFB879' /%3E%3Crect x='32' y='28' width='2' height='2' fill='%23F79470' /%3E%3Crect x='34' y='28' width='2' height='2' fill='%23FFB879' /%3E%3Crect x='36' y='28' width='2' height='2' fill='%23EA6262' /%3E%3Crect x='14' y='30' width='2' height='2' fill='%23EA6262' /%3E%3Crect x='16' y='30' width='2' height='2' fill='%23EA6262' /%3E%3Crect x='18' y='30' width='2' height='2' fill='%23F79470' /%3E%3Crect x='20' y='30' width='2' height='2' fill='%23F79470' /%3E%3Crect x='22' y='30' width='2' height='2' fill='%23F79470' /%3E%3Crect x='24' y='30' width='2' height='2' fill='%23F79470' /%3E%3Crect x='26' y='30' width='2' height='2' fill='%23F79470' /%3E%3Crect x='28' y='30' width='2' height='2' fill='%23F79470' /%3E%3Crect x='30' y='30' width='2' height='2' fill='%23F79470' /%3E%3Crect x='32' y='30' width='2' height='2' fill='%23F79470' /%3E%3Crect x='34' y='30' width='2' height='2' fill='%23EA6262' /%3E%3Crect x='18' y='32' width='2' height='2' fill='%23EA6262' /%3E%3Crect x='20' y='32' width='2' height='2' fill='%23EA6262' /%3E%3Crect x='22' y='32' width='2' height='2' fill='%23FFB879' /%3E%3Crect x='24' y='32' width='2' height='2' fill='%23FFB879' /%3E%3Crect x='26' y='32' width='2' height='2' fill='%23F79470' /%3E%3Crect x='28' y='32' width='2' height='2' fill='%23FFB879' /%3E%3Crect x='30' y='32' width='2' height='2' fill='%23FFB879' /%3E%3Crect x='32' y='32' width='2' height='2' fill='%23EA6262' /%3E%3Crect x='22' y='34' width='2' height='2' fill='%23EA6262' /%3E%3Crect x='24' y='34' width='2' height='2' fill='%23EA6262' /%3E%3Crect x='26' y='34' width='2' height='2' fill='%23EA6262' /%3E%3Crect x='28' y='34' width='2' height='2' fill='%23EA6262' /%3E%3Crect x='30' y='34' width='2' height='2' fill='%23EA6262' /%3E%3C/svg%3E"), auto;
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
