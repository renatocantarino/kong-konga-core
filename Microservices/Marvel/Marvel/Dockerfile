FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build-env

WORKDIR /app

COPY ./ ./
RUN dotnet restore Marvel.csproj

COPY . ./
RUN dotnet publish -c Release -o out


FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim 
WORKDIR /app
COPY --from=build-env /app/out .
ENV ASPNETCORE_URLS=http://+:7002  
ENTRYPOINT ["dotnet", "Marvel.dll"]