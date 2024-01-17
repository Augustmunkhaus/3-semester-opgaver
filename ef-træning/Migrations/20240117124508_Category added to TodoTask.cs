using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ef_træning.Migrations
{
    public partial class CategoryaddedtoTodoTask : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Tasks",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "Tasks");
        }
    }
}
