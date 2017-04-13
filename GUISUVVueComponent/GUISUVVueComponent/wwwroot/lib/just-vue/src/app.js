import Vue from 'vue';
import router from './router';
import store from './store';

// components
import App from './app.vue';

const app = new Vue({
    router,
    store,
    ...App,
}).$mount('#just-vue')
