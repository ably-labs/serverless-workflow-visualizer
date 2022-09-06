<script setup lang="ts">
import ProgressItem from "./ProgressItem.vue";
import ItemIcon from "./icons/ItemIcon.vue";
</script>

<template>
  <ProgressItem>
    <template #icon>
      <ItemIcon />
    </template>
    <template #heading>Order received</template>
    {orderID}
  </ProgressItem>

  <ProgressItem>
    <template #icon>
      <ItemIcon />
    </template>
    <template #heading>Sending instructions to the kitchen</template>
  </ProgressItem>

  <ProgressItem>
    <template #icon>
      <ItemIcon />
    </template>
    <template #heading>Preparing pizza</template>
  </ProgressItem>

  <ProgressItem>
    <template #icon>
      <ItemIcon />
    </template>
    <template #heading>Collecting & packaging delivery</template>
  </ProgressItem>

  <ProgressItem>
    <template #icon>
      <ItemIcon />
    </template>
    <template #heading>Delivering order</template>
  </ProgressItem>
</template>
