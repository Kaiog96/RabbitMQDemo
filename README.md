# 🐇 RabbitMQDemo

A simple .NET 8 demo showcasing **Domain-Driven Design (DDD)** architecture with **RabbitMQ**, using separated APIs for message production and consumption.

## 📦 Project Structure (DDD)

This project follows the **DDD** architecture:

- **Presentation Layer**  
  Exposes APIs for message sending and receiving (`ProducerAPI`, `ConsumerAPI`).

- **Application Layer**  
  Coordinates application logic through interfaces and services.

- **Domain Layer**  
  Contains core business logic and interfaces (`IRabbitMQSenderService`, `IRabbitMQConsumerService`, etc).

- **Infrastructure Layer**  
  Handles integration with external systems (RabbitMQ sender and consumer implementations).

## 🚀 How to Run

### 1. Start RabbitMQ via Docker:

```bash
docker-compose up -d
```

- RabbitMQ running at: [http://localhost:15672](http://localhost:15672)  
- Default credentials: `guest / guest`

### 2. Run the APIs (Producer and Consumer)

You can run them via **Visual Studio** or terminal:

```bash
dotnet run --project RabbitMQDemo.ProducerAPI
dotnet run --project RabbitMQDemo.ConsumerAPI
```

Once running, access Swagger UI for each:

- Producer Swagger: [http://localhost:5062/swagger](http://localhost:5062/swagger)
- Consumer Swagger: [http://localhost:5038/swagger](http://localhost:5038/swagger)
