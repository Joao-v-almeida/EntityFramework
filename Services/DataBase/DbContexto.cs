
using EntityFramework.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework.Services.DataBase
{
    public class DbContexto : DbContext
    {
        public DbSet<Cliente> Clientes {get; set;}
        
        public DbContexto(DbContextOptions<DbContexto> options)
            : base(options){}
    }     
}