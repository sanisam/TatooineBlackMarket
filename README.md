# Dit.Umb9.Mutobo


Umbraco 9 based Magic Umbraco Toolbox.

Install .NET 5

Linux Enviroment (Ubuntu) https://docs.microsoft.com/en-us/dotnet/core/install/linux-ubuntu

Windows Enviroment https://dotnet.microsoft.com/download/dotnet/5.0

Clone the Repo

Remove existing connectionString form ./Sss.Umb9.Mutobo.Web/appSettings.json Before:

"ConnectionStrings": { "umbracoDbDSN": "Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Umbraco.mdf;Integrated Security=True" },

After:

"ConnectionStrings": {

}

open shell
cd ./Sss.Umb9.Mutobo.Web
dotnet run
go to the url showed in terminal and perform the umbraco installtion
perform a uSync-Import (full)
