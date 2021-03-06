// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TodoApi.Models;

namespace ToDo_Base.Migrations
{
    [DbContext(typeof(TodoDBContext))]
    partial class TodoDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TodoApi.Models.TodoItem", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsComplete")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TodoItems");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            IsComplete = true,
                            Name = "Pay Property Tax1"
                        },
                        new
                        {
                            Id = 2L,
                            IsComplete = true,
                            Name = "Pay Property Tax2"
                        },
                        new
                        {
                            Id = 3L,
                            IsComplete = false,
                            Name = "Pay Property Tax3"
                        },
                        new
                        {
                            Id = 4L,
                            IsComplete = false,
                            Name = "Pay Property Tax4"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
