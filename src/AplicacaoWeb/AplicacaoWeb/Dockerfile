FROM mcr.microsoft.com/dotnet/aspnet:5.0-alpine AS base

ARG PUBLISH_DIRECTORY

EXPOSE 80

WORKDIR /app

COPY $PUBLISH_DIRECTORY .

ENTRYPOINT ["dotnet", "AplicacaoWeb.dll"]