using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using mvcTest.Models;

namespace mvcTest.Migrations
{
    [DbContext(typeof(BookContext))]
    [Migration("20170713012009_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1");

            modelBuilder.Entity("mvcTest.Models.Book", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Author");

                    b.Property<decimal>("Price");

                    b.Property<string>("Title");

                    b.HasKey("ID");

                    b.ToTable("Book");
                });
        }
    }
}
