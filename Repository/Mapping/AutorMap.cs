using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Mapping {
    public class AutorMap : IEntityTypeConfiguration<Autor> {
        public void Configure(EntityTypeBuilder<Autor> builder) {
            builder.ToTable("Autores");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired().ValueGeneratedOnAdd();

            builder.Property(x => x.Nome).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Sobrenome).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Email).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Birth).IsRequired();

            builder.HasMany<Livro>(x => x.Livros).WithOne(x => x.Autor);
        }
    }
}
