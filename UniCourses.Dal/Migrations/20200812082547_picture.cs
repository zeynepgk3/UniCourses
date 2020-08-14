using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UniCourses.Dal.Migrations
{
    public partial class picture : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Image_Member_MemberID",
                table: "Image");

            migrationBuilder.DropIndex(
                name: "IX_Image_MemberID",
                table: "Image");

            migrationBuilder.DropColumn(
                name: "MemberID",
                table: "Image");

            migrationBuilder.AddColumn<int>(
                name: "PictureID",
                table: "Member",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ImageID",
                table: "Course",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Picture",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageTitle = table.Column<string>(nullable: true),
                    ImageData = table.Column<byte[]>(nullable: true),
                    MemberID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Picture", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Picture_Member_MemberID",
                        column: x => x.MemberID,
                        principalTable: "Member",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Picture_MemberID",
                table: "Picture",
                column: "MemberID",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Picture");

            migrationBuilder.DropColumn(
                name: "PictureID",
                table: "Member");

            migrationBuilder.DropColumn(
                name: "ImageID",
                table: "Course");

            migrationBuilder.AddColumn<int>(
                name: "MemberID",
                table: "Image",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Image_MemberID",
                table: "Image",
                column: "MemberID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Image_Member_MemberID",
                table: "Image",
                column: "MemberID",
                principalTable: "Member",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
