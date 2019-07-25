using Microsoft.EntityFrameworkCore.Migrations;

namespace MySamurai2.Data.Migrations
{
    public partial class AddedModelBuilder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_SecretIdentities_SamuraiId",
                table: "SecretIdentities");

            migrationBuilder.RenameColumn(
                name: "Brutal",
                table: "Battles",
                newName: "IsBrutal");

            migrationBuilder.CreateTable(
                name: "SamuraiBattle",
                columns: table => new
                {
                    BattleId = table.Column<int>(nullable: false),
                    SamuraiId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SamuraiBattle", x => new { x.BattleId, x.SamuraiId });
                    table.ForeignKey(
                        name: "FK_SamuraiBattle_Battles_BattleId",
                        column: x => x.BattleId,
                        principalTable: "Battles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SamuraiBattle_Samurais_SamuraiId",
                        column: x => x.SamuraiId,
                        principalTable: "Samurais",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SecretIdentities_SamuraiId",
                table: "SecretIdentities",
                column: "SamuraiId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SamuraiBattle_SamuraiId",
                table: "SamuraiBattle",
                column: "SamuraiId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SamuraiBattle");

            migrationBuilder.DropIndex(
                name: "IX_SecretIdentities_SamuraiId",
                table: "SecretIdentities");

            migrationBuilder.RenameColumn(
                name: "IsBrutal",
                table: "Battles",
                newName: "Brutal");

            migrationBuilder.CreateIndex(
                name: "IX_SecretIdentities_SamuraiId",
                table: "SecretIdentities",
                column: "SamuraiId");
        }
    }
}
