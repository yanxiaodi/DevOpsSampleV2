#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["DevOpsSampleV2.WebApp/DevOpsSampleV2.WebApp.csproj", "DevOpsSampleV2.WebApp/"]
RUN dotnet restore "DevOpsSampleV2.WebApp/DevOpsSampleV2.WebApp.csproj"
COPY . .
WORKDIR "/src/DevOpsSampleV2.WebApp"
RUN dotnet build "DevOpsSampleV2.WebApp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DevOpsSampleV2.WebApp.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DevOpsSampleV2.WebApp.dll"]