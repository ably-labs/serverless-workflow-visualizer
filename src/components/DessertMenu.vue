<script setup lang="ts">
import FlagIcon from "./icons/FlagIcon.vue";
</script>

<template>
  <div class="dessertmenu">
    <h2><FlagIcon /> Dessert menu <FlagIcon /></h2>
    <ul>
      <li>
        <a href="https://github.com/ably-labs/serverless-workflow-visualizer">
          GitHub Repo
        </a>
      </li>
      <li>
        <a href="https://ably.com/blog">Blog post</a>
      </li>
      <li>
        <a href="https://www.youtube.com/c/AblyRealtime">YouTube</a>
      </li>
      <li><a href="https://ably.com/">Ably website</a></li>
    </ul>
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
