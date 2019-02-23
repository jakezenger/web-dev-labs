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
                let studentsApi = 'http://localhost:8081/api/student';

                Vue.axios.get(studentsApi).then(
                    (response) => {
                        console.log(response);
                        this.products = response.data;
                    },
                    (error) => {
                        console.log(error)
                    }
                );
            },
            getStudents: function() {
                this.students = getStudents();
            }
        },

        mounted() {
            this.getStudents();
        }
    }

function getStudents() {
    return JSON.parse(testStudents).students;
}

var testStudents = '{"students": [{"email": "johnny.goode@oit.edu","id": 15379446},{"email": "jack.white@oit.edu","id": 34681275},{"email": "jimi.hendrix@oit.edu","id": 64986523},{"email": "jimmy.page@oit.edu","id": 72185385},{"email": "brian.may@oit.edu","id": 58213468}]}';
</script>

<style></style>