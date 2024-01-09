using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace modul5opgaver.Migrations
{
    /// <inheritdoc />
    public partial class user : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "Userid",
                table: "Tasks",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Userid = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Userid);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_Userid",
                table: "Tasks",
                column: "Userid");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_User_Userid",
                table: "Tasks",
                column: "Userid",
                principalTable: "User",
                principalColumn: "Userid",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_User_Userid",
                table: "Tasks");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_Userid",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "Userid",
                table: "Tasks");
        }
    }
}
