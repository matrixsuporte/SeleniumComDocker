FROM microsoft/dotnet:2.2-runtime AS base
WORKDIR /app

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY Ping/Ping.csproj Ping/
RUN dotnet restore Ping/Ping.csproj
COPY . .
WORKDIR /src/Ping
RUN dotnet build Ping.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish Ping.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Ping.dll"]
