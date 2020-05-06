using Microsoft.EntityFrameworkCore.Migrations;

namespace CovidCol.Migrations
{
    public partial class UpdateRelationships : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_CiudadId",
                table: "Usuarios",
                column: "CiudadId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_TipoDocumentoId",
                table: "Usuarios",
                column: "TipoDocumentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Ciudades_DepartamentoId",
                table: "Ciudades",
                column: "DepartamentoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ciudades_Departamentos_DepartamentoId",
                table: "Ciudades",
                column: "DepartamentoId",
                principalTable: "Departamentos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Ciudades_CiudadId",
                table: "Usuarios",
                column: "CiudadId",
                principalTable: "Ciudades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_TiposDocumento_TipoDocumentoId",
                table: "Usuarios",
                column: "TipoDocumentoId",
                principalTable: "TiposDocumento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ciudades_Departamentos_DepartamentoId",
                table: "Ciudades");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Ciudades_CiudadId",
                table: "Usuarios");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_TiposDocumento_TipoDocumentoId",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_CiudadId",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_TipoDocumentoId",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Ciudades_DepartamentoId",
                table: "Ciudades");
        }
    }
}
