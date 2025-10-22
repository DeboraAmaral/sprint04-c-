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
mcr.microsoft.com/mssql/server:2022-latest 
```

Verifique se o container está ativo:
```bash
docker ps
```

## 🗄️ Script do Banco de Dados (setup.sql)

Copie e cole o script abaixo para criar o banco e as tabelas necessárias para o projeto.

```bash
-- Criação do Banco de Dados
CREATE DATABASE SistemaLojaDB;
GO

USE SistemaLojaDB;
GO

-- Tabela de Categorias
CREATE TABLE Categorias (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Nome NVARCHAR(100) NOT NULL
);
GO

-- Tabela de Produtos
CREATE TABLE Produtos (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Nome NVARCHAR(100) NOT NULL,
    Preco DECIMAL(10,2) NOT NULL,
    CategoriaId INT NOT NULL,
    CONSTRAINT FK_Produto_Categoria FOREIGN KEY (CategoriaId) REFERENCES Categorias(Id)
);
GO

-- Tabela de Clientes
CREATE TABLE Clientes (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Nome NVARCHAR(150) NOT NULL,
    Email NVARCHAR(150) NOT NULL
);
GO

-- Tabela de Pedidos
CREATE TABLE Pedidos (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    ClienteId INT NOT NULL,
    DataPedido DATETIME NOT NULL DEFAULT GETDATE(),
    Total DECIMAL(10,2) NOT NULL,
    CONSTRAINT FK_Pedido_Cliente FOREIGN KEY (ClienteId) REFERENCES Clientes(Id)
);
GO

-- Tabela de Itens do Pedido
CREATE TABLE PedidoItens (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    PedidoId INT NOT NULL,
    ProdutoId INT NOT NULL,
    Quantidade INT NOT NULL,
    Subtotal DECIMAL(10,2) NOT NULL,
    CONSTRAINT FK_Item_Pedido FOREIGN KEY (PedidoId) REFERENCES Pedidos(Id),
    CONSTRAINT FK_Item_Produto FOREIGN KEY (ProdutoId) REFERENCES Produtos(Id)
);
GO

-- Inserindo Categorias Padrão
INSERT INTO Categorias (Nome) VALUES ('Informática'), ('Eletrônicos'), ('Livros');
GO

-- Inserindo Produtos Padrão
INSERT INTO Produtos (Nome, Preco, CategoriaId)
VALUES
('Notebook Dell', 3500.00, 1),
('Smartphone Samsung', 2500.00, 2),
('Livro - C# Essencial', 120.00, 3);
GO

-- Inserindo Cliente de Teste
INSERT INTO Clientes (Nome, Email)
VALUES ('Cliente Exemplo', 'cliente@exemplo.com');
GO
```

## 🚀 Execução do Projeto

1. Clone o repositório:

```bash
git clone https://github.com/DeboraAmaral/sprint04-c-.git
```

2. Acesse a pasta:

```bash
cd SistemaLoja/SistemaLoja
```

3. Execute o sistema:

```bash
dotnet run
```

4. Utilize o menu interativo no console para:

- 📦 Listar, inserir, atualizar e remover produtos

- 🧾 Criar e listar pedidos

- 🔍 Pesquisar por categoria
  

## 👥 Equipe do Projeto

[Debora da Silva Amaral - RM 550412],
[Eduardo Pielich Sanchez - RM 99767],
[Livia Namba Seraphim - RM 97819]
Turma: 3ESPY – Engenharia de Software
