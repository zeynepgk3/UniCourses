using Microsoft.EntityFrameworkCore.Migrations;

namespace UniCourses.Dal.Migrations
{
    public partial class urls : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PictureURL",
                table: "Member",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageURL",
                table: "Course",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PictureURL",
                table: "Member");

            migrationBuilder.DropColumn(
                name: "ImageURL",
                table: "Course");
        }
    }
}
