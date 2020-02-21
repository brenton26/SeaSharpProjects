FROM mcr.microsoft.com/dotnet/core/runtime:3.1-buster-slim AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY TwentyOneCardGame.csproj ./
RUN dotnet restore "./TwentyOneCardGame.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "TwentyOneCardGame.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TwentyOneCardGame.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TwentyOneCardGame.dll"]
