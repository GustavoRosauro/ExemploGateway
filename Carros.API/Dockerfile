#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["Carros.API/Carros.API.csproj", "Carros.API/"]
RUN dotnet restore "Carros.API/Carros.API.csproj"
COPY . .
WORKDIR "/src/Carros.API"
RUN dotnet build "Carros.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Carros.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Carros.API.dll"]