using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using CanalNoticias.Data;

namespace CanalNoticias.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CanalNoticias.Models.Noticia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Data");

                    b.Property<string>("Descricao")
                        .IsRequired();

                    b.Property<bool>("EhDestaque");

                    b.Property<string>("EstiloMusical");

                    b.Property<string>("FotoPrincipal")
                        .IsRequired();

                    b.Property<string>("Titulo")
                        .IsRequired();

                    b.Property<string>("TituloURL");

                    b.HasKey("Id");

                    b.ToTable("Noticias");
                });
        }
    }
}
