# .NET 10 SDK kullanarak projeyi derleyelim
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src
COPY ["BerberRandevuSistemi.csproj", "./"]
RUN dotnet restore "BerberRandevuSistemi.csproj"
COPY . .
RUN dotnet publish -c Release -o /app/publish

# Çalıştırma aşaması
FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "BerberRandevuSistemi.dll"]