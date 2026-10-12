using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Day03LINQ.Models;

namespace Day03LINQ.Configurations
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.Property(b => b.Title)
                .IsRequired()
                .HasMaxLength(150);
            builder.Property(b => b.Price)
                .HasColumnType("decimal(8,2)");
            builder.Property(b => b.PublishedDate)
                .IsRequired(false);
        }
    }
}
