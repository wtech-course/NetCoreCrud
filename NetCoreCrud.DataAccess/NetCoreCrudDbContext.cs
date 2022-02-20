using Microsoft.EntityFrameworkCore;
using NetCoreCrud.DataAccess.Configration;
using NetCoreCrud.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreCrud.DataAccess
{
    public class NetCoreCrudDbContext : DbContext
    {
        public NetCoreCrudDbContext()
        {
        }

        public NetCoreCrudDbContext(DbContextOptions<NetCoreCrudDbContext> options)
            : base(options)
        {}
        public DbSet<Company> Companies { get; set; }
        public DbSet<Branch> Branchs { get; set; }

        //OnmodelCreating methodu tabloların özelliklerine erişmemizi ve konfigure etmemizi sağlar.
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder
                .ApplyConfiguration(new BranchConfiguration());
            builder
                .ApplyConfiguration(new CompanyConfiguration());
        }

    }
}
