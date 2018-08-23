FROM microsoft/aspnetcore:2.0
WORKDIR /app
EXPOSE 80
COPY published ./
ENTRYPOINT ["dotnet", "HealthProbe.dll"]
