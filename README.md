# Biblioteca

Biblioteca é uma API RESTful que permite gerenciar uma coleção de livros e seus autores, usando o ASP.NET Core como framework de desenvolvimento web. Com essa API, você pode realizar as seguintes operações:

- Obter a lista de todos os livros da biblioteca
- Obter os detalhes de um livro pelo seu identificador
- Criar um novo livro na biblioteca
- Atualizar os dados de um livro pelo seu identificador
- Excluir um livro pelo seu identificador
- Adicionar um autor a um livro pelo seu identificador

# Instalação
Para instalar e executar essa API, você precisa ter o .NET 7.0 SDK instalado no seu computador. Você também precisa ter o Visual Studio Community 2022 ou outro editor de código de sua preferência.

Depois de instalar as dependências, siga os passos abaixo:

- Clone este repositório:
- Abra o projeto no Visual Studio Community 2022 ou outro editor de código.
- Execute a aplicação clicando
- Abra o navegador e acesse a URL “https://localhost:7255/swagger/index.html” para ver a página do Swagger com os endpoints da API.

# Uso
Para usar essa API, você pode enviar e receber requisições HTTP para os endpoints da API usando a ferramenta Swagger, que permite testar a API de forma interativa e documentada. 

- GET /api/biblioteca/: retorna a lista de todos os livros da biblioteca.
- GET /api/biblioteca/{id}: retorna os detalhes de um livro pelo seu identificador.
- POST /api/biblioteca: cria um novo livro na biblioteca. O corpo da requisição deve conter um objeto JSON com os atributos do livro, como no exemplo abaixo:
- PUT /api/biblioteca/{id}: atualiza os dados de um livro pelo seu identificador. O corpo da requisição deve conter um objeto JSON com os atributos do livro que serão atualizados, como no exemplo abaixo:
- DELETE /api/biblioteca/{id}: exclui um livro pelo seu identificador.
- POST /api/biblioteca/{id}/autores: adiciona um autor a um livro pelo seu identificador. O corpo da requisição deve conter um objeto JSON com os atributos do autor, como no exemplo abaixo:
