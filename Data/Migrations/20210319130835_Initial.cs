using Microsoft.EntityFrameworkCore.Migrations;

namespace HowManyCaloriesIn.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblItem",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemName = table.Column<string>(nullable: true),
                    ItemSize = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblItem", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "tblNutrients",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Calories = table.Column<int>(nullable: false),
                    Fat = table.Column<int>(nullable: false),
                    SaturatedFat = table.Column<int>(nullable: false),
                    Sugars = table.Column<int>(nullable: false),
                    Salt = table.Column<int>(nullable: false),
                    ItemID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblNutrients", x => x.ID);
                    table.ForeignKey(
                        name: "FK_tblNutrients_tblItem_ItemID",
                        column: x => x.ItemID,
                        principalTable: "tblItem",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblNutrients_ItemID",
                table: "tblNutrients",
                column: "ItemID",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblNutrients");

            migrationBuilder.DropTable(
                name: "tblItem");
        }
    }
}
