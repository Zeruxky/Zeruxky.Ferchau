FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Zeruxky.Ferchau.Web/Zeruxky.Ferchau.Web.csproj", "Zeruxky.Ferchau.Web/"]
RUN dotnet restore "Zeruxky.Ferchau.Web/Zeruxky.Ferchau.Web.csproj"
COPY . .
WORKDIR "/src/Zeruxky.Ferchau.Web"
RUN dotnet build "Zeruxky.Ferchau.Web.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "Zeruxky.Ferchau.Web.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Zeruxky.Ferchau.Web.dll"]
