#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:2.1-stretch-slim AS base
WORKDIR /app
EXPOSE 8080
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.1-stretch AS build
WORKDIR /src
COPY ["CovidCol/CovidCol.csproj", "CovidCol/"]
RUN dotnet restore "CovidCol/CovidCol.csproj"
COPY . .
WORKDIR "/src/CovidCol"
RUN dotnet build "CovidCol.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CovidCol.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CovidCol.dll"]
