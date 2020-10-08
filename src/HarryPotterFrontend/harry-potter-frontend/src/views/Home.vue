 <template>
 <div class="home">
   <img src="../assets/logo.png">
   <HelloWorld msg="Welcome to Your Vue.js App"/>
 <div :class="$options.name">
   <h1>This is the homepage</h1>
   </div>
 </template>
 
 <script>
  // @ is an alias to /src 
import HelloWorld from '../components/HelloWorld.vue';

 export default {
  name: 'home',
  components: {
    HelloWorld,
  },
  name: 'Home',
 };
 </script>