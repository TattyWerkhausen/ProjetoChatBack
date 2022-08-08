using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Projeto.Chat.Repository.Migrations
{
    public partial class iniciandoMigra : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Loggins",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(maxLength: 15, nullable: true),
                    Cpf = table.Column<string>(maxLength: 15, nullable: true),
                    Senha = table.Column<string>(maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loggins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(maxLength: 15, nullable: true),
                    Cpf = table.Column<string>(maxLength: 15, nullable: true),
                    Senha = table.Column<string>(maxLength: 15, nullable: true),
                    Sobrenome = table.Column<string>(maxLength: 15, nullable: true),
                    Telefone = table.Column<string>(maxLength: 15, nullable: true),
                    Email = table.Column<string>(maxLength: 25, nullable: true),
                    DataNascimento = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mensagens",
                columns: table => new
                {
                    IdMensagem = table.Column<Guid>(nullable: false),
                    DeId = table.Column<Guid>(nullable: false),
                    ParaId = table.Column<Guid>(nullable: false),
                    Conteudo = table.Column<string>(nullable: true),
                    Data = table.Column<DateTime>(nullable: false),
                    UsuarioId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mensagens", x => x.IdMensagem);
                    table.ForeignKey(
                        name: "FK_Mensagens_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Mensagens_UsuarioId",
                table: "Mensagens",
                column: "UsuarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Loggins");

            migrationBuilder.DropTable(
                name: "Mensagens");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
