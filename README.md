# 🚀 Mottu Smart Pátio - API RESTful

## 📄 Descrição

Este projeto é uma API RESTful desenvolvida em **ASP.NET Core Minimal API**, que gerencia o cadastro de **Motos** para controle de pátio de veículos. A aplicação implementa operações CRUD completas, integração com banco de dados **Oracle** via **Entity Framework Core (EF Core)** com utilização de Migrations para criação de tabelas, e documentação interativa utilizando **Swagger (OpenAPI)**.

---

## ✅ Funcionalidades

- Listar todas as motos
- Consultar moto por ID
- Consultar motos por status
- Cadastrar nova moto
- Atualizar moto existente
- Deletar moto
- Documentação via Swagger

---

## 🔗 Rotas

| Método | Rota                     | Descrição                            |
| ------ | ------------------------ | ------------------------------------ |
| GET    | `/`                      | Mensagem de status da API            |
| GET    | `/motos`                 | Lista todas as motos cadastradas     |
| GET    | `/motos/{id}`            | Consulta uma moto específica pelo ID |
| GET    | `/motos/status/{status}` | Lista motos filtrando por status     |
| POST   | `/motos`                 | Cadastra uma nova moto               |
| PUT    | `/motos/{id}`            | Atualiza uma moto existente          |
| DELETE | `/motos/{id}`            | Remove uma moto pelo ID              |

---

## ⚙️ Instalação e execução

### ✅ Pré-requisitos

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download)
- [Oracle Database](https://www.oracle.com/database/technologies/) **ou** ajustar a connection string para outro banco.
- Visual Studio ou Visual Studio Code

---

### 📥 Passos para instalação

1. **Clone o repositório:**

```bash
git clone https://github.com/seu-usuario/mottu-smart-patio.git
cd mottu-smart-patio
```
