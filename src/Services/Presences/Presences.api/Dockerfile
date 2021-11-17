#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Services/Presences/Presences.api/Presences.Api.csproj", "Services/Presences/Presences.api/"]
COPY ["Services/Presences/Presences.Infrastructure/Presences.Infrastructure.csproj", "Services/Presences/Presences.Infrastructure/"]
COPY ["Services/Presences/Presences.Domain/Presences.Domain.csproj", "Services/Presences/Presences.Domain/"]
COPY ["Services/Presences/Presences.Logic/Presences.Logic.csproj", "Services/Presences/Presences.Logic/"]
RUN dotnet restore "Services/Presences/Presences.api/Presences.Api.csproj"
COPY . .
WORKDIR "/src/Services/Presences/Presences.api"
RUN dotnet build "Presences.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Presences.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Presences.Api.dll"]