using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeCRUD.Data.Migrations
{
    /// <inheritdoc />
    public partial class Fix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_Direcciones_IdDireccion",
                table: "Empleados");

            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_GradoEstudio_IdGradoEstudio",
                table: "Empleados");

            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_TipoEmpleado_IdTipoEmpleado",
                table: "Empleados");

            migrationBuilder.DropIndex(
                name: "IX_Empleados_IdDireccion",
                table: "Empleados");

            migrationBuilder.AlterColumn<Guid>(
                name: "IdTipoEmpleado",
                table: "Empleados",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "IdGradoEstudio",
                table: "Empleados",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "IdDireccion",
                table: "Empleados",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_IdDireccion",
                table: "Empleados",
                column: "IdDireccion",
                unique: true,
                filter: "[IdDireccion] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Empleados_Direcciones_IdDireccion",
                table: "Empleados",
                column: "IdDireccion",
                principalTable: "Direcciones",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Empleados_GradoEstudio_IdGradoEstudio",
                table: "Empleados",
                column: "IdGradoEstudio",
                principalTable: "GradoEstudio",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Empleados_TipoEmpleado_IdTipoEmpleado",
                table: "Empleados",
                column: "IdTipoEmpleado",
                principalTable: "TipoEmpleado",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_Direcciones_IdDireccion",
                table: "Empleados");

            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_GradoEstudio_IdGradoEstudio",
                table: "Empleados");

            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_TipoEmpleado_IdTipoEmpleado",
                table: "Empleados");

            migrationBuilder.DropIndex(
                name: "IX_Empleados_IdDireccion",
                table: "Empleados");

            migrationBuilder.AlterColumn<Guid>(
                name: "IdTipoEmpleado",
                table: "Empleados",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "IdGradoEstudio",
                table: "Empleados",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "IdDireccion",
                table: "Empleados",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_IdDireccion",
                table: "Empleados",
                column: "IdDireccion",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Empleados_Direcciones_IdDireccion",
                table: "Empleados",
                column: "IdDireccion",
                principalTable: "Direcciones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Empleados_GradoEstudio_IdGradoEstudio",
                table: "Empleados",
                column: "IdGradoEstudio",
                principalTable: "GradoEstudio",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Empleados_TipoEmpleado_IdTipoEmpleado",
                table: "Empleados",
                column: "IdTipoEmpleado",
                principalTable: "TipoEmpleado",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
