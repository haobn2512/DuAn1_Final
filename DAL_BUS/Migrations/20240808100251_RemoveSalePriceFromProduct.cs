using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL_BUS.Migrations
{
    public partial class RemoveSalePriceFromProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SalePrice",
                table: "Products");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "SalePrice",
                table: "Products",
                type: "bigint",
                nullable: true);
        }
    }
}
