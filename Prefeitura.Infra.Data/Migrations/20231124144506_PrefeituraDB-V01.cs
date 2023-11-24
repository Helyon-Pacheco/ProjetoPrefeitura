using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Prefeitura.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class PrefeituraDBV01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cidadaos_Familias_FamiliaId",
                table: "Cidadaos");

            migrationBuilder.DropForeignKey(
                name: "FK_Servicos_Familias_FamiliaId",
                table: "Servicos");

            migrationBuilder.DropTable(
                name: "Familias");

            migrationBuilder.DropIndex(
                name: "IX_Servicos_FamiliaId",
                table: "Servicos");

            migrationBuilder.DropIndex(
                name: "IX_Cidadaos_FamiliaId",
                table: "Cidadaos");

            migrationBuilder.DropColumn(
                name: "FamiliaId",
                table: "Servicos");

            migrationBuilder.DropColumn(
                name: "FamiliaId",
                table: "Cidadaos");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "FamiliaId",
                table: "Servicos",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "FamiliaId",
                table: "Cidadaos",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Familias",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Familias", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Servicos_FamiliaId",
                table: "Servicos",
                column: "FamiliaId");

            migrationBuilder.CreateIndex(
                name: "IX_Cidadaos_FamiliaId",
                table: "Cidadaos",
                column: "FamiliaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cidadaos_Familias_FamiliaId",
                table: "Cidadaos",
                column: "FamiliaId",
                principalTable: "Familias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Servicos_Familias_FamiliaId",
                table: "Servicos",
                column: "FamiliaId",
                principalTable: "Familias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
