using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CementSalesAPI_Data.Migrations
{
    /// <inheritdoc />
    public partial class updateOrderTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PricePerTon",
                table: "Orders",
                newName: "PricePerTonResistant");

            migrationBuilder.RenameColumn(
                name: "Amount",
                table: "Orders",
                newName: "AmountResistant");

            migrationBuilder.AddColumn<int>(
                name: "AmountNorm",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "PricePerTonNorm",
                table: "Orders",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AmountNorm",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "PricePerTonNorm",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "PricePerTonResistant",
                table: "Orders",
                newName: "PricePerTon");

            migrationBuilder.RenameColumn(
                name: "AmountResistant",
                table: "Orders",
                newName: "Amount");
        }
    }
}
