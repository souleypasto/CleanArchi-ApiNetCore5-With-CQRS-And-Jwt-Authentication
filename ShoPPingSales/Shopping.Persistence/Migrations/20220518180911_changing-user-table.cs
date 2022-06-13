using Microsoft.EntityFrameworkCore.Migrations;

namespace Shopping.Persistence.Migrations
{
    public partial class changingusertable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "Utilisateurs");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Utilisateurs",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
