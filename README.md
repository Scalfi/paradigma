# paradigma

<h4>Requisitos minimos:</h4>
<ol>
    <li>.NET 5</li>
    <li>dotnet tool  --global dotnet-ef</li>
    <li>postgres</li>
    <li>Docker (opcional).</li>
</ol>
<h4>Passo a passo para executar a aplicação:</h4>
Clone o repositório em seu computador: https://github.com/Scalfi/paradigma.git

<h4>Entre na pasta do repositorio e rode o codigo:</h4>
`dotnet restore`

<h4>Banco de dados:</h4>
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
