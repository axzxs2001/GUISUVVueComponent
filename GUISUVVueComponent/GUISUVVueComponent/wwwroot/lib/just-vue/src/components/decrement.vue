<template>
    <div>
        <button v-on:click="decrement">decrement</button>
    </div>
</template>

<script>
import {
    mapActions,
} from 'vuex';

export default {
    name: 'decrement',
    methods: {
        ...mapActions([
            'decrement',
        ]),
    },
}
</script>
