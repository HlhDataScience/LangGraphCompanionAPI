FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["LangGraphCompanionAPI/LangGraphCompanionAPI.csproj", "LangGraphCompanionAPI/"]
RUN dotnet restore "LangGraphCompanionAPI/LangGraphCompanionAPI.csproj"
COPY . .
WORKDIR "/src/LangGraphCompanionAPI"
RUN dotnet build "./LangGraphCompanionAPI.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./LangGraphCompanionAPI.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "LangGraphCompanionAPI.dll"]
