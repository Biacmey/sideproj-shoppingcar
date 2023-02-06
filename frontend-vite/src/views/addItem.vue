<template>
  <form @submit.prevent="addItems" class="add-form">
    <div class="form-control">
      <label>Item Name: </label>
      <input type="text" v-model="ShoppingItem.name"  placeholder="Enter Your Name" />
    </div>
    <div class="form-control">
      <label>Price: </label>
      <input type="number" v-model="ShoppingItem.price"  placeholder="Enter Your Itme Price" />
    </div>
    <div class="form-control">
      <label>Img Src: </label>
      <input type="text" v-model="ShoppingItem.imgSrc"  placeholder="Enter Your Itme Img Src" />
    </div>
    <div class="form-control">
      <label>Count: </label>
      <input type="number" v-model="ShoppingItem.count" placeholder="Enter Your Item Count" />
    </div>
    <div class="form-control">
      <label>Detail: </label>
      <input type="text" v-model="ShoppingItem.detail"  placeholder="Enter Your Item Detail" />
    </div>
    <input type="submit" value="Save Information" class="btn btn-block" />
  </form>
</template>

<script setup lang="ts"> 
import axios from 'axios';
import { reactive } from 'vue';
import { ShoppingItemType } from '../interface/type';
import { ref } from 'vue';

const user = ref()
const ShoppingItem : ShoppingItemType = {} as ShoppingItemType;

function addItems(e){
  var k = axios.post("https://localhost:44371/AddItem",ShoppingItem);
  k.then(value => {
    console.log(value)
  }).catch(err => {
    console.log(err)
  });
}

</script>

<style lang="scss">
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
}
</style>
<style scoped>
.logo {
  height: 6em;
  padding: 1.5em;
  will-change: filter;
}
.logo:hover {
  filter: drop-shadow(0 0 2em #646cffaa);
}
.logo.vue:hover {
  filter: drop-shadow(0 0 2em #42b883aa);
}
</style>
