using Domain;
using Microsoft.EntityFrameworkCore;
using Repository.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Context {
    public class BibliotecaContext : DbContext {
        public DbSet<Autor> Autores { get; set; }
        public DbSet<Livro> Livros { get; set; }

        public BibliotecaContext(DbContextOptions<BibliotecaContext> options) : base(options) {

        }



        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.ApplyConfiguration(new LivroMap());
            modelBuilder.ApplyConfiguration(new AutorMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
