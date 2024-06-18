using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeCRUD.Data.Migrations
{
    /// <inheritdoc />
    public partial class FixTelefono : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Telefono_Empleados_EmpleadoId",
                table: "Telefono");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Telefono",
                table: "Telefono");

            migrationBuilder.DropIndex(
                name: "IX_Telefono_EmpleadoId",
                table: "Telefono");

            migrationBuilder.DropColumn(
                name: "EmpleadoId",
                table: "Telefono");

            migrationBuilder.RenameTable(
                name: "Telefono",
                newName: "Telefonos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Telefonos",
                table: "Telefonos",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Telefonos_IdEmpleado",
                table: "Telefonos",
                column: "IdEmpleado");

            migrationBuilder.AddForeignKey(
                name: "FK_Telefonos_Empleados_IdEmpleado",
                table: "Telefonos",
                column: "IdEmpleado",
                principalTable: "Empleados",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Telefonos_Empleados_IdEmpleado",
                table: "Telefonos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Telefonos",
                table: "Telefonos");

            migrationBuilder.DropIndex(
                name: "IX_Telefonos_IdEmpleado",
                table: "Telefonos");

            migrationBuilder.RenameTable(
                name: "Telefonos",
                newName: "Telefono");

            migrationBuilder.AddColumn<int>(
                name: "EmpleadoId",
                table: "Telefono",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Telefono",
                table: "Telefono",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Telefono_EmpleadoId",
                table: "Telefono",
                column: "EmpleadoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Telefono_Empleados_EmpleadoId",
                table: "Telefono",
                column: "EmpleadoId",
                principalTable: "Empleados",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
