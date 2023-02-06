<template>
  <HeaderBar />
  <router-view></router-view>
</template>

<script setup lang="ts">
// This starter template is using Vue 3 <script setup> SFCs
// Check out https://vuejs.org/api/sfc-script-setup.html#script-setup
import HeaderBar from './components/HeaderBar.vue';
import { provide, reactive, readonly, watchEffect } from 'vue';
import { ShoppingItemType } from './interface/type';
import useStorage from './composables/useStorage';

const { addItem, readItem } = useStorage();
const storageKey = 'cart';

const cartItems = reactive<ShoppingItemType[]>([]);
const addToCart = (item: ShoppingItemType) => {
  console.log('Add to Cart:', item.name);
  cartItems.push(item);
  addItem(storageKey, cartItems);
}
const removeInCart = (itemIndex: number) => {
  cartItems.splice(itemIndex, 1);
  addItem(storageKey, cartItems);
}

provide('cartItems', readonly(cartItems));
provide('addToCart', addToCart);
provide('removeInCart', removeInCart);

watchEffect(() => {
  if (cartItems.length >= 10) {
    alert(`理性購物! 你已經購買${cartItems.length}件物品了`);
  }
});

// Created Lifecycle
const storageCartItems = readItem(storageKey) as ShoppingItemType[];
if (storageCartItems !== null) {
  Object.assign(cartItems, storageCartItems);
}
</script>

