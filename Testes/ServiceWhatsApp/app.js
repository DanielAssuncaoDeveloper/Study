const express = require('express')
const app = express()

app.post('/teste', async (req, resp) => {
    console.log(req.body)

    resp.send('Rota consultada')
})

app.get('/.well-known/pki-validation/FFF71729A7A2438A16471BE092B8AC37.txt', async (req, resp) => {
    resp.sendFile('FFF71729A7A2438A16471BE092B8AC37.txt', {root: 'assets'})
})

app.listen(8080, () => console.log('Web Server listen in port 8080'))