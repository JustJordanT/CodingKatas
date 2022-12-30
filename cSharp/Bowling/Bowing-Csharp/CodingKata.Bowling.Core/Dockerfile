FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["CodingKata.Bowling.Core/CodingKata.Bowling.Core.csproj", "CodingKata.Bowling.Core/"]
RUN dotnet restore "CodingKata.Bowling.Core/CodingKata.Bowling.Core.csproj"
COPY . .
WORKDIR "/src/CodingKata.Bowling.Core"
RUN dotnet build "CodingKata.Bowling.Core.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CodingKata.Bowling.Core.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CodingKata.Bowling.Core.dll"]
