<template>
        <table style="width:50%">
            <caption>People</caption>
            <thead>
            <tr>
                <th class="column-heading">First name</th>
                <th class="column-heading">Middle name</th>
                <th class="column-heading">Last name</th>
            </tr>
            </thead>
            <tbody>
                <tr v-for="person in persons">
                    <td>{{ person.firstName }}</td>
                    <td>{{ person.middleName }}</td>
                    <td>{{ person.lastName }}</td>
                </tr>
            </tbody>
        </table>
</template>

<script>
    import Vue from 'vue';

    export default {
        name: 'Persons',
        data () {
            return {
            persons: []
            }
        },

        methods: {
            getPersonsFromApi: function() {
                let personsApi = 'http://192.168.99.100:8081/api/person';

                Vue.axios.get(personsApi).then(
                    (response) => {
                        console.log(response);
                        this.persons = response.data;
                    },
                    (error) => {
                        console.log(error)
                    }
                );
            }
        },

        mounted() {
            this.getPersonsFromApi();
        }
    }
</script>

<style></style>