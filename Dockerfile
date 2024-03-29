# https://hub.docker.com/_/microsoft-dotnet
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /app
EXPOSE 80
EXPOSE 8080

# copy csproj and restore as distinct layers
COPY *.csproj ./
RUN dotnet restore

# copy everything else and build app
COPY . ./
RUN dotnet publish -c Release -o out

# final stage/image
FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /app
COPY --from=build /app/out .
ENTRYPOINT ["dotnet", "prueba_api.dll"]
