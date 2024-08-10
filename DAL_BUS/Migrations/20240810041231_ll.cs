using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL_BUS.Migrations
{
    public partial class ll : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_PayHistorys_BillID",
                table: "PayHistorys");

            migrationBuilder.AlterColumn<long>(
                name: "TotalMoney",
                table: "Bills",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.CreateIndex(
                name: "IX_PayHistorys_BillID",
                table: "PayHistorys",
                column: "BillID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_PayHistorys_BillID",
                table: "PayHistorys");

            migrationBuilder.AlterColumn<long>(
                name: "TotalMoney",
                table: "Bills",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PayHistorys_BillID",
                table: "PayHistorys",
                column: "BillID",
                unique: true);
        }
    }
}
