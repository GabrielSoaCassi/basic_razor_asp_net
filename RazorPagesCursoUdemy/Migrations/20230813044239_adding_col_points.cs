using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RazorPagesCursoUdemy.Migrations
{
    /// <inheritdoc />
    public partial class adding_col_points : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Points",
                table: "Filme",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Points",
                table: "Filme");
        }
    }
}
