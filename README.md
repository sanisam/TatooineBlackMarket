# Dit.Umb9.Mutobo


Umbraco 9 based Magic Umbraco Toolbox.


1. Install .NET 5
    - Linux Enviroment (Ubuntu)
      https://docs.microsoft.com/en-us/dotnet/core/install/linux-ubuntu
      
    - Windows Enviroment
      https://dotnet.microsoft.com/download/dotnet/5.0
2. Clone the Repo
3. Remove existing connectionString form appSettings.json
   Before:

    "ConnectionStrings": {
    "umbracoDbDSN": "Data Source=(localdb)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Umbraco.mdf;Integrated Security=True"
  },
   
   After:
   
     "ConnectionStrings": {
    
  }

5. open shell 
6. cd ./Sss.Umb9.Mutobo.Web
7. dotnet run
8. prepare an empty ms-sql database with a dbo user
9. go to the url showed in terminal and perform the umbraco installation
10. perform a uSync-Import (full)
