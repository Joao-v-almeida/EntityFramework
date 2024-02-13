using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class Ajustes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ENDERECOS",
                columns: table => new
                {
                    ENDID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ENDRUA = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ENDNUMERO = table.Column<int>(type: "int", nullable: false),
                    ENDCOMPLEMENTO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ENDBAIRRO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ENDCIDADE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ENDESTADO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ENDPAIS = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ENDCEP = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ENDERECOS", x => x.ENDID);
                });

            migrationBuilder.CreateTable(
                name: "PRODUTOS",
                columns: table => new
                {
                    PROID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PRONOME = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    PROVALOR = table.Column<double>(type: "float", nullable: false),
                    PROURLIMAGEM = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PRODESCRICAO = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRODUTOS", x => x.PROID);
                });

            migrationBuilder.CreateTable(
                name: "CLIENTES",
                columns: table => new
                {
                    CLIID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CLINOME = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    CLIENDERECO = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CLIENTES", x => x.CLIID);
                    table.ForeignKey(
                        name: "FK_CLIENTES_ENDERECOS_CLIENDERECO",
                        column: x => x.CLIENDERECO,
                        principalTable: "ENDERECOS",
                        principalColumn: "ENDID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PEDIDOS",
                columns: table => new
                {
                    PEDID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PEDDATA = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PEDVALORTOTAL = table.Column<double>(type: "float", nullable: false),
                    PEDCLIID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PEDIDOS", x => x.PEDID);
                    table.ForeignKey(
                        name: "FK_PEDIDOS_CLIENTES_PEDCLIID",
                        column: x => x.PEDCLIID,
                        principalTable: "CLIENTES",
                        principalColumn: "CLIID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PEDIDOPRODUTOS",
                columns: table => new
                {
                    PEDPRODID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PEDPROQUANTIDADE = table.Column<int>(type: "int", nullable: false),
                    PEDPRODPEDIDOID = table.Column<int>(type: "int", nullable: false),
                    PEDPRODPRODUTOID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PEDIDOPRODUTOS", x => x.PEDPRODID);
                    table.ForeignKey(
                        name: "FK_PEDIDOPRODUTOS_PEDIDOS_PEDPRODPEDIDOID",
                        column: x => x.PEDPRODPEDIDOID,
                        principalTable: "PEDIDOS",
                        principalColumn: "PEDID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PEDIDOPRODUTOS_PRODUTOS_PEDPRODPRODUTOID",
                        column: x => x.PEDPRODPRODUTOID,
                        principalTable: "PRODUTOS",
                        principalColumn: "PROID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CLIENTES_CLIENDERECO",
                table: "CLIENTES",
                column: "CLIENDERECO",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PEDIDOPRODUTOS_PEDPRODPEDIDOID",
                table: "PEDIDOPRODUTOS",
                column: "PEDPRODPEDIDOID");

            migrationBuilder.CreateIndex(
                name: "IX_PEDIDOPRODUTOS_PEDPRODPRODUTOID",
                table: "PEDIDOPRODUTOS",
                column: "PEDPRODPRODUTOID");

            migrationBuilder.CreateIndex(
                name: "IX_PEDIDOS_PEDCLIID",
                table: "PEDIDOS",
                column: "PEDCLIID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PEDIDOPRODUTOS");

            migrationBuilder.DropTable(
                name: "PEDIDOS");

            migrationBuilder.DropTable(
                name: "PRODUTOS");

            migrationBuilder.DropTable(
                name: "CLIENTES");

            migrationBuilder.DropTable(
                name: "ENDERECOS");
        }
    }
}
