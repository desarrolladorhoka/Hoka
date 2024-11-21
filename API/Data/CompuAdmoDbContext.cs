using System.Data.Entity;
using API.Models;

namespace Ahueso.Data
{
    public class CompuAdmoDbContext : DbContext
    {
        public CompuAdmoDbContext() : base("name=CompuAdmoDbContext") { }

        public DbSet<BancoProveedores> BancoProveedores { get; set; }
    }
}
