<template>
    <div>
        <button v-on:click="increment">increment</button>
    </div>
</template>

<script>
import {
    mapActions,
} from 'vuex';

export default {
    name: 'increment',
    methods: {
        ...mapActions([
            'increment',
        ]),
    },
}
</script>
