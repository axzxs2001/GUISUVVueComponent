import Vue from 'vue';
import Vuex from 'vuex';
import * as actions from './actions';
import * as getters from './getters';
import mutations from './mutations';
// import count from './modules/count';

Vue.use(Vuex);

export default new Vuex.Store({
    state: {
        count: 0,
    },
    actions,
    getters,
    mutations,
    modules: {
        // count,
    },
});
