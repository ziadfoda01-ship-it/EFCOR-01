using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Text;
using EFCOR_01;

namespace EFCOR_01.ConTexte
{
    public class AddDbConTexte :DbContext 

    {
      
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           optionsBuilder.UseSqlServer ("Server = . ; Datebase = EFCore01 ; Trusted_Connection =true ; TrustedServerCertificate = true");
        }
        public DbSet<Product> Products { get;set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
