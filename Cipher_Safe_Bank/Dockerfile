#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
RUN sed -i 's/TLSv1.2/TLSv1/g' /etc/ssl/openssl.cnf
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Cipher_Safe_Bank/Cipher_Safe_Bank.csproj", "Cipher_Safe_Bank/"]
RUN dotnet restore "Cipher_Safe_Bank/Cipher_Safe_Bank.csproj"
COPY . .
WORKDIR "/src/Cipher_Safe_Bank"
RUN dotnet build "Cipher_Safe_Bank.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Cipher_Safe_Bank.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Cipher_Safe_Bank.dll"]