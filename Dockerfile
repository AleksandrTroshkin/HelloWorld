FROM mcr.microsoft.com/dotnet/framework/sdk:4.8 AS build
COPY . /TestMVC

WORKDIR /TestMVC
RUN nuget restore

WORKDIR /TestMVC/TestMVC
RUN msbuild /p:Configuration=Release

FROM mcr.microsoft.com/dotnet/framework/aspnet:4.8 AS runtime
WORKDIR /inetpub/wwwroot
COPY --from=build /TestMVC/TestMVC/. ./


