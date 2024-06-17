using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeCRUD.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedSoftDelete : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOnUtc",
                table: "Telefono",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Telefono",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOnUtc",
                table: "Empleados",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Empleados",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOnUtc",
                table: "Direcciones",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Direcciones",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_IsDeleted",
                table: "Empleados",
                column: "IsDeleted",
                filter: "IsDeleted = 0");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Empleados_IsDeleted",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "DeletedOnUtc",
                table: "Telefono");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Telefono");

            migrationBuilder.DropColumn(
                name: "DeletedOnUtc",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "DeletedOnUtc",
                table: "Direcciones");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Direcciones");
        }
    }
}
