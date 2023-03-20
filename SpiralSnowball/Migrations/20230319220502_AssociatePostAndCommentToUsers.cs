using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SpiralSnowball.Migrations
{
    /// <inheritdoc />
    public partial class AssociatePostAndCommentToUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserID",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserID",
                table: "PopularPosts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserID",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "PopularPosts");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Comments");
        }
    }
}
