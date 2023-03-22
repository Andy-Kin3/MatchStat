using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MatchStat.DataModel.Migrations
{
    /// <inheritdoc />
    public partial class numberofgaols : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NumberOfGoal",
                table: "Goal",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberOfGoal",
                table: "Goal");
        }
    }
}
