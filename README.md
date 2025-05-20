# Microservices Project
This project is a practical implementation of a microservices architecture following the teachings of Les Jackson. It leverages .NET, Kubernetes, SQL Server, RabbitMQ, and gRPC to build a scalable, event-driven system. The system consists of two independent microservices, each with its own persistence layer, and integrates both synchronous and asynchronous communication.

## Table of Contents

- [Overview](#overview)
- [Technologies Used](#technologies-used)
- [Features](#features)
- [Architecture](#architecture)

## Overview

This project is built by following the step-by-step guidance provided by **Les Jackson** in his course on building microservices with .NET. It demonstrates how to design and implement microservices using modern technologies, including:

- Two independent microservices with their own persistence layers.
- An API Gateway to route requests to the appropriate services.
- Asynchronous communication with RabbitMQ for event-driven processing.
- Synchronous communication between services using gRPC.
- Kubernetes for orchestration and deployment of the services.

## Technologies Used

- **.NET Core** – The framework used for building the microservices.
- **Kubernetes** – For orchestrating the containerized services.
- **SQL Server** – Database for persistent data storage for each microservice.
- **RabbitMQ** – Message broker for asynchronous event-driven communication.
- **gRPC** – For efficient synchronous communication between services.
- **Docker** – For containerizing the microservices.
- **API Gateway** – A gateway for routing incoming requests to the appropriate microservices.

## Features

- **Microservices Architecture** – Two independent services, each with its own domain and persistence.
- **API Gateway** – A central point for routing HTTP requests to the correct microservices.
- **Synchronous Communication (gRPC)** – Services communicate directly and efficiently using gRPC.
- **Asynchronous Messaging (RabbitMQ)** – Event-driven communication between services.
- **Kubernetes Deployment** – Services deployed in a Kubernetes cluster for automatic scaling and management.
- **Persistence Layers** – Each service has its own dedicated SQL Server database.
- **Logging & Monitoring** – Basic logging and monitoring for each service.

## Architecture

The architecture consists of the following components:

- **Platform Service**: A parent microservice that stores/edits platform data.
- **Command Service**: A microservice dependent on the Platform Service for storing/editing command information for each platform.
- **API Gateway**: Routes incoming requests to the appropriate service.
- **gRPC**: Synchronous communication between services for high-performance data exchange.
- **RabbitMQ**: Handles asynchronous messaging for event-driven communication.
- **Kubernetes**: Manages the deployment, scaling, and health of the microservices in a cluster.
