using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Projeto.Chat.Repository.Migrations
{
    public partial class CorrigeMensagemMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mensagens_Usuarios_UsuarioId",
                table: "Mensagens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Mensagens",
                table: "Mensagens");

            migrationBuilder.DropIndex(
                name: "IX_Mensagens_UsuarioId",
                table: "Mensagens");

            migrationBuilder.DropColumn(
                name: "IdMensagem",
                table: "Mensagens");

            migrationBuilder.DropColumn(
                name: "DeId",
                table: "Mensagens");

            migrationBuilder.DropColumn(
                name: "ParaId",
                table: "Mensagens");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Mensagens");

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "Mensagens",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "UsuarioEnviouId",
                table: "Mensagens",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "UsuarioRecebeuId",
                table: "Mensagens",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Mensagens",
                table: "Mensagens",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Mensagens_UsuarioEnviouId",
                table: "Mensagens",
                column: "UsuarioEnviouId");

            migrationBuilder.CreateIndex(
                name: "IX_Mensagens_UsuarioRecebeuId",
                table: "Mensagens",
                column: "UsuarioRecebeuId");

            migrationBuilder.AddForeignKey(
                name: "FK_Mensagens_Usuarios_UsuarioEnviouId",
                table: "Mensagens",
                column: "UsuarioEnviouId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Mensagens_Usuarios_UsuarioRecebeuId",
                table: "Mensagens",
                column: "UsuarioRecebeuId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mensagens_Usuarios_UsuarioEnviouId",
                table: "Mensagens");

            migrationBuilder.DropForeignKey(
                name: "FK_Mensagens_Usuarios_UsuarioRecebeuId",
                table: "Mensagens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Mensagens",
                table: "Mensagens");

            migrationBuilder.DropIndex(
                name: "IX_Mensagens_UsuarioEnviouId",
                table: "Mensagens");

            migrationBuilder.DropIndex(
                name: "IX_Mensagens_UsuarioRecebeuId",
                table: "Mensagens");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Mensagens");

            migrationBuilder.DropColumn(
                name: "UsuarioEnviouId",
                table: "Mensagens");

            migrationBuilder.DropColumn(
                name: "UsuarioRecebeuId",
                table: "Mensagens");

            migrationBuilder.AddColumn<Guid>(
                name: "IdMensagem",
                table: "Mensagens",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "DeId",
                table: "Mensagens",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ParaId",
                table: "Mensagens",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "UsuarioId",
                table: "Mensagens",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Mensagens",
                table: "Mensagens",
                column: "IdMensagem");

            migrationBuilder.CreateIndex(
                name: "IX_Mensagens_UsuarioId",
                table: "Mensagens",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Mensagens_Usuarios_UsuarioId",
                table: "Mensagens",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
