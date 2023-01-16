FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["EventStoreService/EventStoreService.csproj", "EventStoreService/"]
RUN dotnet restore "EventStoreService/EventStoreService.csproj"
COPY . .
WORKDIR "/src/EventStoreService"
RUN dotnet build "EventStoreService.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "EventStoreService.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "EventStoreService.dll"]
