using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Projeto.Chat.Repository.Migrations
{
    public partial class inicialSql : Migration
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
                    Id = table.Column<Guid>(nullable: false),
                    IdUsuarioEnviou = table.Column<Guid>(nullable: true),
                    IdUsuarioRecebeu = table.Column<Guid>(nullable: true),
                    Conteudo = table.Column<string>(nullable: true),
                    Data = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mensagens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mensagens_Usuarios_IdUsuarioEnviou",
                        column: x => x.IdUsuarioEnviou,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Mensagens_Usuarios_IdUsuarioRecebeu",
                        column: x => x.IdUsuarioRecebeu,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Mensagens_IdUsuarioEnviou",
                table: "Mensagens",
                column: "IdUsuarioEnviou");

            migrationBuilder.CreateIndex(
                name: "IX_Mensagens_IdUsuarioRecebeu",
                table: "Mensagens",
                column: "IdUsuarioRecebeu");
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
