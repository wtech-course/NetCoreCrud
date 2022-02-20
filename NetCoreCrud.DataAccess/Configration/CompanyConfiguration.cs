using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NetCoreCrud.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreCrud.DataAccess.Configration
{
    public class CompanyConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            //builder tabloya ait özelliklere ve kolonlara erişmemizi sağlar.

            builder
                .HasKey(a => a.Company_Id);
            builder
                .Property(a => a.Company_Id)
                .UseIdentityColumn();
            builder
                .Property(a => a.Company_Name)
                .IsRequired()
                .HasMaxLength(50);
            builder.ToTable("Companies");
        }
    }
}
