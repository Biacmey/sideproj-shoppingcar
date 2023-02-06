<template>
  <div class="card">
    <img :src="itemDetail.imgSrc" alt="item" style="width:250px;">
    <div class="container">
      <h4><b>{{ itemDetail.name }}</b></h4>
      <p><b>${{ itemDetail.price }}</b></p>
      <p><b> detail :{{shortDetail}}</b></p>
      <p><b>remaining numbe {{ itemDetail.count }}</b></p>
    </div>
    <button class="button" @click="handleClick">Add to Cart</button>
  </div>
</template>
<script setup lang="ts">
import { ShoppingItemType } from '../interface/type';
import { computed, PropType } from 'vue';

const props = defineProps({
  itemDetail: {
    type: Object as PropType<ShoppingItemType>,
    required: true,
  },
});
const emit = defineEmits(['handleAddToCart']);

const handleClick = () => {
  emit('handleAddToCart', props.itemDetail.id);
}
const shortDetail =computed(()=>{
  return props.itemDetail.detail.substr(0,20)+'....';
});

</script>

<style scoped>
.card {
  /* Add shadows to create the "card" effect */
  max-width: 220px;
  box-shadow: 0 4px 8px 0 rgba(0,0,0,0.2);
  transition: 0.3s;
  margin: 5px;
  margin: auto;
}

/* On mouse-over, add a deeper shadow */
.card:hover {
  box-shadow: 0 8px 16px 0 rgba(0,0,0,0.2);
}

/* Add some padding inside the card container */
.container {
  padding: 2px 16px;
}

.button {
  margin: 5px;
  background-color: #008CBA;
  border: none;
  color: white;
  padding: 12px 30px;
  text-align: center;
  text-decoration: none;
  display: inline-block;
  font-size: 14px;
}

.button:hover {
  font-weight: bold;
  cursor: pointer;
}
</style>
