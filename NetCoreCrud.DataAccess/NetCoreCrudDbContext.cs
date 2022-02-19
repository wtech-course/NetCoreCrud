using Microsoft.EntityFrameworkCore;
using NetCoreCrud.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreCrud.DataAccess
{
    public class NetCoreCrudDbContext :DbContext
    {
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=DESKTOP-7N3D723;Database=NETCoreCrudDB;uid=sa;pwd=Rizgar1341?");
        }
        public DbSet<Company> Companies { get; set; }
    }
}
