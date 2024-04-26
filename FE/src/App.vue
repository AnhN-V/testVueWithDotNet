<script>
import axios from 'axios';

export default {
  data() {
    return {
      userInfo: null,
      error: null,
      name: 'Viet Anh'  // Khai báo name ở đây để nó reactive
    };
  },
  methods: {
    fetchData() {
      axios.get('http://localhost:5165/sample')
        .then(response => {
          console.log(response);
          this.name = response.data.name;  // Cập nhật this.name để đảm bảo reactive
        })
        .catch(error => {
          this.error = error.message;
          console.error("There was an error!", error);
        });
    }
  },
  mounted() {
    this.fetchData();
  }
}
</script>
<script>
import axios from 'axios';

export default {
  data() {
    return {
      userInfo: null,
      error: null,
      name: 'Viet Anh'  // Khai báo name ở đây để nó reactive
    };
  },
  methods: {
    fetchData() {
      axios.get('http://localhost:5165/sample')
        .then(response => {
          console.log(response);
          this.name = response.data.name;  // Cập nhật this.name để đảm bảo reactive
        })
        .catch(error => {
          this.error = error.message;
          console.error("There was an error!", error);
        });
    }
  },
  mounted() {
    this.fetchData();
  }
}
</script>
<template>
  <div id="app">
    <p>{{ name }}</p>
  </div>
</template>
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