FROM microsoft/microsoft/aspnetcore
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY *.csproj ./

ENV ASPNETCORE_URLS http://+:80
EXPOSE 80

RUN dotnet restore

# Copy everything else and build
COPY . ./
RUN dotnet publish -c Release -o out

# Build runtime image
FROM microsoft/aspnetcore:2.0
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "run"]
