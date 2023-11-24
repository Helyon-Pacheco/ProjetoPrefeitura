using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Prefeitura.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class PrefeituraDBV02 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Servicos_Cidadaos_CidadaoId",
                table: "Servicos");

            migrationBuilder.DropForeignKey(
                name: "FK_Servicos_Empresas_EmpresaId",
                table: "Servicos");

            migrationBuilder.DropForeignKey(
                name: "FK_Servicos_Propriedades_PropriedadeId",
                table: "Servicos");

            migrationBuilder.DropForeignKey(
                name: "FK_Servicos_Reclamacoes_ReclamacaoId",
                table: "Servicos");

            migrationBuilder.DropIndex(
                name: "IX_Servicos_CidadaoId",
                table: "Servicos");

            migrationBuilder.DropIndex(
                name: "IX_Servicos_EmpresaId",
                table: "Servicos");

            migrationBuilder.DropIndex(
                name: "IX_Servicos_PropriedadeId",
                table: "Servicos");

            migrationBuilder.DropIndex(
                name: "IX_Servicos_ReclamacaoId",
                table: "Servicos");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Servicos_CidadaoId",
                table: "Servicos",
                column: "CidadaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Servicos_EmpresaId",
                table: "Servicos",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_Servicos_PropriedadeId",
                table: "Servicos",
                column: "PropriedadeId");

            migrationBuilder.CreateIndex(
                name: "IX_Servicos_ReclamacaoId",
                table: "Servicos",
                column: "ReclamacaoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Servicos_Cidadaos_CidadaoId",
                table: "Servicos",
                column: "CidadaoId",
                principalTable: "Cidadaos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Servicos_Empresas_EmpresaId",
                table: "Servicos",
                column: "EmpresaId",
                principalTable: "Empresas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Servicos_Propriedades_PropriedadeId",
                table: "Servicos",
                column: "PropriedadeId",
                principalTable: "Propriedades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Servicos_Reclamacoes_ReclamacaoId",
                table: "Servicos",
                column: "ReclamacaoId",
                principalTable: "Reclamacoes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
