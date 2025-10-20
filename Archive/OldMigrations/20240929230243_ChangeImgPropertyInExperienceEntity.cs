using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PortfolioAPI.Migrations
{
    /// <inheritdoc />
    public partial class ChangeImgPropertyInExperienceEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImagePath",
                table: "Experiences",
                newName: "ImgPath");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImgPath",
                table: "Experiences",
                newName: "ImagePath");
        }
    }
}
