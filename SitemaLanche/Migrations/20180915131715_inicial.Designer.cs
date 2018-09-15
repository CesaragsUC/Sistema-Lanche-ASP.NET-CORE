﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using SitemaLanche.Context;
using System;

namespace SitemaLanche.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20180915131715_inicial")]
    partial class inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SitemaLanche.Models.CarrinhoCompraItem", b =>
                {
                    b.Property<int>("CarrinhoCompraItemId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CarrinhoCompraId")
                        .HasMaxLength(200);

                    b.Property<int>("Quantidade");

                    b.Property<int?>("lancheId");

                    b.HasKey("CarrinhoCompraItemId");

                    b.HasIndex("lancheId");

                    b.ToTable("CarrinhoCompraItens");
                });

            modelBuilder.Entity("SitemaLanche.Models.Categoria", b =>
                {
                    b.Property<int>("CategoriaId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CategoriaNome")
                        .HasMaxLength(100);

                    b.Property<string>("Descricao")
                        .HasMaxLength(200);

                    b.HasKey("CategoriaId");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("SitemaLanche.Models.Lanche", b =>
                {
                    b.Property<int>("lancheId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CategoriaId");

                    b.Property<string>("DescricaoCurta")
                        .HasMaxLength(100);

                    b.Property<string>("DescricaoDetalhada")
                        .HasMaxLength(255);

                    b.Property<bool>("EmEstoque");

                    b.Property<string>("ImagemThumbnailUrl")
                        .HasMaxLength(200);

                    b.Property<string>("ImagemUrl")
                        .HasMaxLength(200);

                    b.Property<bool>("IsLanchePreferido");

                    b.Property<string>("Nome")
                        .HasMaxLength(100);

                    b.Property<decimal>("Preco");

                    b.HasKey("lancheId");

                    b.HasIndex("CategoriaId");

                    b.ToTable("Lanches");
                });

            modelBuilder.Entity("SitemaLanche.Models.CarrinhoCompraItem", b =>
                {
                    b.HasOne("SitemaLanche.Models.Lanche", "Lanche")
                        .WithMany()
                        .HasForeignKey("lancheId");
                });

            modelBuilder.Entity("SitemaLanche.Models.Lanche", b =>
                {
                    b.HasOne("SitemaLanche.Models.Categoria", "Categoria")
                        .WithMany("lanches")
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}