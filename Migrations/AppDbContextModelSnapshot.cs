﻿// <auto-generated />
using System;
using ContactApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ContactApi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.0");

            modelBuilder.Entity("ContactApi.Models.Contact", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Gender")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SSN")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Suffix")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Contacts");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f38d30c1-612b-41e0-8930-add4cb5769f1"),
                            DOB = new DateTime(2021, 10, 14, 16, 57, 6, 797, DateTimeKind.Local).AddTicks(6375),
                            Email = "Emanuel34@yahoo.com",
                            FirstName = "Emanuel",
                            Gender = 1,
                            LastName = "Stark",
                            MiddleName = "Cora",
                            Phone = "(308)-987-1434",
                            SSN = "815-87-2480",
                            Suffix = "Jr.",
                            Title = "Mrs."
                        },
                        new
                        {
                            Id = new Guid("8e7d6339-8576-44b1-ad5b-4110833eacf3"),
                            DOB = new DateTime(2010, 5, 15, 21, 13, 16, 761, DateTimeKind.Local).AddTicks(7513),
                            Email = "Guillermo79@yahoo.com",
                            FirstName = "Guillermo",
                            Gender = 0,
                            LastName = "Daniel",
                            MiddleName = "Deon",
                            Phone = "(236)-798-0142",
                            SSN = "363-13-8085",
                            Suffix = "PhD",
                            Title = "Ms."
                        },
                        new
                        {
                            Id = new Guid("c40d8099-ca13-48ae-88e0-fb55d060eac2"),
                            DOB = new DateTime(2005, 12, 12, 8, 6, 53, 344, DateTimeKind.Local).AddTicks(44),
                            Email = "Missouri.Murray57@gmail.com",
                            FirstName = "Missouri",
                            Gender = 0,
                            LastName = "Murray",
                            MiddleName = "Darrion",
                            Phone = "(684)-199-2973",
                            SSN = "532-93-2664",
                            Suffix = "Jr.",
                            Title = "Ms."
                        },
                        new
                        {
                            Id = new Guid("436333aa-a843-4251-9830-cb67e5f8ffd2"),
                            DOB = new DateTime(2019, 3, 26, 0, 53, 56, 262, DateTimeKind.Local).AddTicks(9081),
                            Email = "Janelle84@hotmail.com",
                            FirstName = "Janelle",
                            Gender = 0,
                            LastName = "Daniel",
                            MiddleName = "Estella",
                            Phone = "(888)-451-7251",
                            SSN = "541-47-6964",
                            Suffix = "Jr.",
                            Title = "Mr."
                        },
                        new
                        {
                            Id = new Guid("3c20e612-0770-448e-a494-ebe413a20b75"),
                            DOB = new DateTime(2004, 11, 8, 10, 53, 51, 974, DateTimeKind.Local).AddTicks(9089),
                            Email = "Flavio.Powlowski56@hotmail.com",
                            FirstName = "Flavio",
                            Gender = 1,
                            LastName = "Powlowski",
                            MiddleName = "Jules",
                            Phone = "(347)-604-2163",
                            SSN = "151-29-7112",
                            Suffix = "III",
                            Title = "Miss"
                        },
                        new
                        {
                            Id = new Guid("1c402861-3220-4873-8245-d580202a15a6"),
                            DOB = new DateTime(2008, 5, 16, 23, 40, 55, 644, DateTimeKind.Local).AddTicks(9897),
                            Email = "Mazie.Vandervort@hotmail.com",
                            FirstName = "Mazie",
                            Gender = 1,
                            LastName = "Vandervort",
                            MiddleName = "Brenden",
                            Phone = "(469)-923-1491",
                            SSN = "750-65-1751",
                            Suffix = "MD",
                            Title = "Miss"
                        },
                        new
                        {
                            Id = new Guid("eb9bec50-c64b-4e9d-b14f-d008a86d3ec8"),
                            DOB = new DateTime(2020, 10, 18, 19, 29, 33, 263, DateTimeKind.Local).AddTicks(4818),
                            Email = "Marie.Schmeler23@hotmail.com",
                            FirstName = "Marie",
                            Gender = 0,
                            LastName = "Schmeler",
                            MiddleName = "Delmer",
                            Phone = "(605)-333-4009",
                            SSN = "487-88-8501",
                            Suffix = "Sr.",
                            Title = "Mrs."
                        },
                        new
                        {
                            Id = new Guid("bbbc5b46-f2bc-4815-950c-cc6d9311c8a1"),
                            DOB = new DateTime(2005, 9, 2, 7, 49, 52, 838, DateTimeKind.Local).AddTicks(3885),
                            Email = "Elenor.Lang53@yahoo.com",
                            FirstName = "Elenor",
                            Gender = 1,
                            LastName = "Lang",
                            MiddleName = "Maggie",
                            Phone = "(666)-139-3728",
                            SSN = "097-44-3097",
                            Suffix = "DVM",
                            Title = "Mrs."
                        },
                        new
                        {
                            Id = new Guid("2c6c0d37-9bea-4f22-a30d-b9f71ba608b8"),
                            DOB = new DateTime(2007, 1, 19, 20, 23, 0, 349, DateTimeKind.Local).AddTicks(1207),
                            Email = "Aiden_McGlynn39@yahoo.com",
                            FirstName = "Aiden",
                            Gender = 1,
                            LastName = "McGlynn",
                            MiddleName = "Jesus",
                            Phone = "(481)-643-8015",
                            SSN = "174-77-4770",
                            Suffix = "DVM",
                            Title = "Mr."
                        },
                        new
                        {
                            Id = new Guid("7d1589ce-8ca5-4af9-b5b2-178b7b361b5e"),
                            DOB = new DateTime(2011, 12, 10, 14, 9, 8, 318, DateTimeKind.Local).AddTicks(2533),
                            Email = "Everette31@gmail.com",
                            FirstName = "Everette",
                            Gender = 0,
                            LastName = "Jacobson",
                            MiddleName = "Eloy",
                            Phone = "(788)-855-1972",
                            SSN = "712-51-2795",
                            Suffix = "DVM",
                            Title = "Dr."
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
