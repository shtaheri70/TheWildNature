using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheWildNature.Persintence.Migrations
{
    /// <inheritdoc />
    public partial class edircategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LicenseFileName",
                table: "Kitchens");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Kitchens");

            migrationBuilder.AddColumn<int>(
                name: "FoodOfCategoryId",
                table: "FoodOfCategories",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FoodOfCategoryId",
                table: "FoodOfCategories");

            migrationBuilder.AddColumn<string>(
                name: "LicenseFileName",
                table: "Kitchens",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Kitchens",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
