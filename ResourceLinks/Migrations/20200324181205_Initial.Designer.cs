﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ResourceLinks.Models;

namespace ResourceLinks.Migrations
{
    [DbContext(typeof(ResourceLinksContext))]
    [Migration("20200324181205_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ResourceLinks.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Title");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("ResourceLinks.Models.CategoryLink", b =>
                {
                    b.Property<int>("CategoryLinkId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CategoryId");

                    b.Property<int>("LinkId");

                    b.HasKey("CategoryLinkId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("LinkId");

                    b.ToTable("CategoryLink");
                });

            modelBuilder.Entity("ResourceLinks.Models.Link", b =>
                {
                    b.Property<int>("LinkId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("LinkUrl");

                    b.Property<string>("ResourseName");

                    b.HasKey("LinkId");

                    b.ToTable("Links");
                });

            modelBuilder.Entity("ResourceLinks.Models.LinkTag", b =>
                {
                    b.Property<int>("LinkTagId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("LinkId");

                    b.Property<int>("TagId");

                    b.HasKey("LinkTagId");

                    b.HasIndex("LinkId");

                    b.HasIndex("TagId");

                    b.ToTable("LinkTag");
                });

            modelBuilder.Entity("ResourceLinks.Models.Tag", b =>
                {
                    b.Property<int>("TagId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("TagId");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("ResourceLinks.Models.CategoryLink", b =>
                {
                    b.HasOne("ResourceLinks.Models.Category", "Category")
                        .WithMany("Links")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ResourceLinks.Models.Link", "Link")
                        .WithMany("Categories")
                        .HasForeignKey("LinkId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ResourceLinks.Models.LinkTag", b =>
                {
                    b.HasOne("ResourceLinks.Models.Link", "Link")
                        .WithMany("Tags")
                        .HasForeignKey("LinkId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ResourceLinks.Models.Tag", "Tag")
                        .WithMany("Links")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
