FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /sources

# Copy everything else and build website
COPY Dit.Umb9.Mutobo.Web/. ./Dit.Umb9.Mutobo.Web/
WORKDIR /sources/Dit.Umb9.Mutobo.Web

RUN dotnet nuget add source "https://www.myget.org/F/umbracoprereleases/api/v3/index.json" -n "Umbraco Prereleases"
RUN dotnet restore
RUN dotnet publish -c release -o /output/Dit.Umb9.Mutobo.Web --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR /output/Dit.Umb9.Mutobo.Web
COPY --from=build /output/Dit.Umb9.Mutobo.Web ./
ENTRYPOINT ["dotnet", "Dit.Umb9.Mutobo.Web.dll"]

# Copy the wait-for-it.sh script as an mssql prerequisite
COPY ./wait-for-it.sh /wait-for-it.sh
RUN chmod +x /wait-for-it.sh