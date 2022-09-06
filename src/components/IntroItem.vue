<script setup lang="ts"></script>

<template>
  <div class="greetings">
    <h1 class="green">Serverless Pizza Workflow Visualizer</h1>
    <h3>
      Place an order and see the progress of the serverless pizza workflow.
    </h3>
    <button>Place order</button>
  </div>
</template>

<style scoped>
h1 {
  font-weight: 500;
  font-size: 2.6rem;
  top: -10px;
  color: #5ba675;
}

h3 {
  font-size: 1.2rem;
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
