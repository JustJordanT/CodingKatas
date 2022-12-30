FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["CodingKata.BankAccount.Console/CodingKata.BankAccount.Console.csproj", "CodingKata.BankAccount.Console/"]
RUN dotnet restore "CodingKata.BankAccount.Console/CodingKata.BankAccount.Console.csproj"
COPY . .
WORKDIR "/src/CodingKata.BankAccount.Console"
RUN dotnet build "CodingKata.BankAccount.Console.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CodingKata.BankAccount.Console.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CodingKata.BankAccount.Console.dll"]
