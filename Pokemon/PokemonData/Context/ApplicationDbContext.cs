using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PokemonDomain.Entities.Security;
using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonData.Context
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, UserRole, Guid>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        //public DbSet<Entidad> Entidades { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<entity>();
        }
    }
}
