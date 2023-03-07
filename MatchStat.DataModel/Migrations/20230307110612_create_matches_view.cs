using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MatchStat.DataModel.Migrations
{
    /// <inheritdoc />
    public partial class create_matches_view : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"IF EXISTS (SELECT * FROM SYS.VIEWS WHERE NAME = 'MatchesView')
	drop VIEW MATCHESVIEW
GO


CREATE VIEW MatchesView
as
SELECT M.*, T1.Name AS Team1Name, T2.Name AS Team2Name, T.Name AS TournamentName, F.Name AS FieldName FROM Match M
LEFT JOIN Team T1 ON M.Team1ID = T1.ID
LEFT JOIN Team T2 ON M.Team2ID = T2.ID
LEFT JOIN Tournament T ON M.TournamentID = T.ID
LEFT JOIN Field F ON M.FieldID = F.ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
