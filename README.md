# TesteGa
## Projeto realizado como teste para Empresa GA.

# Descrição
Implemetado Crud basico utilizando conceito de Camadas, Repositorios, Interfaces e DDD.
Foi utilizado Asp.Net 6 como Framework principal.
Utilizado Entity Framework para Acesso a dados.
Utilizado Npgsql.EntityFrameworkCore.PostgreSQL para comunicacao com a base de dados.

## Base utilizada
Foi usado PostgreSql como base para salvar os dados. 
Banco Local usando containers docker.

# Instalação
Necessário ter instalado o EntityFramework na máquina que irá rodar o projeto. 
Executar um restore para baixar as dependências. 
Executar o comando para atualizar/criar o banco com base nas migrações do projeto.

## Comando: 
### dotnet ef database update --project ../TesteGa.Repository/TesteGa.Repository.csproj

# Melhorias

Melhorar telas de apresentação e refatorar configurações que estão na classe principal para arquivos distintos.
