using Microsoft.EntityFrameworkCore.Migrations;

namespace Music2.Migrations
{
    public partial class MusicDbContext4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Artistttt",
                table: "AudioTracks",
                newName: "ARtis");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ARtis",
                table: "AudioTracks",
                newName: "Artistttt");
        }
    }
}
