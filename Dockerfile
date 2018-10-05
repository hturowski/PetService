FROM microsoft/dotnet:2.1-sdk as build
WORKDIR /app

COPY . /app
RUN dotnet restore

RUN dotnet publish -c Release -o out

FROM microsoft/dotnet:2.1-aspnetcore-runtime AS runtime
WORKDIR /app
COPY --from=build /app/out ./

EXPOSE 80
ENTRYPOINT ["dotnet", "/app/restTest.dll"]
