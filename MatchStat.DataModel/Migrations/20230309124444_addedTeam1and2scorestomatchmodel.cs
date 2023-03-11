using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MatchStat.DataModel.Migrations
{
    /// <inheritdoc />
    public partial class addedTeam1and2scorestomatchmodel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TeamOneScore",
                table: "Match",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TeamTwoScore",
                table: "Match",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TeamOneScore",
                table: "Match");

            migrationBuilder.DropColumn(
                name: "TeamTwoScore",
                table: "Match");
        }
    }
}
