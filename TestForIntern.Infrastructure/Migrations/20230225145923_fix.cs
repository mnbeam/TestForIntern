using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestForIntern.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class fix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Author",
                table: "Offers");

            migrationBuilder.DropColumn(
                name: "Binding",
                table: "Offers");

            migrationBuilder.DropColumn(
                name: "Downloadable",
                table: "Offers");

            migrationBuilder.DropColumn(
                name: "Isbn",
                table: "Offers");

            migrationBuilder.DropColumn(
                name: "Language",
                table: "Offers");

            migrationBuilder.DropColumn(
                name: "LocalDeliveryCost",
                table: "Offers");

            migrationBuilder.DropColumn(
                name: "PageExtent",
                table: "Offers");

            migrationBuilder.DropColumn(
                name: "Part",
                table: "Offers");

            migrationBuilder.DropColumn(
                name: "Volume",
                table: "Offers");

            migrationBuilder.RenameColumn(
                name: "Series",
                table: "Offers",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "Publisher",
                table: "Offers",
                newName: "Media");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Offers",
                newName: "Artist");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Offers",
                newName: "Series");

            migrationBuilder.RenameColumn(
                name: "Media",
                table: "Offers",
                newName: "Publisher");

            migrationBuilder.RenameColumn(
                name: "Artist",
                table: "Offers",
                newName: "Name");

            migrationBuilder.AddColumn<string>(
                name: "Author",
                table: "Offers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Binding",
                table: "Offers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Downloadable",
                table: "Offers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Isbn",
                table: "Offers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Language",
                table: "Offers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "LocalDeliveryCost",
                table: "Offers",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "PageExtent",
                table: "Offers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Part",
                table: "Offers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Volume",
                table: "Offers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
