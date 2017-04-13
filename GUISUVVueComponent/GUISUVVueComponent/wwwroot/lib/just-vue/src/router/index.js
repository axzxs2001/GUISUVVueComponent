import Vue from 'vue';
import VueRouter from 'vue-router';
// views
import Home from '../views/home/Home.vue';

Vue.use(VueRouter);

const routes = [{
    path: '/',
    component: Home,
}];

export default new VueRouter({
    routes,
});
