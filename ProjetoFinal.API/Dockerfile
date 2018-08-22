FROM microsoft/aspnetcore:2.0-nanoserver-1709 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:2.0-nanoserver-1709 AS build
WORKDIR /src
COPY ProjetoFinal.API/ProjetoFinal.API.csproj ProjetoFinal.API/
RUN dotnet restore ProjetoFinal.API/ProjetoFinal.API.csproj
COPY . .
WORKDIR /src/ProjetoFinal.API
RUN dotnet build ProjetoFinal.API.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish ProjetoFinal.API.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "ProjetoFinal.API.dll"]
