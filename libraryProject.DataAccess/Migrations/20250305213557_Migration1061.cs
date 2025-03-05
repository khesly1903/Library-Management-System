using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace libraryProject.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Migration1061 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StudentCurrentLoanCount",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StudentTotolLoanCount",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StudentCurrentLoanCount",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "StudentTotolLoanCount",
                table: "Students");
        }
    }
}
