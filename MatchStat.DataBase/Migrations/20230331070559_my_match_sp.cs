using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MatchStat.DataModel.Migrations
{
    /// <inheritdoc />
    public partial class my_match_sp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"IF EXISTS (SELECT * FROM SYS.procedures WHERE NAME = 'spGetAllMAtches')
	                                drop PROCEDURE spGetAllMatches
                                GO
                                create procedure spGetAllMatches
                                as
                                begin
	                                Select * From Match
                                end");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropSequence(@"IF EXISTS (SELECT * FROM SYS.procedures WHERE NAME = 'spGetAllMAtches')
	                            drop PROCEDURE spGetAllMatches
                            GO
                            create procedure spGetAllMatches
                            as
                            begin
	                            Select * From Match
                            end");
        }
    }
}
