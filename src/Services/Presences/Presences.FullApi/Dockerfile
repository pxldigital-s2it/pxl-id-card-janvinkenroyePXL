#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Services/Presences/Presences.FullApi/Presences.FullApi.csproj", "Services/Presences/Presences.FullApi/"]
RUN dotnet restore "Services/Presences/Presences.FullApi/Presences.FullApi.csproj"
COPY . .
WORKDIR "/src/Services/Presences/Presences.FullApi"
RUN dotnet build "Presences.FullApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Presences.FullApi.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Presences.FullApi.dll"]