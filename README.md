# API REST com DDD e JWT — ASP.NET Core

API RESTful desenvolvida em C# com ASP.NET Core seguindo os princípios de **Domain-Driven Design (DDD)**, com autenticação via **JWT** e arquitetura em camadas bem definidas.

## Sobre o projeto

O sistema permite o gerenciamento de notícias com controle de acesso por usuário autenticado. Cada notícia é vinculada ao usuário logado via token JWT, garantindo isolamento e segurança nos dados.

## Funcionalidades

- Autenticação e geração de token JWT
- Cadastro de usuários
- CRUD completo de notícias (criar, listar, atualizar, excluir, buscar por ID)
- Autorização por endpoint com `[Authorize]`
- Retorno de notificações de validação por operação

## Arquitetura

O projeto segue a separação de responsabilidades do DDD com 5 camadas independentes:

## Tecnologias

- C# / .NET
- ASP.NET Core Web API
- JWT (JSON Web Token)
- Injeção de dependência nativa do ASP.NET Core
- CORS configurado para integração com frontends
- Arquitetura DDD

## Endpoints principais

| Método | Rota | Descrição | Auth |
|--------|------|-----------|------|
| POST | `/api/Usuario` | Cadastrar usuário | ❌ |
| POST | `/api/Login` | Autenticar e obter token | ❌ |
| POST | `/api/ListarNoticias` | Listar notícias ativas | ✅ |
| POST | `/api/AdicionaNoticia` | Criar notícia | ✅ |
| POST | `/api/AtualizaNoticia` | Atualizar notícia | ✅ |
| POST | `/api/ExcluirNoticia` | Excluir notícia | ✅ |
| POST | `/api/BuscarPorId` | Buscar notícia por ID | ✅ |

## Como rodar

```bash
# Clone o repositório
git clone https://github.com/matheuscardosolazzarini/API_DDD.git

# Acesse a pasta
cd API_DDD

# Restaure as dependências
dotnet restore

# Configure a string de conexão em WebAPI/appsettings.json

# Execute
dotnet run --project WebAPI
```

## O que aprendi com este projeto

- Estruturação de projetos com DDD na prática
- Geração e validação de tokens JWT em ASP.NET Core
- Separação de responsabilidades entre camadas de domínio, aplicação e infraestrutura
- Uso de interfaces para inversão de dependência entre camadas
