<script setup lang="ts">
import FlagIcon from "./icons/FlagIcon.vue";
</script>

<template>
  <div class="dessertmenu">
    <h2>
      <FlagIcon />
      <span class="title word-1"> Dessert </span>
      <span class="title word-2"> menu </span><FlagIcon />
    </h2>
    <div class="flex-list">
      <ul>
        <li>
          <a href="https://github.com/ably-labs/serverless-workflow-visualizer"
            >GitHub Repo</a
          >
          (the star of our desserts ⭐)
        </li>
        <li>
          <a
            href="https://ably.com/blog/visualize-azure-serverless-workflow-progress-in-realtime-with-pubsub?utm_campaign=GLB-2210-serverless-workflow-visualizer&utm_content=demo-serverless-workflow-visualizer&utm_source=ably-dev&utm_medium=demo&src=GLB-2210-serverless-workflow-visualizer-demo"
            >Blog post</a
          >
          (our most read menu item 📖)
        </li>
        <li>
          <a href="https://youtu.be/y9-a_ewgWCQ">YouTube</a>
          (please eat with your thumbs up 👍)
        </li>
        <li>
          <a href="http://go.ably.com/discord">Discord</a>
          (ideal for sharing 👥)
        </li>
        <li>
          <a
            href="https://ably.com/?utm_source=pizza&utm_medium=ably-dev&utm_campaign=serverless-workflow-visualizer"
            >Ably website</a
          >
          (hungry for more? 🍴🌍)
        </li>
      </ul>
    </div>
    <p>
      Contact <a href="https://twitter.com/marcduiker">the chef</a> 🧑‍🍳 for
      additional recipes.
    </p>
  </div>
</template>

<style scoped>
.dessertmenu {
  margin-top: 2rem;
  display: flex;
  flex-direction: column;
}

.dessertmenu h2 {
  font-weight: 600;
  margin-bottom: 0.5rem;
  color: var(--color-heading);
  border-bottom: 0.2rem solid var(--color-accent);
}

.dessertmenu p {
  margin-top: 0.5rem;
  padding-top: 0.5rem;
  border-top: 0.2rem solid var(--color-accent);
}

ul {
  margin-top: 0.5rem;
}

li {
  margin-bottom: 0.5rem;
}

h2,
p {
  text-align: center;
}

.flex-list {
  display: flex;
  justify-content: center;
  text-align: left;
}

@media (min-width: 1024px) {
  h2,
  p {
    text-align: left;
  }
}
</style>
