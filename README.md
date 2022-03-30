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

System Requirements for IIS Hosting:

- install .NET 5 Hosting Bundle https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/runtime-aspnetcore-5.0.15-windows-hosting-bundle-installer


- make sure that IIS Process has Acces to all necessary folders:
  - https://our.umbraco.com/Documentation/Fundamentals/Setup/server-setup/permissions
  - make sure that IIS Process hass full access to following Folders
    - /Smidge
    - /uSync



For Hosting on Linux Apache / Ubuntu 20.04 LTS:
- follow this instructions: https://tutexchange.com/how-to-host-asp-net-core-app-on-ubuntu-with-apache-webserver/


For Running with Docker:

- Ensure Docker and Docker Compose is up and running on your system
- open a terminal
- go to the project folder Dit.Umb9.Mutobo
- run the command: docker compose up
- open a browser and go to http://localhost:8080
- perform the Umbraco Installation and use the following db_settings:
  - server: host.docker.internal,3930
  - database: master
  - user: sa
  - password: K@xLK1CuW*we
- login into the backoffice and perform a usync import (full)
- enjoy the mutobo demo website 
