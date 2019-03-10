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
                <tr v-for="student in students">
                    <td>{{ student.studentId }}</td>
                    <td>{{ student.emailAddress }}</td>
                </tr>
            </tbody>
        </table>
    </div>
</template>

<script>
    import Vue from 'vue';

    export default {
        name: 'Students',
        props: ['auth'],
        
        data () {
            return {
            students: []
            }
        },

        methods: {

            getAuthHeader: function() {
                return {
                    headers: {
                        Authorization: 'Bearer ' + this.auth.accessToken
                    }
                }
            },
            
            getStudentsFromApi: function() {
                let studentsApi = process.env.STUDENT_API;

                Vue.axios.get(studentsApi, this.getAuthHeader()).then(
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