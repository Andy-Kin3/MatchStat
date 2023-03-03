using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MatchStat.DataModel.Migrations
{
    /// <inheritdoc />
    public partial class keysforttteams : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "TeamTournament",
                newName: "TeamTournaments");

            migrationBuilder.RenameIndex(
                name: "IX_TeamTournament_TournamentID",
                table: "TeamTournaments",
                newName: "IX_TeamTournaments_TournamentID");

            migrationBuilder.RenameIndex(
                name: "IX_TeamTournament_TeamID",
                table: "TeamTournaments",
                newName: "IX_TeamTournaments_TeamID");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "TeamTournaments",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TeamTournaments",
                table: "TeamTournaments",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TeamTournaments",
                table: "TeamTournaments");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "TeamTournaments");

            migrationBuilder.RenameTable(
                name: "TeamTournaments",
                newName: "TeamTournament");

            migrationBuilder.RenameIndex(
                name: "IX_TeamTournaments_TournamentID",
                table: "TeamTournament",
                newName: "IX_TeamTournament_TournamentID");

            migrationBuilder.RenameIndex(
                name: "IX_TeamTournaments_TeamID",
                table: "TeamTournament",
                newName: "IX_TeamTournament_TeamID");
        }
    }
}
