<template>
  <div id="app">
    <img alt="Vue logo" src="./assets/logo.png" />
    <div>
      <button @click="fetch">Fetch from API</button>
    </div>
    <HelloWorld :msg="message" />
  </div>
</template>

<script>
import axios from "axios";
import HelloWorld from "./components/HelloWorld.vue";

export default {
  name: "App",
  data() {
    return {
      message: "Welcome to Your Vue.js App",
    };
  },
  methods: {
    async fetch() {
      try {
        const url = "http://localhost:5000/api/HelloWorld";
        const response = await axios.get(url);
        const data = response.data;

        this.message = data;
      } catch (error) {
        this.message = error;
      }
    },
  },
  components: {
    HelloWorld,
  },
};
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
</style>
