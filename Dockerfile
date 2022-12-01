FROM  mcr.microsoft.com/dotnet/core/aspnet:3.1

WORKDIR /app

EXPOSE 80
EXPOSE 1433
COPY backend /app

ENTRYPOINT ["dotnet","backend.dll"]

