using Microsoft.EntityFrameworkCore.Migrations;

namespace MySamurai2.Data.Migrations
{
    public partial class addedSecretIdentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QuoteType",
                table: "Quote");

            migrationBuilder.RenameColumn(
                name: "isMale",
                table: "Samurais",
                newName: "IsMale");

            migrationBuilder.AddColumn<int>(
                name: "QuoteStyle",
                table: "Quote",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QuoteStyle",
                table: "Quote");

            migrationBuilder.RenameColumn(
                name: "IsMale",
                table: "Samurais",
                newName: "isMale");

            migrationBuilder.AddColumn<int>(
                name: "QuoteType",
                table: "Quote",
                nullable: false,
                defaultValue: 0);
        }
    }
}
