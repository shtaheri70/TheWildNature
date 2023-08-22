using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheWildNature.Persintence.Migrations
{
    /// <inheritdoc />
    public partial class addtablecategorykitchen : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FoodOfCategoryKitchen");

            migrationBuilder.DropTable(
                name: "FoodOfCategories");

            migrationBuilder.CreateTable(
                name: "FoodCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodOfCategoryId = table.Column<int>(type: "int", nullable: false),
                    FoodOfTypeCategoryTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsRemoved = table.Column<bool>(type: "bit", nullable: false),
                    RemoveDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FoodCategoryKitchens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodOfCategoryId = table.Column<int>(type: "int", nullable: false),
                    KitchenId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodCategoryKitchens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FoodCategoryKitchens_FoodCategories_FoodOfCategoryId",
                        column: x => x.FoodOfCategoryId,
                        principalTable: "FoodCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FoodCategoryKitchens_Kitchens_KitchenId",
                        column: x => x.KitchenId,
                        principalTable: "Kitchens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FoodCategoryKitchens_FoodOfCategoryId",
                table: "FoodCategoryKitchens",
                column: "FoodOfCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodCategoryKitchens_KitchenId",
                table: "FoodCategoryKitchens",
                column: "KitchenId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FoodCategoryKitchens");

            migrationBuilder.DropTable(
                name: "FoodCategories");

            migrationBuilder.CreateTable(
                name: "FoodOfCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FoodOfCategoryId = table.Column<int>(type: "int", nullable: false),
                    FoodOfTypeCategoryTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsRemoved = table.Column<bool>(type: "bit", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RemoveDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodOfCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FoodOfCategoryKitchen",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodOfCategoryId = table.Column<int>(type: "int", nullable: false),
                    KitchenId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodOfCategoryKitchen", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FoodOfCategoryKitchen_FoodOfCategories_FoodOfCategoryId",
                        column: x => x.FoodOfCategoryId,
                        principalTable: "FoodOfCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FoodOfCategoryKitchen_Kitchens_KitchenId",
                        column: x => x.KitchenId,
                        principalTable: "Kitchens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FoodOfCategoryKitchen_FoodOfCategoryId",
                table: "FoodOfCategoryKitchen",
                column: "FoodOfCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodOfCategoryKitchen_KitchenId",
                table: "FoodOfCategoryKitchen",
                column: "KitchenId");
        }
    }
}
