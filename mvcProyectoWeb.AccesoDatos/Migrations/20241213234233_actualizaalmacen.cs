using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mvcProyectoWeb.AccesoDatos.Migrations
{
    /// <inheritdoc />
    public partial class actualizaalmacen : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Orden",
                table: "Almacen",
                newName: "Numero");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Numero",
                table: "Almacen",
                newName: "Orden");
        }
    }
}
