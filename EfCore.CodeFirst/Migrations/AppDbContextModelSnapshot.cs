﻿// <auto-generated />
using EfCore.CodeFirst.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EfCore.CodeFirst.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EfCore.CodeFirst.DAL.BasePerson", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Persons", (string)null);
                });

            modelBuilder.Entity("EfCore.CodeFirst.DAL.Employee", b =>
                {
                    b.HasBaseType("EfCore.CodeFirst.DAL.BasePerson");

                    b.Property<decimal>("Salary")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.ToTable("Employees", (string)null);
                });

            modelBuilder.Entity("EfCore.CodeFirst.DAL.Manager", b =>
                {
                    b.HasBaseType("EfCore.CodeFirst.DAL.BasePerson");

                    b.Property<int>("Grade")
                        .HasColumnType("int");

                    b.ToTable("Managers", (string)null);
                });

            modelBuilder.Entity("EfCore.CodeFirst.DAL.Employee", b =>
                {
                    b.HasOne("EfCore.CodeFirst.DAL.BasePerson", null)
                        .WithOne()
                        .HasForeignKey("EfCore.CodeFirst.DAL.Employee", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EfCore.CodeFirst.DAL.Manager", b =>
                {
                    b.HasOne("EfCore.CodeFirst.DAL.BasePerson", null)
                        .WithOne()
                        .HasForeignKey("EfCore.CodeFirst.DAL.Manager", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
