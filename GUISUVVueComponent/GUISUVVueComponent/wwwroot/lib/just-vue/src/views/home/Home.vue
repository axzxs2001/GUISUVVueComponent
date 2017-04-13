<template>
    <div class="hello">
        <h1>{{ hello }}</h1>
        <h1>count: {{ count }}</h1>
        <increment></increment>
        <decrement></decrement>
    </div>
</template>

<script>
import {
    mapState,
} from 'vuex';
import increment from '../../components/increment.vue';
import decrement from '../../components/decrement.vue';

export default {
    components: {
        increment,
        decrement,
    },
    data() {
        return {
            hello: 'Hello Vue.',
        };
    },
    computed: {
        ...mapState([
            'count',
        ]),
    },
}
</script>
