using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheWildNature.Persintence.Migrations
{
    /// <inheritdoc />
    public partial class edit200 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FoodOfCategoryId",
                table: "FoodCategories");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FoodOfCategoryId",
                table: "FoodCategories",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
