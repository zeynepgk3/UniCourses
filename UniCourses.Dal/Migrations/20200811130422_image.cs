using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UniCourses.Dal.Migrations
{
    public partial class image : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LessonDescription",
                table: "Lesson",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Mail",
                table: "Educator",
                type: "Varchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "Varchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MemberID",
                table: "Course",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MemberName",
                table: "Comment",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Count",
                table: "Category",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "CourseMember",
                columns: table => new
                {
                    CourseId = table.Column<int>(nullable: false),
                    MemberId = table.Column<int>(nullable: false),
                    IsDone = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseMember", x => new { x.CourseId, x.MemberId });
                    table.ForeignKey(
                        name: "FK_CourseMember_Course_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Course",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_CourseMember_Member_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Member",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Image",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageTitle = table.Column<string>(nullable: true),
                    ImageData = table.Column<byte[]>(nullable: true),
                    MemberID = table.Column<int>(nullable: true),
                    CourseID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Image", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Image_Course_CourseID",
                        column: x => x.CourseID,
                        principalTable: "Course",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Image_Member_MemberID",
                        column: x => x.MemberID,
                        principalTable: "Member",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Course_MemberID",
                table: "Course",
                column: "MemberID");

            migrationBuilder.CreateIndex(
                name: "IX_CourseMember_MemberId",
                table: "CourseMember",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_Image_CourseID",
                table: "Image",
                column: "CourseID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Image_MemberID",
                table: "Image",
                column: "MemberID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Member_MemberID",
                table: "Course",
                column: "MemberID",
                principalTable: "Member",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_Member_MemberID",
                table: "Course");

            migrationBuilder.DropTable(
                name: "CourseMember");

            migrationBuilder.DropTable(
                name: "Image");

            migrationBuilder.DropIndex(
                name: "IX_Course_MemberID",
                table: "Course");

            migrationBuilder.DropColumn(
                name: "LessonDescription",
                table: "Lesson");

            migrationBuilder.DropColumn(
                name: "MemberID",
                table: "Course");

            migrationBuilder.DropColumn(
                name: "MemberName",
                table: "Comment");

            migrationBuilder.DropColumn(
                name: "Count",
                table: "Category");

            migrationBuilder.AlterColumn<string>(
                name: "Mail",
                table: "Educator",
                type: "Varchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "Varchar(50)",
                oldMaxLength: 50,
                oldNullable: true);
        }
    }
}
