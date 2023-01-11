using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Animix.Infrastructure.Migrations
{
    public partial class createTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "animacao",
                columns: table => new
                {
                    IdAnimation = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Image = table.Column<byte[]>(type: "BLOB", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_animacao", x => x.IdAnimation);
                });

            migrationBuilder.CreateTable(
                name: "usuario",
                columns: table => new
                {
                    IdUser = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    NickName = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Password = table.Column<string>(type: "TEXT", nullable: false),
                    Balance = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuario", x => x.IdUser);
                });

            migrationBuilder.CreateTable(
                name: "personagem",
                columns: table => new
                {
                    IdCharacter = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Image = table.Column<byte[]>(type: "BLOB", nullable: false),
                    FkAnimation = table.Column<int>(type: "INTEGER", nullable: false),
                    FkOwner = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_personagem", x => x.IdCharacter);
                    table.ForeignKey(
                        name: "FK_personagem_animacao_FkAnimation",
                        column: x => x.FkAnimation,
                        principalTable: "animacao",
                        principalColumn: "IdAnimation",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_personagem_usuario_FkOwner",
                        column: x => x.FkOwner,
                        principalTable: "usuario",
                        principalColumn: "IdUser");
                });

            migrationBuilder.CreateTable(
                name: "transacoesUsuario",
                columns: table => new
                {
                    IdUserTransaction = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Type = table.Column<int>(type: "INTEGER", nullable: false),
                    Value = table.Column<decimal>(type: "TEXT", nullable: false),
                    FkUser = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_transacoesUsuario", x => x.IdUserTransaction);
                    table.ForeignKey(
                        name: "FK_transacoesUsuario_usuario_FkUser",
                        column: x => x.FkUser,
                        principalTable: "usuario",
                        principalColumn: "IdUser",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "anuncios",
                columns: table => new
                {
                    IdMarketplace = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    FkCharacter = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_anuncios", x => x.IdMarketplace);
                    table.ForeignKey(
                        name: "FK_anuncios_personagem_FkCharacter",
                        column: x => x.FkCharacter,
                        principalTable: "personagem",
                        principalColumn: "IdCharacter",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "transacoesAnimacoes",
                columns: table => new
                {
                    IdCharacterTransaction = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    BuyerIdUser = table.Column<int>(type: "INTEGER", nullable: false),
                    SellerIdUser = table.Column<int>(type: "INTEGER", nullable: false),
                    FkCharacter = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_transacoesAnimacoes", x => x.IdCharacterTransaction);
                    table.ForeignKey(
                        name: "FK_transacoesAnimacoes_personagem_FkCharacter",
                        column: x => x.FkCharacter,
                        principalTable: "personagem",
                        principalColumn: "IdCharacter",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_transacoesAnimacoes_usuario_BuyerIdUser",
                        column: x => x.BuyerIdUser,
                        principalTable: "usuario",
                        principalColumn: "IdUser",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_transacoesAnimacoes_usuario_SellerIdUser",
                        column: x => x.SellerIdUser,
                        principalTable: "usuario",
                        principalColumn: "IdUser",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_anuncios_FkCharacter",
                table: "anuncios",
                column: "FkCharacter",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_personagem_FkAnimation",
                table: "personagem",
                column: "FkAnimation");

            migrationBuilder.CreateIndex(
                name: "IX_personagem_FkOwner",
                table: "personagem",
                column: "FkOwner");

            migrationBuilder.CreateIndex(
                name: "IX_transacoesAnimacoes_BuyerIdUser",
                table: "transacoesAnimacoes",
                column: "BuyerIdUser");

            migrationBuilder.CreateIndex(
                name: "IX_transacoesAnimacoes_FkCharacter",
                table: "transacoesAnimacoes",
                column: "FkCharacter");

            migrationBuilder.CreateIndex(
                name: "IX_transacoesAnimacoes_SellerIdUser",
                table: "transacoesAnimacoes",
                column: "SellerIdUser");

            migrationBuilder.CreateIndex(
                name: "IX_transacoesUsuario_FkUser",
                table: "transacoesUsuario",
                column: "FkUser");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "anuncios");

            migrationBuilder.DropTable(
                name: "transacoesAnimacoes");

            migrationBuilder.DropTable(
                name: "transacoesUsuario");

            migrationBuilder.DropTable(
                name: "personagem");

            migrationBuilder.DropTable(
                name: "animacao");

            migrationBuilder.DropTable(
                name: "usuario");
        }
    }
}
