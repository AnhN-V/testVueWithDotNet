<script>
import axios from 'axios';

export default {
  data() {
    return {
      userInfo: null,
      error: null
    };
  },
  methods: {
    fetchData() {
      axios.get('http://localhost:5165/sample')
        .then(response => {
          this.userInfo = response.data;
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