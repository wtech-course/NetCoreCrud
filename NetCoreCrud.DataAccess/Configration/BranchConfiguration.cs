using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NetCoreCrud.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreCrud.DataAccess.Configration
{
    public class BranchConfiguration : IEntityTypeConfiguration<Branch>
    {
        public void Configure(EntityTypeBuilder<Branch> builder)
        {
            builder
                .HasKey(a => a.Id);
            builder
                .Property(a => a.Id)
                .UseIdentityColumn();
            builder
                .Property(a => a.Name)
                .IsRequired()
                .HasMaxLength(50);
            builder
                .HasOne(a => a.Company)
                .WithMany(a => a.Branchs)
                .HasForeignKey(a => a.Company_Id);
            builder
                .ToTable("Branchs");
        }
    }
}
