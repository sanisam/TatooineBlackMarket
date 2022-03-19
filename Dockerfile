FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /sources

# Copy everything else and build website


COPY *.sln .
COPY Dit.Umb9.Mutobo.Web/*.csproj ./Dit.Umb9.Mutobo.Web/
COPY Dit.Umb9.Mutobo.ToolBox/*.csproj ./Dit.Umb9.Mutobo.ToolBox/

RUN dotnet nuget add source "https://www.myget.org/F/umbracoprereleases/api/v3/index.json" -n "Umbraco Prereleases"
RUN dotnet restore



COPY Dit.Umb9.Mutobo.Web/. ./Dit.Umb9.Mutobo.Web/

COPY Dit.Umb9.Mutobo.ToolBox/. ./Dit.Umb9.Mutobo.ToolBox/

WORKDIR /sources/Dit.Umb9.Mutobo.Web
RUN dotnet publish -c release -o /output/Dit.Umb9.Mutobo.Web 



FROM mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR /output/Dit.Umb9.Mutobo.Web

COPY --from=build /output/Dit.Umb9.Mutobo.Web ./



ENTRYPOINT ["dotnet", "Dit.Umb9.Mutobo.Web.dll"]

RUN mkdir /output/Dit.Umb9.Mutobo.Web/wwwroot/media
RUN cp -r /output/Dit.Umb9.Mutobo.Web/demo-media/** /output/Dit.Umb9.Mutobo.Web/wwwroot/media


RUN rm /output/Dit.Umb9.Mutobo.Web/appsettings.json
RUN mv /output/Dit.Umb9.Mutobo.Web/appsettings.Docker.json /output/Dit.Umb9.Mutobo.Web/appsettings.json

# Copy the wait-for-it.sh script as an mssql prerequisite
COPY ./wait-for-it.sh /wait-for-it.sh

RUN chmod +x /wait-for-it.sh