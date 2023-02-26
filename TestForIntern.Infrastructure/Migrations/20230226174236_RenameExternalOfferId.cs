using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestForIntern.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RenameExternalOfferId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OfferId",
                table: "Offers",
                newName: "ExternalOfferId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ExternalOfferId",
                table: "Offers",
                newName: "OfferId");
        }
    }
}
