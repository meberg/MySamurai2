using Microsoft.EntityFrameworkCore.Migrations;

namespace MySamurai2.Data.Migrations
{
    public partial class addedIsMaleBool : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isMale",
                table: "Samurais",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isMale",
                table: "Samurais");
        }
    }
}
