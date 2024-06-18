using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeCRUD.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Estado",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estado", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GradoEstudio",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GradoEstudio", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoEmpleado",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoEmpleado", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Direcciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Calle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CP = table.Column<int>(type: "int", nullable: false),
                    IdEstado = table.Column<int>(type: "int", nullable: false),
                    IdEmpleado = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Direcciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Direcciones_Estado_IdEstado",
                        column: x => x.IdEstado,
                        principalTable: "Estado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Empleados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApellidoPaterno = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApellidoMaterno = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Edad = table.Column<int>(type: "int", nullable: false),
                    Genero = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    IdDireccion = table.Column<int>(type: "int", nullable: true),
                    IdGradoEstudio = table.Column<int>(type: "int", nullable: true),
                    IdTipoEmpleado = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleados", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Empleados_Direcciones_IdDireccion",
                        column: x => x.IdDireccion,
                        principalTable: "Direcciones",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Empleados_GradoEstudio_IdGradoEstudio",
                        column: x => x.IdGradoEstudio,
                        principalTable: "GradoEstudio",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Empleados_TipoEmpleado_IdTipoEmpleado",
                        column: x => x.IdTipoEmpleado,
                        principalTable: "TipoEmpleado",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Telefono",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdEmpleado = table.Column<int>(type: "int", nullable: false),
                    EmpleadoId = table.Column<int>(type: "int", nullable: false),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    Extension = table.Column<int>(type: "int", nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Telefono", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Telefono_Empleados_EmpleadoId",
                        column: x => x.EmpleadoId,
                        principalTable: "Empleados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Direcciones_IdEstado",
                table: "Direcciones",
                column: "IdEstado");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_IdDireccion",
                table: "Empleados",
                column: "IdDireccion",
                unique: true,
                filter: "[IdDireccion] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_IdGradoEstudio",
                table: "Empleados",
                column: "IdGradoEstudio");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_IdTipoEmpleado",
                table: "Empleados",
                column: "IdTipoEmpleado");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_IsDeleted",
                table: "Empleados",
                column: "IsDeleted",
                filter: "IsDeleted = 0");

            migrationBuilder.CreateIndex(
                name: "IX_Telefono_EmpleadoId",
                table: "Telefono",
                column: "EmpleadoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Telefono");

            migrationBuilder.DropTable(
                name: "Empleados");

            migrationBuilder.DropTable(
                name: "Direcciones");

            migrationBuilder.DropTable(
                name: "GradoEstudio");

            migrationBuilder.DropTable(
                name: "TipoEmpleado");

            migrationBuilder.DropTable(
                name: "Estado");
        }
    }
}
