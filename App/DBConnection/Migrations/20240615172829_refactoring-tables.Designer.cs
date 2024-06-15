﻿// <auto-generated />
using DBConnection.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DBConnection.Migrations
{
    [DbContext(typeof(TabloidContext))]
    [Migration("20240615172829_refactoring-tables")]
    partial class refactoringtables
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("viatabloid")
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Shared.Models.Department", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("text");

                    b.Property<string>("description")
                        .HasColumnType("text");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("department", "viatabloid");
                });

            modelBuilder.Entity("Shared.Models.DepartmentStory", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("text");

                    b.Property<string>("departmentId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("storyId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.HasIndex("departmentId");

                    b.HasIndex("storyId");

                    b.ToTable("departmentStory", "viatabloid");
                });

            modelBuilder.Entity("Shared.Models.Story", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("text");

                    b.Property<string>("body")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("story", "viatabloid");
                });

            modelBuilder.Entity("Shared.Models.DepartmentStory", b =>
                {
                    b.HasOne("Shared.Models.Department", "department")
                        .WithMany()
                        .HasForeignKey("departmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Shared.Models.Story", "story")
                        .WithMany()
                        .HasForeignKey("storyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("department");

                    b.Navigation("story");
                });
#pragma warning restore 612, 618
        }
    }
}