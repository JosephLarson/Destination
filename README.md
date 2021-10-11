# CHR Interview Project

Welcome! Thanks for taking the time to review this project and taking the time to consider me for the position. 

### LOCAL DEPLOYMENT


### ASSUMPTIONS


### IMPROVEMENTS


### TECHNOLOGY AND PROGRAMS USED AND FIDDLED WITH
* Swagger
* Postman
* Docker
* MongoDB
* .NET

### STEPS TO DEPLOY FROM TERMINAL
* cd Destination\
* dotnet publish
* cd Destination\bin\debug\net5.0\publish
* zip -r publish.zip *
* az webapp deployment source config-zip --src publish.zip --resource-group (name of resource group) --name (name of project)
