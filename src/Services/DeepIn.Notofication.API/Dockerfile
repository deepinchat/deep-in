#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Services/DeepIn.Notofication.API/DeepIn.Notofication.API.csproj", "Services/DeepIn.Notofication.API/"]
RUN dotnet restore "Services/DeepIn.Notofication.API/DeepIn.Notofication.API.csproj"
COPY . .
WORKDIR "/src/Services/DeepIn.Notofication.API"
RUN dotnet build "DeepIn.Notofication.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DeepIn.Notofication.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DeepIn.Notofication.API.dll"]