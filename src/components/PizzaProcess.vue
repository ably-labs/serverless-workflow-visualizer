<script setup lang="ts">
import ProgressItem from "./ProgressItem.vue";
import ItemIcon from "./icons/ItemIcon.vue";
import OrderIcon from "./icons/OrderIcon.vue";
import PizzaOvenIcon from "./icons/PizzaOvenIcon.vue";
import BoxAndDrink from "./icons/BoxAndDrink.vue";
import DeliveryIcon from "./icons/DeliveryIcon.vue";
import PizzaAndDrinkIcon from "./icons/PizzaAndDrinkIcon.vue";
</script>

<template>
  <ProgressItem>
    <template #icon>
      <ItemIcon />
    </template>
    <OrderIcon />
    <template #heading>Order {ID} received</template>
  </ProgressItem>

  <ProgressItem>
    <template #icon>
      <ItemIcon />
    </template>
    <PizzaAndDrinkIcon />
    <template #heading>Sending instructions to the kitchen</template>
  </ProgressItem>

  <ProgressItem>
    <template #icon>
      <ItemIcon />
    </template>
    <PizzaOvenIcon />
    <template #heading>Preparing pizza</template>
  </ProgressItem>

  <ProgressItem>
    <template #icon>
      <ItemIcon />
    </template>
    <BoxAndDrink />
    <template #heading>Collecting & packaging delivery</template>
  </ProgressItem>

  <ProgressItem>
    <template #icon>
      <ItemIcon />
    </template>
    <DeliveryIcon />
    <template #heading>Delivering order</template>
  </ProgressItem>
</template>
