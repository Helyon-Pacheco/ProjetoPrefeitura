#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Prefeitura.Api/Prefeitura.Api.csproj", "Prefeitura.Api/"]
COPY ["Prefeitura.Core/Prefeitura.Core.csproj", "Prefeitura.Core/"]
COPY ["Prefeitura.Infra.Data/Prefeitura.Infra.Data.csproj", "Prefeitura.Infra.Data/"]
RUN dotnet restore "Prefeitura.Api/Prefeitura.Api.csproj"
COPY . .
WORKDIR "/src/Prefeitura.Api"
RUN dotnet build "Prefeitura.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Prefeitura.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Prefeitura.Api.dll"]

# Healthcheck
HEALTHCHECK --interval=5m --timeout=3s \
  CMD curl -f http://localhost/ || exit 1