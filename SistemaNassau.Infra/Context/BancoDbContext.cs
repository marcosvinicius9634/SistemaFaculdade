using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SistemaNassau.Domain.Entities;
using SistemaNassau.Infra.Mapping;

namespace SistemaNassau.Data.Context
{
    public class BancoDbContext:DbContext 
    {
        public BancoDbContext(DbContextOptions<BancoDbContext> option ) : base(option)
        {
            
        }
       
        public DbSet<User> Users{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMap());

            base.OnModelCreating(modelBuilder);
        }
       
    }
}
