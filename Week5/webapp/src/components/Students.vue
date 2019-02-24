<template>
    <div>
        <table style="width:30%">
            <caption>Students</caption>
            <thead>
                <tr>
                    <th class="column-heading">Student ID</th>
                    <th class="column-heading">Email address</th>
                </tr>
            </thead>
            <tbody>
                <tr v-for="student in students" :key="student.id">
                    <td>{{ student.id }}</td>
                    <td>{{ student.email }}</td>
                </tr>
            </tbody>
        </table>
    </div>
</template>

<script>
    import Vue from 'vue';

    export default {
        name: 'Students',
        data () {
            return {
            students: []
            }
        },

        methods: {
            getStudentsFromApi: function() {
                let studentsApi = 'http://192.168.99.100:8081/api/student';

                Vue.axios.get(studentsApi).then(
                    (response) => {
                        console.log(response);
                        this.students = response.data;
                    },
                    (error) => {
                        console.log(error)
                    }
                );
            }
        },

        mounted() {
            this.getStudentsFromApi();
        }
    }
</script>

<style></style>