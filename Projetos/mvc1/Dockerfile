FROM mcr.microsoft.com/dotnet/aspnet:7.0 
LABEL version="1.0.1" description="Dotnet Core 6.0"
COPY dist /app
WORKDIR /app
EXPOSE 80/tcp
ENTRYPOINT ["dotnet", "mvc1.dll"]