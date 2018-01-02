using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace minhas_contas.Migrations
{
    public partial class initialMigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    KwGasto = table.Column<long>(type: "bigint", nullable: false),
                    dataLeitura = table.Column<string>(type: "longtext", nullable: true),
                    dataPagto = table.Column<string>(type: "longtext", nullable: true),
                    mediaConsumo = table.Column<float>(type: "float", nullable: false),
                    numLeitura = table.Column<long>(type: "bigint", nullable: false),
                    valorPagar = table.Column<float>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accounts");
        }
    }
}
