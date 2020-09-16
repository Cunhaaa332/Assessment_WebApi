using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Mapping {
    public class LivroMap : IEntityTypeConfiguration<Livro> {
        public void Configure(EntityTypeBuilder<Livro> builder) {
            builder.ToTable("Livros");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired().ValueGeneratedOnAdd();

            builder.Property(x => x.Titulo).IsRequired().HasMaxLength(200);
            builder.Property(x => x.ISBN).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Ano).IsRequired().HasMaxLength(50);

        }
    }
}
