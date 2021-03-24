using Microsoft.EntityFrameworkCore.Migrations;

namespace HowManyCaloriesIn.Data.Migrations
{
    public partial class itemviewmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblNutrients_tblItem_ItemID",
                table: "tblNutrients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tblItem",
                table: "tblItem");

            migrationBuilder.RenameTable(
                name: "tblItem",
                newName: "Item");

            migrationBuilder.RenameColumn(
                name: "ItemID",
                table: "tblNutrients",
                newName: "ItemId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "tblNutrients",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_tblNutrients_ItemID",
                table: "tblNutrients",
                newName: "IX_tblNutrients_ItemId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Item",
                newName: "Id");

            migrationBuilder.AlterColumn<double>(
                name: "Sugars",
                table: "tblNutrients",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<double>(
                name: "SaturatedFat",
                table: "tblNutrients",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<double>(
                name: "Salt",
                table: "tblNutrients",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<double>(
                name: "Fat",
                table: "tblNutrients",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Item",
                table: "Item",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tblNutrients_Item_ItemId",
                table: "tblNutrients",
                column: "ItemId",
                principalTable: "Item",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblNutrients_Item_ItemId",
                table: "tblNutrients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Item",
                table: "Item");

            migrationBuilder.RenameTable(
                name: "Item",
                newName: "tblItem");

            migrationBuilder.RenameColumn(
                name: "ItemId",
                table: "tblNutrients",
                newName: "ItemID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "tblNutrients",
                newName: "ID");

            migrationBuilder.RenameIndex(
                name: "IX_tblNutrients_ItemId",
                table: "tblNutrients",
                newName: "IX_tblNutrients_ItemID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "tblItem",
                newName: "ID");

            migrationBuilder.AlterColumn<int>(
                name: "Sugars",
                table: "tblNutrients",
                type: "int",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<int>(
                name: "SaturatedFat",
                table: "tblNutrients",
                type: "int",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<int>(
                name: "Salt",
                table: "tblNutrients",
                type: "int",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<int>(
                name: "Fat",
                table: "tblNutrients",
                type: "int",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 128);

            migrationBuilder.AddPrimaryKey(
                name: "PK_tblItem",
                table: "tblItem",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_tblNutrients_tblItem_ItemID",
                table: "tblNutrients",
                column: "ItemID",
                principalTable: "tblItem",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
