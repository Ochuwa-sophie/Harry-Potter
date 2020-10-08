import Router from 'vue-router';
import Vue from 'vue';

-import About from './views/About.vue';
+const About = () => import('./views/About.vue');
-import Home from './views/Home.vue';
+const Home = () => import('./views/Home.vue');

Vue.use(Router);

export default new Router({
+  mode: 'history',
  routes: [
    {
      path: '/',