
using Churrasco.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Churrasco.Migrations
{
    [DbContext(typeof(ChurrascoContext))]
    partial class ChurrascoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Churrasco.Models.Evento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Bebida")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("BebidaConvidado")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("ConfirmaConvidado")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Evento");
                });
#pragma warning restore 612, 618
        }
    }
}
