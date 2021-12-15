using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContactApi.Migrations
{
    public partial class InitialModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    MiddleName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    DOB = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Gender = table.Column<int>(type: "INTEGER", nullable: false),
                    SSN = table.Column<string>(type: "TEXT", nullable: false),
                    Suffix = table.Column<string>(type: "TEXT", nullable: false),
                    Phone = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Gender", "LastName", "MiddleName", "Phone", "SSN", "Suffix", "Title" },
                values: new object[] { new Guid("1c402861-3220-4873-8245-d580202a15a6"), new DateTime(2008, 5, 16, 23, 40, 55, 644, DateTimeKind.Local).AddTicks(9897), "Mazie.Vandervort@hotmail.com", "Mazie", 1, "Vandervort", "Brenden", "(469)-923-1491", "750-65-1751", "MD", "Miss" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Gender", "LastName", "MiddleName", "Phone", "SSN", "Suffix", "Title" },
                values: new object[] { new Guid("2c6c0d37-9bea-4f22-a30d-b9f71ba608b8"), new DateTime(2007, 1, 19, 20, 23, 0, 349, DateTimeKind.Local).AddTicks(1207), "Aiden_McGlynn39@yahoo.com", "Aiden", 1, "McGlynn", "Jesus", "(481)-643-8015", "174-77-4770", "DVM", "Mr." });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Gender", "LastName", "MiddleName", "Phone", "SSN", "Suffix", "Title" },
                values: new object[] { new Guid("3c20e612-0770-448e-a494-ebe413a20b75"), new DateTime(2004, 11, 8, 10, 53, 51, 974, DateTimeKind.Local).AddTicks(9089), "Flavio.Powlowski56@hotmail.com", "Flavio", 1, "Powlowski", "Jules", "(347)-604-2163", "151-29-7112", "III", "Miss" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Gender", "LastName", "MiddleName", "Phone", "SSN", "Suffix", "Title" },
                values: new object[] { new Guid("436333aa-a843-4251-9830-cb67e5f8ffd2"), new DateTime(2019, 3, 26, 0, 53, 56, 262, DateTimeKind.Local).AddTicks(9081), "Janelle84@hotmail.com", "Janelle", 0, "Daniel", "Estella", "(888)-451-7251", "541-47-6964", "Jr.", "Mr." });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Gender", "LastName", "MiddleName", "Phone", "SSN", "Suffix", "Title" },
                values: new object[] { new Guid("7d1589ce-8ca5-4af9-b5b2-178b7b361b5e"), new DateTime(2011, 12, 10, 14, 9, 8, 318, DateTimeKind.Local).AddTicks(2533), "Everette31@gmail.com", "Everette", 0, "Jacobson", "Eloy", "(788)-855-1972", "712-51-2795", "DVM", "Dr." });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Gender", "LastName", "MiddleName", "Phone", "SSN", "Suffix", "Title" },
                values: new object[] { new Guid("8e7d6339-8576-44b1-ad5b-4110833eacf3"), new DateTime(2010, 5, 15, 21, 13, 16, 761, DateTimeKind.Local).AddTicks(7513), "Guillermo79@yahoo.com", "Guillermo", 0, "Daniel", "Deon", "(236)-798-0142", "363-13-8085", "PhD", "Ms." });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Gender", "LastName", "MiddleName", "Phone", "SSN", "Suffix", "Title" },
                values: new object[] { new Guid("bbbc5b46-f2bc-4815-950c-cc6d9311c8a1"), new DateTime(2005, 9, 2, 7, 49, 52, 838, DateTimeKind.Local).AddTicks(3885), "Elenor.Lang53@yahoo.com", "Elenor", 1, "Lang", "Maggie", "(666)-139-3728", "097-44-3097", "DVM", "Mrs." });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Gender", "LastName", "MiddleName", "Phone", "SSN", "Suffix", "Title" },
                values: new object[] { new Guid("c40d8099-ca13-48ae-88e0-fb55d060eac2"), new DateTime(2005, 12, 12, 8, 6, 53, 344, DateTimeKind.Local).AddTicks(44), "Missouri.Murray57@gmail.com", "Missouri", 0, "Murray", "Darrion", "(684)-199-2973", "532-93-2664", "Jr.", "Ms." });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Gender", "LastName", "MiddleName", "Phone", "SSN", "Suffix", "Title" },
                values: new object[] { new Guid("eb9bec50-c64b-4e9d-b14f-d008a86d3ec8"), new DateTime(2020, 10, 18, 19, 29, 33, 263, DateTimeKind.Local).AddTicks(4818), "Marie.Schmeler23@hotmail.com", "Marie", 0, "Schmeler", "Delmer", "(605)-333-4009", "487-88-8501", "Sr.", "Mrs." });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Gender", "LastName", "MiddleName", "Phone", "SSN", "Suffix", "Title" },
                values: new object[] { new Guid("f38d30c1-612b-41e0-8930-add4cb5769f1"), new DateTime(2021, 10, 14, 16, 57, 6, 797, DateTimeKind.Local).AddTicks(6375), "Emanuel34@yahoo.com", "Emanuel", 1, "Stark", "Cora", "(308)-987-1434", "815-87-2480", "Jr.", "Mrs." });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");
        }
    }
}
