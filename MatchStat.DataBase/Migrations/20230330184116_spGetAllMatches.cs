using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MatchStat.DataModel.Migrations
{
    /// <inheritdoc />
    public partial class spGetAllMatches : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string procedure = @"create procedure spGetAllMatches
                                as
                                begin
	                                Select * From Match
                                end";
            migrationBuilder.Sql(procedure);

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            string procedure = @"Drop procedure spGetAllMatches
                                as
                                begin
	                                Select * From Match
                                end";
            migrationBuilder.Sql(procedure);
        }
    }
}
