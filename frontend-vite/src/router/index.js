import { createWebHistory, createRouter } from "vue-router";
import HomePage from '../views/HomePage.vue'
import Shopping from '../views/shopping.vue'
import Cart from '../views/cart.vue'
import AddItem from '../views/addItem.vue'

const routes = [
  {
    path: "/",
    name: "Home",
    component: HomePage,
  },
  {
    path: "/shopping",
    name: "shopping",
    component: Shopping,
  },
  {
    path: "/cart",
    name: "cart",
    component: Cart,
  },
  {
    path: "/addItem",
    name: "addItem",
    component: AddItem,
  }
];

const router = createRouter({
  history: createWebHistory(),
  routes,
});

export default router;