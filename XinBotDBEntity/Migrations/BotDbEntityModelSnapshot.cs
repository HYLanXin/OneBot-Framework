﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using XinBotDBEntity;

#nullable disable

namespace XinBotDBEntity.Migrations
{
    [DbContext(typeof(BotDbEntity))]
    partial class BotDbEntityModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("XinBotDBEntity.BotServer_FunList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("FunName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FunType")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("IntervalTime")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("BotServer_FunList");
                });

            modelBuilder.Entity("XinBotDBEntity.BotServer_GroupFunList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Funid")
                        .HasColumnType("int");

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<bool>("IsOpen")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("BotServer_GroupFunLists");
                });

            modelBuilder.Entity("XinBotDBEntity.BotServer_GroupInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<long>("BotId")
                        .HasMaxLength(20)
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<long>("Creater")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<long>("GroupId")
                        .HasMaxLength(20)
                        .HasColumnType("bigint");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedTime")
                        .HasColumnType("datetime2");

                    b.Property<long>("Modifier")
                        .HasColumnType("bigint");

                    b.Property<string>("ServerName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("BotServer_GroupInfo");
                });

            modelBuilder.Entity("XinBotDBEntity.BotServer_GroupFunList", b =>
                {
                    b.HasOne("XinBotDBEntity.BotServer_FunList", "BotServer_Fun")
                        .WithMany("GroupFunLists")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("XinBotDBEntity.BotServer_GroupInfo", "GroupInfo")
                        .WithMany("GroupFunList")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BotServer_Fun");

                    b.Navigation("GroupInfo");
                });

            modelBuilder.Entity("XinBotDBEntity.BotServer_FunList", b =>
                {
                    b.Navigation("GroupFunLists");
                });

            modelBuilder.Entity("XinBotDBEntity.BotServer_GroupInfo", b =>
                {
                    b.Navigation("GroupFunList");
                });
#pragma warning restore 612, 618
        }
    }
}
