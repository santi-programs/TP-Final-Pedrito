using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modelo.Migrations
{
    /// <inheritdoc />
    public partial class AgregarClienteIDaVenta : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Venta_Cliente_ClienteRelacionClienteID",
                table: "Venta");

            migrationBuilder.RenameColumn(
                name: "ClienteRelacionClienteID",
                table: "Venta",
                newName: "ClienteID");

            migrationBuilder.RenameIndex(
                name: "IX_Venta_ClienteRelacionClienteID",
                table: "Venta",
                newName: "IX_Venta_ClienteID");

            migrationBuilder.AddForeignKey(
                name: "FK_Venta_Cliente_ClienteID",
                table: "Venta",
                column: "ClienteID",
                principalTable: "Cliente",
                principalColumn: "ClienteID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Venta_Cliente_ClienteID",
                table: "Venta");

            migrationBuilder.RenameColumn(
                name: "ClienteID",
                table: "Venta",
                newName: "ClienteRelacionClienteID");

            migrationBuilder.RenameIndex(
                name: "IX_Venta_ClienteID",
                table: "Venta",
                newName: "IX_Venta_ClienteRelacionClienteID");

            migrationBuilder.AddForeignKey(
                name: "FK_Venta_Cliente_ClienteRelacionClienteID",
                table: "Venta",
                column: "ClienteRelacionClienteID",
                principalTable: "Cliente",
                principalColumn: "ClienteID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
