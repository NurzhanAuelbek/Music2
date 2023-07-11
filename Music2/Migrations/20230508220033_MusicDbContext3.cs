using Microsoft.EntityFrameworkCore.Migrations;

namespace Music2.Migrations
{
    public partial class MusicDbContext3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Artist",
                table: "AudioTracks",
                newName: "Artistttt");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Artistttt",
                table: "AudioTracks",
                newName: "Artist");
        }
    }
}
