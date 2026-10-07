# 🛒 Ecommerce CRUD

Uma API REST desenvolvida em **C#**, utilizando **ASP.NET Core**, criada para praticar o desenvolvimento de APIs e operações de CRUD (*Create, Read, Update e Delete*).

## 📋 Sobre o projeto

O **Ecommerce CRUD** é uma API para gerenciamento de produtos de um e-commerce.

O sistema permite cadastrar, listar, buscar, alterar e excluir produtos através de diferentes endpoints HTTP.

Cada produto possui os seguintes atributos:

* ID
* Nome
* Valor
* Data de criação

Os dados são armazenados em uma lista durante a execução da aplicação.

## 🛠️ Tecnologias

| Tecnologia             | Utilização                                      |
| ---------------------- | ----------------------------------------------- |
| **C#**                 | Linguagem utilizada no desenvolvimento          |
| **.NET 8**             | Plataforma utilizada para execução da aplicação |
| **ASP.NET Core**       | Desenvolvimento da API                          |
| **Visual Studio Code** | Editor utilizado no desenvolvimento             |
| **Git**                | Controle de versão                              |
| **GitHub**             | Armazenamento e gerenciamento do projeto        |

## 📚 Conceitos praticados

| Conceito               | Aplicação no projeto                                 |
| ---------------------- | ---------------------------------------------------- |
| **C#**                 | Desenvolvimento da aplicação                         |
| **ASP.NET Core**       | Criação da API                                       |
| **API REST**           | Comunicação através de endpoints HTTP                |
| **CRUD**               | Cadastro, consulta, alteração e exclusão de produtos |
| **GET**                | Listagem e busca de produtos                         |
| **POST**               | Cadastro de produtos                                 |
| **PUT**                | Alteração de produtos                                |
| **DELETE**             | Exclusão de produtos                                 |
| **List**               | Armazenamento dos produtos em memória                |
| **LINQ**               | Busca de produtos utilizando `FirstOrDefault()`      |
| **Classes e objetos**  | Representação dos produtos                           |
| **Validação de dados** | Verificação das informações enviadas para a API      |
| **HTTP Status Codes**  | Retorno de respostas HTTP                            |
| **Parâmetros de rota** | Identificação de produtos por ID ou nome             |

## 📦 Modelo do produto

Cada produto possui os seguintes atributos:

| Atributo   | Tipo       | Descrição                                  |
| ---------- | ---------- | ------------------------------------------ |
| `Id`       | `string`   | Identificador único gerado automaticamente |
| `Nome`     | `string`   | Nome do produto                            |
| `Valor`    | `double`   | Valor do produto                           |
| `CriadoEm` | `DateTime` | Data e hora de criação                     |

## 🔗 Endpoints

### 🏠 Página inicial

`GET /`

Retorna uma mensagem indicando que a API está funcionando.

### ➕ Cadastrar produto

`POST /api/produto/cadastrar`

Cadastra um novo produto.

Exemplo de dados enviados:

```json
{
    "nome": "Notebook",
    "valor": 3500
}
```

O sistema verifica se o produto foi enviado corretamente, se o nome foi informado, se o valor é maior que zero e se não existe outro produto com o mesmo nome.

### 📋 Listar produtos

`GET /api/produto/listar`

Retorna todos os produtos cadastrados. Caso não existam produtos, a API informa que nenhum produto foi cadastrado.

### 🔎 Buscar produto

`GET /api/produto/buscar/{nome}`

Busca um produto pelo nome.

Exemplo:

`GET /api/produto/buscar/Notebook`

### ✏️ Alterar produto

`PUT /api/produto/alterar/{id}`

Altera os dados de um produto existente.

Exemplo de dados enviados:

```json
{
    "nome": "Notebook Gamer",
    "valor": 4500
}
```

O sistema verifica se o produto existe, se o nome foi informado, se o valor é maior que zero e se não existe outro produto utilizando o mesmo nome.

### 🗑️ Excluir produto

`DELETE /api/produto/deletar/{id}`

Remove um produto utilizando seu identificador.

Exemplo:

`DELETE /api/produto/deletar/ID_DO_PRODUTO`

## 🔄 Operações CRUD

| Operação   | Método HTTP | Endpoint                     |
| ---------- | ----------- | ---------------------------- |
| **Create** | `POST`      | `/api/produto/cadastrar`     |
| **Read**   | `GET`       | `/api/produto/listar`        |
| **Read**   | `GET`       | `/api/produto/buscar/{nome}` |
| **Update** | `PUT`       | `/api/produto/alterar/{id}`  |
| **Delete** | `DELETE`    | `/api/produto/deletar/{id}`  |

## 🧠 Validações

A API possui validações para evitar o processamento de dados inválidos.

Entre elas:

* Verificação de dados nulos;
* Verificação de nome vazio;
* Verificação de valor maior que zero;
* Verificação de nomes duplicados;
* Verificação da existência do produto antes de alterá-lo ou excluí-lo.

## 💾 Armazenamento de dados

Atualmente, os produtos são armazenados em uma lista:

```csharp
List<Produto>
```

Isso significa que os dados ficam apenas em memória enquanto a aplicação está em execução. Ao reiniciar a aplicação, os produtos cadastrados são perdidos.

O projeto ainda não utiliza um banco de dados.

## 🎯 Objetivo

O principal objetivo do projeto é praticar o desenvolvimento de **APIs utilizando C# e ASP.NET Core**, aplicando conceitos de programação e comunicação HTTP.

Durante o desenvolvimento, foram praticados conceitos como:

* CRUD;
* APIs REST;
* Métodos HTTP;
* Classes e objetos;
* Listas;
* LINQ;
* Validação de dados;
* Rotas e parâmetros;
* Códigos de status HTTP;
* Manipulação de dados.

## 📌 Status

🚧 Projeto desenvolvido para fins de estudo e em constante evolução.

---

⭐ Desenvolvido durante meus estudos de **C# e Ciência da Computação**.
