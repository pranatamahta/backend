#FROM  mcr.microsoft.com/dotnet/core/aspnet:6.0
FROM mcr.microsoft.com/dotnet/sdk:6.0
WORKDIR /app

EXPOSE 80
EXPOSE 443
COPY backend /app
RUN sed -i 's/TLSv1.2/TLSv1.0/g' /etc/ssl/openssl.cnf
ENTRYPOINT ["dotnet","backend.dll"]

