# API REST de Carros

Bem-vindo ao repositório da API REST de Carros! Este projeto consiste em uma implementação de um CRUD (Create, Read, Update, Delete) em uma API ASP.NET Web API para gerenciamento de informações sobre carros.

## Visão Geral

Este projeto foi desenvolvido com o propósito de fornecer um serviço simples e eficiente para gerenciamento de informações sobre carros. Utilizando os princípios RESTful, a API oferece endpoints para realizar operações básicas em uma coleção de carros.

### Recursos Principais

- **CRUD de Carros:** A API oferece endpoints para criar, listar, atualizar e excluir carros.
- **Validação de Dados:** Implementamos validações para garantir a integridade dos dados e a consistência das operações.
- **Documentação:** Uma documentação detalhada da API está disponível para facilitar o uso e integração por parte dos desenvolvedores.
- **Segurança:** Mecanismos de segurança estão incorporados para proteger os dados e os endpoints da API.

## EndPoints da APi
- **Listagem de Carros [GET]** `http://localhost:5164/api/Car`
- **Criação de Carros [POST]** `http://localhost:5164/api/Car`
Body da Requisição: `{"name": "Nome do carro", "email":"Email@example.com"}`
- **Edição de Carros [PUT]** `http://localhost:5164/api/Car/{id}`
Params da Requisição Id, Body da requisição: `{"name": "Nome do carro", "email":"Email@example.com"}`
- **Deleção de Carros [DELETE]** `http://localhost:5164/api/Car/{id}`
Params da requisição Id

Contribuições são bem-vindas! Sinta-se à vontade para propor melhorias, relatar bugs ou enviar pull requests para este repositório. Por favor, siga as diretrizes de contribuição especificadas no arquivo CONTRIBUTING.md.

## Tecnologias Utilizadas

- **ASP.NET Web API:** Framework para construção de APIs RESTful em ambiente .NET.
- **Entity Framework:** ORM (Object-Relational Mapper) para acesso e manipulação de dados.
- **C#:** Linguagem de programação principal do projeto.
- **Swagger/OpenAPI:** Para documentação da API.

## Como Utilizar

1. **Clonar o Repositório:** `git clone https://github.com/seu-usuario/nome-do-repo.git`
2. **Configurar o Ambiente:** Certifique-se de ter o ambiente .NET configurado.
3. **Instalar Dependências:**
`
   dotnet build
`
4. **Efetuar migrações**
`
   dotnet ef migrations add nomeDaMigration
`
5. **Efetuar Atualização do Banco**
`
   dotnet ef database update
`

## Contribuições

Contribuições são bem-vindas! Sinta-se à vontade para propor melhorias, relatar bugs ou enviar pull requests para este repositório. Por favor, siga as diretrizes de contribuição especificadas no arquivo CONTRIBUTING.md.

## Autores

Esta API foi desenvolvida por [ViniHGV](https://github.com/ViniHGV).

