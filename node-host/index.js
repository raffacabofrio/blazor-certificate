var express = require('express')
var app = express()

app.use(express.static('blazor-deploy/BlazorCertificate.Client/dist'));

app.listen(8080, function(){
    console.log('Blazor app running! http://localhost:8080/');
})