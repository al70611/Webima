﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Webima.Data;

namespace Webima.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Webima.Models.Admin", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("IdCrt")
                        .HasColumnType("int")
                        .HasColumnName("Id_Crt");

                    b.HasKey("Id");

                    b.HasIndex("IdCrt");

                    b.ToTable("Admin");
                });

            modelBuilder.Entity("Webima.Models.Bilhete", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Data")
                        .HasColumnType("date");

                    b.Property<int>("IdFilme")
                        .HasColumnType("int")
                        .HasColumnName("Id_Filme");

                    b.Property<int>("IdSala")
                        .HasColumnType("int")
                        .HasColumnName("Id_Sala");

                    b.Property<int>("IdSessao")
                        .HasColumnType("int")
                        .HasColumnName("Id_Sessao");

                    b.Property<decimal>("Preco")
                        .HasColumnType("money");

                    b.HasKey("Id");

                    b.HasIndex("IdFilme");

                    b.HasIndex("IdSala");

                    b.HasIndex("IdSessao");

                    b.ToTable("Bilhete");
                });

            modelBuilder.Entity("Webima.Models.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "Nome" }, "UQ__Categori__7D8FE3B22BBF0C19")
                        .IsUnique();

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("Webima.Models.CliCat", b =>
                {
                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("Id_Cliente");

                    b.Property<int>("IdCat")
                        .HasColumnType("int")
                        .HasColumnName("Id_Cat");

                    b.HasKey("IdCliente", "IdCat");

                    b.HasIndex("IdCat");

                    b.ToTable("Cli_Cat");
                });

            modelBuilder.Entity("Webima.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataNasc")
                        .HasColumnType("date")
                        .HasColumnName("Data_Nasc");

                    b.HasKey("Id");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("Webima.Models.Compra", b =>
                {
                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("Id_Cliente");

                    b.Property<int>("IdBil")
                        .HasColumnType("int")
                        .HasColumnName("Id_Bil");

                    b.Property<DateTime>("DataCompra")
                        .HasColumnType("datetime")
                        .HasColumnName("Data_Compra");

                    b.Property<int>("NumBil")
                        .HasColumnType("int")
                        .HasColumnName("Num_Bil");

                    b.HasKey("IdCliente", "IdBil");

                    b.HasIndex("IdBil");

                    b.ToTable("Compra");
                });

            modelBuilder.Entity("Webima.Models.Filme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Ano")
                        .HasColumnType("int");

                    b.Property<int>("Duracao")
                        .HasColumnType("int");

                    b.Property<string>("Elenco")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("Estreia")
                        .HasColumnType("date");

                    b.Property<int>("IdCat")
                        .HasColumnType("int")
                        .HasColumnName("Id_Cat");

                    b.Property<int>("IdFunc")
                        .HasColumnType("int")
                        .HasColumnName("Id_Func");

                    b.Property<string>("Poster")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Realizador")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Sinopse")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Trailer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdCat");

                    b.HasIndex("IdFunc");

                    b.ToTable("Filme");
                });

            modelBuilder.Entity("Webima.Models.Funcionario", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("IdAdmin")
                        .HasColumnType("int")
                        .HasColumnName("Id_Admin");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(9)
                        .HasColumnType("nvarchar(9)");

                    b.HasKey("Id");

                    b.HasIndex("IdAdmin");

                    b.ToTable("Funcionario");
                });

            modelBuilder.Entity("Webima.Models.Sala", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<int>("Lotacao")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Sala");
                });

            modelBuilder.Entity("Webima.Models.Sessao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<TimeSpan>("Horas")
                        .HasColumnType("time");

                    b.HasKey("Id");

                    b.ToTable("Sessao");
                });

            modelBuilder.Entity("Webima.Models.Utilizador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.ToTable("Utilizador");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Webima.Models.Admin", b =>
                {
                    b.HasOne("Webima.Models.Utilizador", "IdNavigation")
                        .WithOne("Admin")
                        .HasForeignKey("Webima.Models.Admin", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Webima.Models.Admin", "IdCrtNavigation")
                        .WithMany("InverseIdCrtNavigation")
                        .HasForeignKey("IdCrt")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IdCrtNavigation");

                    b.Navigation("IdNavigation");
                });

            modelBuilder.Entity("Webima.Models.Bilhete", b =>
                {
                    b.HasOne("Webima.Models.Filme", "IdFilmeNavigation")
                        .WithMany("Bilhetes")
                        .HasForeignKey("IdFilme")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Webima.Models.Sala", "IdSalaNavigation")
                        .WithMany("Bilhetes")
                        .HasForeignKey("IdSala")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Webima.Models.Sessao", "IdSessaoNavigation")
                        .WithMany("Bilhetes")
                        .HasForeignKey("IdSessao")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IdFilmeNavigation");

                    b.Navigation("IdSalaNavigation");

                    b.Navigation("IdSessaoNavigation");
                });

            modelBuilder.Entity("Webima.Models.CliCat", b =>
                {
                    b.HasOne("Webima.Models.Categoria", "IdCatNavigation")
                        .WithMany("CliCats")
                        .HasForeignKey("IdCat")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Webima.Models.Cliente", "IdClienteNavigation")
                        .WithMany("Categorias")
                        .HasForeignKey("IdCliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IdCatNavigation");

                    b.Navigation("IdClienteNavigation");
                });

            modelBuilder.Entity("Webima.Models.Cliente", b =>
                {
                    b.HasOne("Webima.Models.Utilizador", "IdNavigation")
                        .WithOne("Cliente")
                        .HasForeignKey("Webima.Models.Cliente", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IdNavigation");
                });

            modelBuilder.Entity("Webima.Models.Compra", b =>
                {
                    b.HasOne("Webima.Models.Bilhete", "IdBilNavigation")
                        .WithMany("Compras")
                        .HasForeignKey("IdBil")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Webima.Models.Cliente", "IdClienteNavigation")
                        .WithMany("Compras")
                        .HasForeignKey("IdCliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IdBilNavigation");

                    b.Navigation("IdClienteNavigation");
                });

            modelBuilder.Entity("Webima.Models.Filme", b =>
                {
                    b.HasOne("Webima.Models.Categoria", "IdCatNavigation")
                        .WithMany("Filmes")
                        .HasForeignKey("IdCat")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Webima.Models.Funcionario", "IdFuncNavigation")
                        .WithMany("Filmes")
                        .HasForeignKey("IdFunc")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IdCatNavigation");

                    b.Navigation("IdFuncNavigation");
                });

            modelBuilder.Entity("Webima.Models.Funcionario", b =>
                {
                    b.HasOne("Webima.Models.Utilizador", "IdNavigation")
                        .WithOne("Funcionario")
                        .HasForeignKey("Webima.Models.Funcionario", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Webima.Models.Admin", "IdAdminNavigation")
                        .WithMany("Funcionarios")
                        .HasForeignKey("IdAdmin")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IdAdminNavigation");

                    b.Navigation("IdNavigation");
                });

            modelBuilder.Entity("Webima.Models.Admin", b =>
                {
                    b.Navigation("Funcionarios");

                    b.Navigation("InverseIdCrtNavigation");
                });

            modelBuilder.Entity("Webima.Models.Bilhete", b =>
                {
                    b.Navigation("Compras");
                });

            modelBuilder.Entity("Webima.Models.Categoria", b =>
                {
                    b.Navigation("CliCats");

                    b.Navigation("Filmes");
                });

            modelBuilder.Entity("Webima.Models.Cliente", b =>
                {
                    b.Navigation("Categorias");

                    b.Navigation("Compras");
                });

            modelBuilder.Entity("Webima.Models.Filme", b =>
                {
                    b.Navigation("Bilhetes");
                });

            modelBuilder.Entity("Webima.Models.Funcionario", b =>
                {
                    b.Navigation("Filmes");
                });

            modelBuilder.Entity("Webima.Models.Sala", b =>
                {
                    b.Navigation("Bilhetes");
                });

            modelBuilder.Entity("Webima.Models.Sessao", b =>
                {
                    b.Navigation("Bilhetes");
                });

            modelBuilder.Entity("Webima.Models.Utilizador", b =>
                {
                    b.Navigation("Admin");

                    b.Navigation("Cliente");

                    b.Navigation("Funcionario");
                });
#pragma warning restore 612, 618
        }
    }
}
