const express = require('express')
var greetings = require('./greetings')

const app = express()
const port = 3000


app.post('/', (req, res) => {
  res.send('Hello World!')
})

app.route('/greetings/:name').post(greetings.greet);

app.listen(port, () => {
  console.log(`Example app listening on port ${port}`)
})