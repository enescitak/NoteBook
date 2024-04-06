using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NoteBook.Migrations
{
    public partial class AddUserNoteRelation3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Users",
                newName: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id",
                table: "Users",
                newName: "UserId");
        }
    }
}
