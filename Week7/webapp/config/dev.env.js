'use strict'
const merge = require('webpack-merge')
const prodEnv = require('./prod.env')

module.exports = merge(prodEnv, {
  NODE_ENV: '"development"',
  STUDENT_API: '"http://localhost:5000/api/student"',
  PERSON_API: '"http://localhost:5000/api/person"'
})
