using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CovidCol.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ciudades",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NombreCiudad = table.Column<string>(nullable: true),
                    DepartamentoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ciudades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Departamentos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departamentos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TiposDocumento",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(nullable: true),
                    Abreviacion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposDocumento", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true),
                    Apellidos = table.Column<string>(nullable: true),
                    TipoDocumentoId = table.Column<int>(nullable: false),
                    NumeroDocumento = table.Column<long>(nullable: false),
                    EnEstudio = table.Column<bool>(nullable: false),
                    Direccion = table.Column<string>(nullable: true),
                    Telefono = table.Column<string>(nullable: true),
                    CiudadId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Ciudades",
                columns: new[] { "Id", "DepartamentoId", "NombreCiudad" },
                values: new object[,]
                {
                    { 1, 1, "Bogotá" },
                    { 2, 2, "Tunja" },
                    { 3, 3, "Barranquilla" },
                    { 4, 4, "Medellín" }
                });

            migrationBuilder.InsertData(
                table: "Departamentos",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { 1, "Cundinamarca" },
                    { 2, "Boyacá" },
                    { 3, "Atlantico" },
                    { 4, "Antioquia" }
                });

            migrationBuilder.InsertData(
                table: "TiposDocumento",
                columns: new[] { "Id", "Abreviacion", "Descripcion" },
                values: new object[,]
                {
                    { 1, "CC", "Cédula de ciudadanía" },
                    { 2, "CE", "Cédula de extranjería" },
                    { 3, "TI", "Tarjeta de Identidad" },
                    { 4, "RC", "Registro Civil" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ciudades");

            migrationBuilder.DropTable(
                name: "Departamentos");

            migrationBuilder.DropTable(
                name: "TiposDocumento");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
