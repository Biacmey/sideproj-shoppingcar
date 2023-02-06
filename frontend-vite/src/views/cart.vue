<template>
  <div v-if="cartItems.length == 0">
    <b>No items</b></div>
  <table v-else>
    <tr>
      <th>No</th>
      <th>Item</th>
      <th>Price</th>
      <th>Action</th>
    </tr>
    <tr v-for="(item, index) in cartItems" :key="item.name">
      <td>{{ index + 1 }}</td>
      <td>{{ item.name }}</td>
      <td>${{ item.price }}</td>
      <td><button @click="remove(index)">X</button></td>
    </tr>
  </table>
  <div>
    <b>
      Total Price: ${{ totalPrice }}
    </b>
  </div>
  <button  @click="checkOut(cartItems)">Go To Pay</button>
</template>

<script setup lang="ts">
import { ShoppingItemType } from '../interface/type';
import { computed, inject, onUnmounted,reactive} from 'vue';
import axios from 'axios';

const cartItems = inject<ShoppingItemType[]>('cartItems');
const totalPrice = computed(() =>  {
  return cartItems!.map(i => i.price).reduce((acc, price) => acc + price, 0);
});

const removeInCart = inject('removeInCart');
const remove = (itemIndex: number) => {
  removeInCart(itemIndex);
}
const checkOut = (item: ShoppingItemType[]) => {
  console.log('Check Out:', item);
  console.log(JSON.parse(JSON.stringify(item)));
  let params = new FormData;    
  let array = reactive<ShoppingItemType[]>(JSON.parse(JSON.stringify(item)));
  let arr = JSON.parse(JSON.stringify(item));
  debugger;
  var k = axios.post("https://localhost:44371/CheckOutItem",arr);
  // var y = axios({
  //   method: 'post',
  //   url: 'https://localhost:44371/CheckOutItem',
  //   data: arr[0],
  //   headers: {"Content-Type":"application/json; charset=utf8"}
  // });
  k.then(value => {
    console.log(value)
  }).catch(err => {
    console.log(err)
  });
}
onUnmounted(() => {
  if (cartItems!.length == 0) return;
});

</script>
