# Profiling with Open Telemetry: A Developers Story

This repository contains code and resources that are used in the 2022 Netreo Nugget Conference. **Register [here](https://registration.socio.events/e/nugget2022)**


## Prerequisites

* Node
* Docker Desktop
* Prefix >= v6 or Beta

## Prefix Beta Release downloads

Beta releases of Prefix have hard coded expiration dates after which they will no longer function.  To download the current version of Prefix go to the [Prefix product page](https://stackify.com/prefix/).


**Expires on October 25, 2022**

* [MacOs](https://prefix.blob.core.windows.net/pub-beta/stackify-prefix-2022.0825.1.0.beta.pkg)
* [Windows](https://prefix.blob.core.windows.net/pub-beta/stackify-prefix-2022.0825.1.0.beta.exe)
* [Linux Deb](https://prefix.blob.core.windows.net/pub-beta/stackify-prefix-2022.0825.1.0.beta.deb)

## Ui Links

These are the localhost links to Jaegar and Express UIs as configured in the repository.

* [Jaeger Ui](http://localhost:16686/)
* [Express Ui](http://localhost:3000/)

## Running the applications

**Running the collector and Jaeger**
```shell
docker> docker compose up
```

**Running the sample application**
```shell
otel-collector-sender> npm install
otel-collector-sender> npm run start
```