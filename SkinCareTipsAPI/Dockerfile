# Use official .NET 8 SDK
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY SkinCareTipsAPI/*.csproj ./SkinCareTipsAPI/
RUN dotnet restore SkinCareTipsAPI/SkinCareTipsAPI.csproj

# Copy everything else and build
COPY . .
RUN dotnet build SkinCareTipsAPI/SkinCareTipsAPI.csproj -c Release

# Publish
RUN dotnet publish SkinCareTipsAPI/SkinCareTipsAPI.csproj -c Release -o out

# Runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/out .
ENTRYPOINT ["dotnet", "SkinCareTipsAPI.dll"]
