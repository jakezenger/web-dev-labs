<template>
  <div id="app">
    <ul id="menu-bar">
      <!--<li><a href="./login.html">Login</a></li>-->
      <li><span v-on:click='goToHome'>Home</span></li>
      <li><span v-on:click='goToPersons'>Persons</span></li>
      <li><span v-on:click='goToStudents'>Students</span></li>
      <li><span v-on:click='goToHome'>Sign Out</span></li>
    </ul>

    <router-view/>
  </div>
</template>

<script>
export default {
  name: 'App',
  methods: {
    goToHome: function() {
      this.$router.push( {path: 'home'} )
    },
    goToPersons: function() {
      this.$router.push( {path: 'persons'} )
    },
    goToStudents: function() {
      this.$router.push( {path: 'students'} )
    }
  }
}
</script>

<style>
#app {
  font-family: 'Avenir', Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: left;
  color: #2c3e50;
  margin-top: 60px;
}
.column-heading {
    color: green;
    text-align: left;
    font-size: 1.2em;
}

#home-page-heading {
    font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
    text-align: center;
}

#menu-bar {
    list-style: none;
    
}

#menu-bar li {
    display: inline-block;
    cursor: pointer;
}

#menu-bar li a {
    display: block;
    text-decoration: none;
    padding: 16px;
}
</style>
