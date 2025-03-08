using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieTickets.Migrations
{
    /// <inheritdoc />
    public partial class deleteStatusColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MovieStatus",
                table: "Movies");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MovieStatus",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
