using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MatchStat.DataModel.Migrations
{
    /// <inheritdoc />
    public partial class teamTournaments_unset_identity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TeamTournaments",
                table: "TeamTournaments");

            migrationBuilder.Sql(@"DELETE FROM TEAMTOURNAMENTS");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "TeamTournaments");


            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "TeamTournaments",
                type: "int",
                nullable: false,
                defaultValue: 0);


            migrationBuilder.AddPrimaryKey(
                name: "PK_TeamTournaments",
                table: "TeamTournaments",
                column: "Id");

            //migrationBuilder.AlterColumn<int>(
            //    name: "Id",
            //    table: "TeamTournaments",
            //    type: "int",
            //    nullable: false,
            //    oldClrType: typeof(int),
            //    oldType: "int")
            //    .OldAnnotation("SqlServer:Identity", "1, 1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "TeamTournaments",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");
        }
    }
}
