#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Clients/DeepIn.Identity.WebSPA/DeepIn.Identity.WebSPA.csproj", "Clients/DeepIn.Identity.WebSPA/"]
RUN dotnet restore "Clients/DeepIn.Identity.WebSPA/DeepIn.Identity.WebSPA.csproj"
COPY . .
WORKDIR "/src/Clients/DeepIn.Identity.WebSPA"
RUN dotnet build "DeepIn.Identity.WebSPA.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DeepIn.Identity.WebSPA.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DeepIn.Identity.WebSPA.dll"]