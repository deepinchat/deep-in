#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Services/Chatting/DeepIn.Chatting.API/DeepIn.Chatting.API.csproj", "Services/Chatting/DeepIn.Chatting.API/"]
RUN dotnet restore "Services/Chatting/DeepIn.Chatting.API/DeepIn.Chatting.API.csproj"
COPY . .
WORKDIR "/src/Services/Chatting/DeepIn.Chatting.API"
RUN dotnet build "DeepIn.Chatting.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DeepIn.Chatting.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DeepIn.Chatting.API.dll"]