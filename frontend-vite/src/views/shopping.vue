<template>
  <div>
    <a href="https://vitejs.dev" target="_blank">
      <img src="/vite.svg" class="logo" alt="Vite logo" />
    </a>
  </div>
  <div class="container">
      <ShoppingItem
      v-for="item in shoppingItemsByBack"
      :item-detail="item"
      :key="item.name"
      @handleAddToCart="handleAddToCart"
    />
  </div>
</template>
<script setup lang="ts">
import ShoppingItem from '../components/ShoppingItem.vue';
import { inject, reactive } from 'vue';
import { ShoppingItemType } from '../interface/type';
import axios from 'axios';
import { ref } from 'vue';

const user = ref()
const shoppingItemsByBack = ref(reactive<ShoppingItemType[]>(user.value))

var k = axios.get("https://localhost:44371/GetItems");
    k.then(value => {
      debugger;
      console.log(value.data)
      user.value = value.data
      shoppingItemsByBack.value = reactive<ShoppingItemType[]>(user.value)
      console.log(shoppingItemsByBack)

    }).catch(err => {
      console.log(err.data)
    });
// const shoppingItems = reactive<ShoppingItemType[]>([{
//   id: 1,
//   name: 'iphone 13',
//   price: 3999.50,
//   imgSrc: 'https://m-cdn.phonearena.com/images/phones/82892-350/Apple-iPhone-13.webp',
//   count: 10,
//   detail:"支援的格式包括 HEVC、H.264 與 ProRes\n" +
//     "HDR 支援杜比視界、HDR10 與 HLG\n" +
//     "AirPlay 鏡像輸出、照片與視訊輸出至 Apple TV (第 2 代或後續機型) 或支援 AirPlay 2 的智慧型電視，最高可達 4K HDR\n" +
//     "支援視訊鏡像輸出與視訊輸出：使用 Lightning 數位 AV 轉接器與 Lightning 對 VGA 轉接器，最高可達 1080p (轉接器另售)7"
// }, {
//   id: 2,
//   name: 'iphone 12',
//   price: 3299.50,
//   imgSrc: 'https://m-cdn.phonearena.com/images/phones/80755-350/Apple-iPhone-12.webp',
//   count: 10,
//   detail:"支援的格式包括 HEVC、H.264 與 ProRes\n" +
//     "HDR 支援杜比視界、HDR10 與 HLG\n" +
//     "AirPlay 鏡像輸出、照片與視訊輸出至 Apple TV (第 2 代或後續機型) 或支援 AirPlay 2 的智慧型電視，最高可達 4K HDR\n" +
//     "支援視訊鏡像輸出與視訊輸出：使用 Lightning 數位 AV 轉接器與 Lightning 對 VGA 轉接器，最高可達 1080p (轉接器另售)7"


// }, {
//   id: 3,
//   name: 'iphone 11',
//   price: 2600.00,
//   imgSrc: 'https://m-cdn.phonearena.com/images/phones/76836-350/Apple-iPhone-11.webp',
//   count: 10,
//   detail:"支援的格式包括 HEVC、H.264 與 ProRes\n" +
//     "HDR 支援杜比視界、HDR10 與 HLG\n" +
//     "AirPlay 鏡像輸出、照片與視訊輸出至 Apple TV (第 2 代或後續機型) 或支援 AirPlay 2 的智慧型電視，最高可達 4K HDR\n" +
//     "支援視訊鏡像輸出與視訊輸出：使用 Lightning 數位 AV 轉接器與 Lightning 對 VGA 轉接器，最高可達 1080p (轉接器另售)7"


// }, {
//   id: 4,
//   name: 'iphone X',
//   price: 2200.50,
//   imgSrc: 'https://m-cdn.phonearena.com/images/phones/74103-350/Apple-iPhone-X.webp',
//   count: 10,
//   detail:"支援的格式包括 HEVC、H.264 與 ProRes\n" +
//     "HDR 支援杜比視界、HDR10 與 HLG\n" +
//     "AirPlay 鏡像輸出、照片與視訊輸出至 Apple TV (第 2 代或後續機型) 或支援 AirPlay 2 的智慧型電視，最高可達 4K HDR\n" +
//     "支援視訊鏡像輸出與視訊輸出：使用 Lightning 數位 AV 轉接器與 Lightning 對 VGA 轉接器，最高可達 1080p (轉接器另售)7"


// }, {
//   id: 5,
//   name: 'iphone 8',
//   price: 1600.50,
//   imgSrc: 'https://m-cdn.phonearena.com/images/phones/63258-350/Apple-iPhone-7.webp',
//   count: 10,
//   detail:"支援的格式包括 HEVC、H.264 與 ProRes\n" +
//     "HDR 支援杜比視界、HDR10 與 HLG\n" +
//     "AirPlay 鏡像輸出、照片與視訊輸出至 Apple TV (第 2 代或後續機型) 或支援 AirPlay 2 的智慧型電視，最高可達 4K HDR\n" +
//     "支援視訊鏡像輸出與視訊輸出：使用 Lightning 數位 AV 轉接器與 Lightning 對 VGA 轉接器，最高可達 1080p (轉接器另售)7"


// }, {
//   id: 6,
//   name: 'iphone SE3',
//   price: 2000.50,
//   imgSrc: 'https://m-cdn.phonearena.com/images/phones/70223-350/Apple-iPhone-SE.webp',
//   count: 10,
//   detail:"支援的格式包括 HEVC、H.264 與 ProRes\n" +
//     "HDR 支援杜比視界、HDR10 與 HLG\n" +
//     "AirPlay 鏡像輸出、照片與視訊輸出至 Apple TV (第 2 代或後續機型) 或支援 AirPlay 2 的智慧型電視，最高可達 4K HDR\n" +
//     "支援視訊鏡像輸出與視訊輸出：使用 Lightning 數位 AV 轉接器與 Lightning 對 VGA 轉接器，最高可達 1080p (轉接器另售)7"


// }, {
//   id: 7,
//   name: 'iphone 14 Pro',
//   price: 6000.00,
//   imgSrc: 'https://m-cdn.phonearena.com/images/phones/82529-350/Apple-iPhone-14-Pro.webp',
//   count: 10,
//   detail:"支援的格式包括 HEVC、H.264 與 ProRes\n" +
//     "HDR 支援杜比視界、HDR10 與 HLG\n" +
//     "AirPlay 鏡像輸出、照片與視訊輸出至 Apple TV (第 2 代或後續機型) 或支援 AirPlay 2 的智慧型電視，最高可達 4K HDR\n" +
//     "支援視訊鏡像輸出與視訊輸出：使用 Lightning 數位 AV 轉接器與 Lightning 對 VGA 轉接器，最高可達 1080p (轉接器另售)7"

// }, {
//   id: 8,
//   name: 'iphone 14',
//   price: 5400.00,
//   imgSrc: 'https://m-cdn.phonearena.com/images/phones/82526-350/Apple-iPhone-14.webp',
//   count: 10,
//   detail:"支援的格式包括 HEVC、H.264 與 ProRes\n" +
//     "HDR 支援杜比視界、HDR10 與 HLG\n" +
//     "AirPlay 鏡像輸出、照片與視訊輸出至 Apple TV (第 2 代或後續機型) 或支援 AirPlay 2 的智慧型電視，最高可達 4K HDR\n" +
//     "支援視訊鏡像輸出與視訊輸出：使用 Lightning 數位 AV 轉接器與 Lightning 對 VGA 轉接器，最高可達 1080p (轉接器另售)7"
// }]);
// console.log(shoppingItems)
const addToCart = inject('addToCart');

const handleAddToCart = (id: number) => {
  addToCart(shoppingItemsByBack.value.find(i => i.id === id));
}
// const sortByPrice = () => {
//   shoppingItems.sort((next, current) => {
//     return next.price - current.price;
//   });
// };
// const sortByPrice2 = () => {
//   sortByPrice();
//   shoppingItems.reverse();
// };
// const sortByCount = () => {
//   shoppingItems.sort((next, current) => {
//     return next.count - current.count;
//   });
// };
// const sortByCount2 = () => {
//   sortByCount();
//   shoppingItems.reverse();
// };
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
.container {
  display: flex;
  flex-wrap: wrap;
}
</style>
