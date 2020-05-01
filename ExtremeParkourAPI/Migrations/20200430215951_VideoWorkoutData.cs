using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ExtremeParkourAPI.Migrations
{
    public partial class VideoWorkoutData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Difficulty",
                table: "VideoMetaData");

            migrationBuilder.AddColumn<string>(
                name: "Focus",
                table: "VideoMetaData",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Source",
                table: "VideoMetaData",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserLevel",
                table: "VideoMetaData",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VideoSource",
                table: "VideoMetaData",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "WorkoutMetaData",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Source = table.Column<string>(nullable: true),
                    VideoSource = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Difficulty = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkoutMetaData", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WorkoutMetaData");

            migrationBuilder.DropColumn(
                name: "Focus",
                table: "VideoMetaData");

            migrationBuilder.DropColumn(
                name: "Source",
                table: "VideoMetaData");

            migrationBuilder.DropColumn(
                name: "UserLevel",
                table: "VideoMetaData");

            migrationBuilder.DropColumn(
                name: "VideoSource",
                table: "VideoMetaData");

            migrationBuilder.AddColumn<string>(
                name: "Difficulty",
                table: "VideoMetaData",
                type: "text",
                nullable: true);
        }
    }
}
