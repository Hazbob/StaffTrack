FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["BootsTrackr/BootsTrackr.csproj", "BootsTrackr/"]
RUN dotnet restore "BootsTrackr/BootsTrackr.csproj"
COPY . .
WORKDIR "/src/BootsTrackr"
RUN dotnet build "BootsTrackr.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BootsTrackr.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BootsTrackr.dll"]
