FROM microsoft/dotnet:2.1-aspnetcore-runtime-nanoserver-sac2016 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk-nanoserver-sac2016 AS build
WORKDIR /src
COPY Agenda.Services/Agenda.Services.csproj Agenda.Services/
RUN dotnet restore Agenda.Services/Agenda.Services.csproj
COPY . .
WORKDIR /src/Agenda.Services
RUN dotnet build Agenda.Services.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish Agenda.Services.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Agenda.Services.dll"]
