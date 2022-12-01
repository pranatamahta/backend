FROM  mcr.microsoft.com/dotnet/core/aspnet:3.1

WORKDIR /app

EXPOSE 80
EXPOSE 443
COPY backend /app
RUN sed -i 's/TLSv1.2/TLSv1.0/g' /etc/ssl/openssl.cnf
ENTRYPOINT ["dotnet","backend.dll"]

