using Buffet.Models.Buffet.Cliente;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Buffet.Database
{
    public class DatabaseContext : DbContext
    {
        public DbSet<ClienteEntity> Cliente { get; set; }
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }
    }
}
