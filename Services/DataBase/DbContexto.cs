
using EntityFramework.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework.Services.DataBase
{
    public class DbContexto : DbContext
    {
        public DbSet<Cliente> Clientes {get; set;}

        public DbSet<Produto> Produtos {get; set;}

        public DbSet<Endereco> Enderecos {get; set;}

        public DbSet<Pedido> Pedidos {get; set;}

        public DbSet<PedidoProduto> PedidoProdutos {get; set;}

        public DbContexto(DbContextOptions<DbContexto> options)
            : base(options){}
    }     
}