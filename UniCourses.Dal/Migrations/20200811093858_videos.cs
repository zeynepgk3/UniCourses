using Microsoft.EntityFrameworkCore.Migrations;

namespace UniCourses.Dal.Migrations
{
    public partial class videos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CourseID",
                table: "Videos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CourseID",
                table: "Videos");
        }
    }
}
