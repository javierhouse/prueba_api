using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace prueba_api.Migrations
{
    /// <inheritdoc />
    public partial class profesmod2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClassTest",
                table: "Profes",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClassTest",
                table: "Profes");
        }
    }
}
