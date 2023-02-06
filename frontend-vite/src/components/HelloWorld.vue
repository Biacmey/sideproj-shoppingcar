<template>
  <h1>{{ msg }}</h1>
  <h1>{{ msgg }}</h1>

  <div class="card">
    <button type="button" @click="loadData">Test the Connection</button>
    <p>
      Edit
      <code>components/HelloWorld.vue</code> to test HMR
    </p>
  </div>

  <p>
    Check out
    <a href="https://vuejs.org/guide/quick-start.html#local" target="_blank"
      >create-vue</a
    >, the official Vue + Vite starter
  </p>
  <p>
    Install
    <a href="https://github.com/johnsoncodehk/volar" target="_blank">Volar</a>
    in your IDE for a better DX
  </p>
  <p class="read-the-docs">Click on the Vite and Vue logos to learn more</p>
</template>

<script setup>
import axios from 'axios'
import { ref } from 'vue'
    const msgg = ref("backenddata")
    function loadData(){
    var k = axios.get("https://localhost:44371/GetConnection");
    k.then(value => {
      msgg.value = value.data
    }).catch(err => {
      msgg.value = err.data
    });
    }
defineProps({
  msg: String
})

const count = ref(0)
</script>



<style scoped>
.read-the-docs {
  color: #888;
}
</style>
