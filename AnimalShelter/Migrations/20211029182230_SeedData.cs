using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelter.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    AnimalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AnimalName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    AnimalType = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    AnimalAge = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.AnimalId);
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "AnimalAge", "AnimalName", "AnimalType" },
                values: new object[,]
                {
                    { 1, 7, "Robbie", "Dog" },
                    { 2, 4, "Debster", "Cat" },
                    { 3, 2, "Stibbons", "Cat" },
                    { 4, 3, "Doug", "Dog" },
                    { 5, 1, "Pumpkin", "Dog" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animals");
        }
    }
}
