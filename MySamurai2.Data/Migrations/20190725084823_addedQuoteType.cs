using Microsoft.EntityFrameworkCore.Migrations;

namespace MySamurai2.Data.Migrations
{
    public partial class addedQuoteType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SkillLevel",
                table: "Samurais",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "QuoteType",
                table: "Quote",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SkillLevel",
                table: "Samurais");

            migrationBuilder.DropColumn(
                name: "QuoteType",
                table: "Quote");
        }
    }
}
