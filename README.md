# paradigma

####Requisitos minimos:
<ol>
    <li>dotnet v5</li>
    <li>dotnet tool  --global dotnet-ef</li>
    <li>postgres</li>
    <li>Docker (opcional).</li>
</ol>
####Passo a passo para executar a aplicação
Clone o repositório em seu computador: https://github.com/Scalfi/paradigma.git

#####Entre na pasta do repositorio e rode o codigo:
`dotnet restore`

#####Banco de dados:
Para configurar o banco de dados, selecione o appsettings e na linha ParadigmaDB configure as credencias de conexão com seu banco de dados postgres
  `"ParadigmaDB": "Host=localhost;Port=15432;Pooling=true;Database=Paradigma;User Id=postgres;Password=123456;"`
  
Caso tenha o postgres instalado ignore esse passo.
Instale o docker e dentro da raiz do projeto rode o comando:
`docker-compose up -d`
 E deixe o ParadigmaDB como está.

Para criar as tabelas no banco de dados você deve ir na  raiz do projeto e rodar o comando:
`dotnet ef database update`

  Com programa restaurado e banco de dados configurado, rode o comando abaixo para iniciar o sistema
`dotnet run`
