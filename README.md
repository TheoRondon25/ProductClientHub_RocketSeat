# 📚 ProductClientHub - API em C# e .NET

Bem-vindo ao repositório **ProductClientHub**, um projeto desenvolvido como parte do curso introdutório de C# e .NET oferecido pela Rocketseat.  
Este projeto tem como objetivo consolidar os conhecimentos adquiridos no desenvolvimento de APIs modernas utilizando C# e .NET.

## 📝 Descrição

Neste projeto, foram abordados os principais conceitos e práticas no desenvolvimento de APIs RESTful, incluindo:

- Estruturação de projetos em camadas.
- Criação de endpoints usando os métodos HTTP: `GET`, `POST`, `DELETE` e `UPDATE`.
- Tratamento de exceções e aplicação de boas práticas.
- Persistência de dados utilizando **Entity Framework Core** com **SQLite**.
- Separação de responsabilidades com foco em manutenibilidade e escalabilidade.

## 🗂️ Estrutura do Projeto

```
ProductClientHub.API
├── Connected Services
├── Dependências
├── Properties
├── Controllers            # Endpoints da API
├── Entities               # Entidades de domínio
├── Filters                # Filtros de exceção
├── Infraestruture         # Conexão com o banco de dados (SQLite)
├── UseCases               # Casos de uso (lógica de negócio)
├── appsettings.json       # Configurações da aplicação
├── ProductClientHub.API.http  # Arquivo para testes via HTTP
└── Program.cs             # Configuração e inicialização da aplicação

ProductClientHub.Communication
├── Dependências
├── Requests               # Modelos de requisição
└── Responses              # Modelos de resposta

ProductClientHub.Exceptions
├── Dependências
└── ExceptionBase          # Estrutura base para exceções personalizadas
```

## 🛠️ Tecnologias Utilizadas

- **C#**
- **.NET (ASP.NET Core)**
- **Entity Framework Core**
- **SQLite** (banco de dados local)
- **Visual Studio**
- **Postman** (para testes de API)

## ⚙️ Como Executar o Projeto

1. Clone este repositório:

   ```bash
   git clone https://github.com/seu-usuario/ProductClientHub.git
   ```

2. Acesse a pasta do projeto:

   ```bash
   cd ProductClientHub
   ```

3. Restaure as dependências:

   ```bash
   dotnet restore
   ```

4. Execute as migrações para criar o banco SQLite (se aplicável):

   ```bash
   dotnet ef database update
   ```

5. Execute a aplicação:

   ```bash
   dotnet run --project ProductClientHub.API
   ```

6. Acesse a API em:

   ```
   https://localhost:5001
   ```

## ✅ Funcionalidades

- Estrutura de API RESTful completa.
- Padrão de camadas com divisão clara entre API, comunicação e exceções.
- Persistência de dados local via **SQLite**.
- Boas práticas de desenvolvimento e tratamento de erros.

## 📌 Próximos Passos

- Implementar autenticação e autorização.
- Criar testes automatizados.
- Publicar a documentação usando **Swagger**.
- Deploy em ambiente de produção.

## 🤝 Contribuição

Este projeto é um exercício pessoal, mas contribuições são bem-vindas!  
Sinta-se à vontade para abrir issues ou enviar pull requests.
