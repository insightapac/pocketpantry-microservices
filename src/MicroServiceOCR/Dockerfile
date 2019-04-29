FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["MicroServiceOCR.csproj", "MicroServiceOCR/"]
RUN dotnet restore "MicroServiceOCR/MicroServiceOCR.csproj"
COPY . ./MicroServiceOCR
WORKDIR "/src/MicroServiceOCR"
RUN dotnet build "MicroServiceOCR.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "MicroServiceOCR.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "MicroServiceOCR.dll"]