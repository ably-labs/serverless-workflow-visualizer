<script setup lang="ts">
import FlagIcon from "./icons/FlagIcon.vue";
</script>

<template>
  <div class="dessertmenu">
    <h2><FlagIcon /> Dessert menu <FlagIcon /></h2>
    <ul>
      <li>
        <a href="https://github.com/ably-labs/serverless-workflow-visualizer">GitHub Repo</a>
        (the star of our desserts ⭐)
      </li>
      <li>
        <a href="https://ably.com/blog">Blog post</a>
        (our most read menu item 📖)
      </li>
      <li>
        <a href="https://www.youtube.com/c/AblyRealtime">YouTube</a>
        (please eat with your thumbs up 👍)
      </li>
      <li>
        <a href="http://go.ably.com/discord">Discord</a>
        (ideal for sharing 👥)
      </li>
      <li>
        <a href="https://ably.com/">Ably website</a>
        (hungry for more? 🍴🌍)
      </li>
    </ul>
    <p>Allergies should be </p>
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

ul {
  margin-top: 0.5rem;
}

li {
  margin-bottom: 0.5rem;
}
</style>
