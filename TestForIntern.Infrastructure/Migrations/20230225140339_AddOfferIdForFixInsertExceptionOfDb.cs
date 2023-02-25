using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestForIntern.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddOfferIdForFixInsertExceptionOfDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OfferId",
                table: "Offers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OfferId",
                table: "Offers");
        }
    }
}
