## 🏬 SistemaLoja

---

## 📋 Descrição do Projeto

O **SistemaLoja** é um projeto desenvolvido em **C# (.NET 9)** para o **Lab 12 - Conexão com SQL Server**.  
Ele tem como objetivo demonstrar o uso do **ADO.NET** para conectar-se a um banco de dados SQL Server e realizar operações CRUD completas (Create, Read, Update, Delete) com transações seguras.

O sistema simula a gestão de uma loja, permitindo cadastrar produtos, categorias e pedidos, além de listar, atualizar e remover registros diretamente no banco de dados.

---

## 🐳 Configuração do SQL Server (Docker)

Para rodar o SQL Server localmente com Docker:

```bash
docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=SqlServer2024!" ^
-p 1433:1433 --name sqlserver2022 -d ^
mcr.microsoft.com/mssql/server:2022-latest ```
