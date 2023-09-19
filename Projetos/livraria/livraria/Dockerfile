FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build-env
WORKDIR /app

COPY *.csproj ./
RUN dotnet restore 

COPY ../ ./
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:7.0 
WORKDIR /app
COPY --from=build-env /app/out .

# Definir variáveis de ambiente para configuração
ENV DBServer=localhost
ENV DBPort=1450
ENV DBUser=SA
ENV Password=Teste123@
ENV Database=LivrosDb

ENTRYPOINT ["dotnet", "livraria.dll"]