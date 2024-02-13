# Informações gerais:
<pre>
    Utilizando .NET 8
    Projeto no modelo MVC
    Repositório no gitHub: https://github.com/Joao-v-almeida/EntityFramework
</pre>

# Pacotes intalados:
<pre>
    dotnet add package Microsoft.EntityFrameworkCore --version 8.0.1
    dotnet add package Microsoft.EntityFrameworkCore.Tools --version 8.0.1
    dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 8.0.1
    dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design --version 8.0.0
</pre>

# Migração
<pre>
    dotnet ef migrations add 'nome'
</pre>

<pre>
    dotnet ef database update
</pre>

# Intalação do code generator
<pre>
    dotnet tool install -g dotnet-aspnet-codegenerator
</pre>

# Scaffolding 
<pre>
    dotnet aspnet-codegenerator controller -name ClientesController -m EntityFramework.Models.Cliente -dc DbContexto --relativeFolderPath Controllers --useDefaultLayout

    dotnet aspnet-codegenerator controller -name ProdutosController -m EntityFramework.Models.Produto -dc DbContexto --relativeFolderPath Controllers --useDefaultLayout

    dotnet aspnet-codegenerator controller -name EnderecosController -m EntityFramework.Models.Endereco -dc DbContexto --relativeFolderPath Controllers --useDefaultLayout

    dotnet aspnet-codegenerator controller -name PedidosController -m EntityFramework.Models.Pedido -dc DbContexto --relativeFolderPath Controllers --useDefaultLayout

    dotnet aspnet-codegenerator controller -name PedidoProdutosController -m EntityFramework.Models.PedidoProdutos -dc DbContexto --relativeFolderPath Controllers --useDefaultLayout
</pre>