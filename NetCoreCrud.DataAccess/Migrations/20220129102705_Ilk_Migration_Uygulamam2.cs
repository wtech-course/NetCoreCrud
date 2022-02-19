using Microsoft.EntityFrameworkCore.Migrations;

namespace NetCoreCrud.DataAccess.Migrations
{
    public partial class Ilk_Migration_Uygulamam2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Company_Name",
                table: "Companies",
                newName: "Company_Test");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Company_Test",
                table: "Companies",
                newName: "Company_Name");
        }
    }
}
