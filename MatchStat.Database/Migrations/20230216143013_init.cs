using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MatchStat.DataModel.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Field",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Field", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Team",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Team", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Tournament",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    StartDate = table.Column<DateTime>(type: "date", nullable: true),
                    EndDate = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tournament", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Player",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    DOB = table.Column<DateTime>(type: "date", nullable: false),
                    TeamID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Player", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Player_Team",
                        column: x => x.TeamID,
                        principalTable: "Team",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Match",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "date", nullable: false),
                    Team1ID = table.Column<int>(type: "int", nullable: false),
                    Team2ID = table.Column<int>(type: "int", nullable: false),
                    TournamentID = table.Column<int>(type: "int", nullable: true),
                    FieldID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Match", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Match_Field",
                        column: x => x.FieldID,
                        principalTable: "Field",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Match_Team",
                        column: x => x.Team1ID,
                        principalTable: "Team",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Match_Team1",
                        column: x => x.Team2ID,
                        principalTable: "Team",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Match_Tournament",
                        column: x => x.TournamentID,
                        principalTable: "Tournament",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "TeamTournament",
                columns: table => new
                {
                    TeamID = table.Column<int>(type: "int", nullable: false),
                    TournamentID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_TeamTournament_Team",
                        column: x => x.TeamID,
                        principalTable: "Team",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_TeamTournament_Tournament",
                        column: x => x.TournamentID,
                        principalTable: "Tournament",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Goal",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    PlayerID = table.Column<int>(type: "int", nullable: false),
                    MatchID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Goal", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Goal_Player",
                        column: x => x.PlayerID,
                        principalTable: "Player",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Goal_PlayerID",
                table: "Goal",
                column: "PlayerID");

            migrationBuilder.CreateIndex(
                name: "IX_Match_FieldID",
                table: "Match",
                column: "FieldID");

            migrationBuilder.CreateIndex(
                name: "IX_Match_Team1ID",
                table: "Match",
                column: "Team1ID");

            migrationBuilder.CreateIndex(
                name: "IX_Match_Team2ID",
                table: "Match",
                column: "Team2ID");

            migrationBuilder.CreateIndex(
                name: "IX_Match_TournamentID",
                table: "Match",
                column: "TournamentID");

            migrationBuilder.CreateIndex(
                name: "IX_Player_TeamID",
                table: "Player",
                column: "TeamID");

            migrationBuilder.CreateIndex(
                name: "IX_TeamTournament_TeamID",
                table: "TeamTournament",
                column: "TeamID");

            migrationBuilder.CreateIndex(
                name: "IX_TeamTournament_TournamentID",
                table: "TeamTournament",
                column: "TournamentID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Goal");

            migrationBuilder.DropTable(
                name: "Match");

            migrationBuilder.DropTable(
                name: "TeamTournament");

            migrationBuilder.DropTable(
                name: "Player");

            migrationBuilder.DropTable(
                name: "Field");

            migrationBuilder.DropTable(
                name: "Tournament");

            migrationBuilder.DropTable(
                name: "Team");
        }
    }
}
