# CHR Interview Project

Welcome! Thanks for taking the time to review this project and taking the time to consider me for the position. 

## Instructions to run with Visual Studio Code
### Download required tools
https://code.visualstudio.com/download to install visual studio code  
https://dotnet.microsoft.com/download to install the .Net 5.0 SDK  
https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp  
Last one is a C# extension for VScode and can be installed within VScode's extension marketplace  

### Next Steps
* Clone this repository to a local directory on your computer  
* Open Visual Studio Code, and open the project folder File>Open Folder>(Directory of cloned repository)
* Visual studio code will prompt you with "Required assets to build and debug are missing, Add them?" Choose Yes and the Destination directory location.

### Run Locally
At this point you should now be ready to run the program

### **Two Options**
#### *Use Visual Studio Codes "Run and Debug"*
1. Within the Activity Bar on the left hand side of VScode, click Run and Debug. (Shortcut = CTRL + SHIFT + D)
2. At the top should now be a Green Play Button, click to Run Program. (Shortcut = F5)
3. If successful this should automatically open webpage https://localhost:5001 (Check NOTE section below)
4. Add a suffix to the localhost webpage /destination 
5. This will return a list of all destinations and a list of the path from the USA to that specific location
6. Can also return a specific destination path by adding the suffix /destination/PAN for example.
7. Press the red square at the top of VScode to stop running the program (Shortcut = Shift + F5)

#### *Use Terminal*
1. Navigate to directory of cloned repository in terminal. Example path:
    * >/(directory of clone)/Destination/Destination
2. >dotnet run
3. If successful it should build and show some info:
4. Navigate to a internet browser and go to https://localhost:5001 (Check NOTE section below)
5. Add a suffix to the localhost webpage /destination 
6. This will return a list of all destinations and a list of the path from the USA to that specific location
7. Can also return a specific destination path by adding the suffix /destination/PAN for example.
8. CTRL+Z in terminal to shut down program

#### *NOTE*
Initially you will have a connection isn't private response, and will need to trust the certificate bundled with .NET. To trust the certificate do the following within the terminal.  
  * >dotnet dev-certs https --trust
  * Confirm pop up with "YES"
  * Once complete the https://localhost:5001 webpage should have a response of "This localhost page can't be found"  

### Assumptions


### Improvements


### Technology and Tools
* Swagger
* Postman
* Docker
* MongoDB
* .NET

### Steps to Deploy from Terminal
* >cd Destination\
* >dotnet publish
* >cd Destination\bin\debug\net5.0\publish
* >zip -r publish.zip *
* >az webapp deployment source config-zip --src publish.zip --resource-group (name of resource group) --name (name of project)
