# Profiling with Open Telemetry: A Developers Story

This repository contains code and resources that are used in the 2022 Netreo Nugget Conference. **Register [here](https://registration.socio.events/e/nugget2022)**


## Prerequisites

* Node
* DotNet Core
* Docker Desktop
* Prefix >= v6 or Developer Release

## Prefix Developer Release

Developer releases of Prefix have hard coded expiration dates after which they will no longer function. They are released as is with no warranty, support or promise of any kind.  Use at your own risk.  

To download the current version of Prefix go to the [Prefix product page](https://stackify.com/prefix/).


**Expires on January 24, 2023**

### Download Links

* [MacOs](https://prefix.blob.core.windows.net/pub-beta/stackify-prefix-2022.1024.1.0.beta.pkg)
* [Windows](https://prefix.blob.core.windows.net/pub-beta/stackify-prefix-2022.1024.1.0.beta.exe)
* [Linux Deb](https://prefix.blob.core.windows.net/pub-beta/stackify-prefix-2022.1024.1.0.beta.deb)

## Ui Links

These are the localhost links to UIs as configured in the repository.

* [Jaeger Ui](http://localhost:16686/)
* [Express Ui](http://localhost:3000/)
* [Dotnet App](http://localhost:6001/)

## Running the applications

**Running the collector and Jaeger**
```shell
docker> docker compose up
```

**Running the sample node application**
```shell
otel-collector-sender> npm install
otel-collector-sender> npm run start
```

**Running the sample dotnet application**
```shell
src/Nugget2022/Nugget2022> dotnet restore
src/Nugget2022/Nugget2022> dotnet run
```

## Connecting your application

Setup your application with OpenTelemetry as defined by the language documentation.  Make sure to use the otlp protocol, either the http or grpc versions.

**Routes**
* HTTP: `http://localhost:4318/v1/traces`
* GRPC: `localhost:4317`
