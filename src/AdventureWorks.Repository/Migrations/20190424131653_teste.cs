using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdventureWorks.Repository.Migrations
{
    public partial class teste : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "AdventureWorks");

            migrationBuilder.CreateTable(
                name: "Competidor",
                schema: "AdventureWorks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(maxLength: 150, nullable: false),
                    Sexo = table.Column<string>(nullable: false),
                    TemperaturaMediaCorpo = table.Column<decimal>(nullable: false),
                    Peso = table.Column<decimal>(nullable: false),
                    Altura = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Competidor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PistaCorrida",
                schema: "AdventureWorks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PistaCorrida", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HistoricoCorrida",
                schema: "AdventureWorks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CompetidorId = table.Column<int>(nullable: false),
                    PistaCorridaId = table.Column<int>(nullable: false),
                    DataCorrida = table.Column<DateTime>(nullable: false),
                    TempoGasto = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoricoCorrida", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HistoricoCorrida_Competidor_CompetidorId",
                        column: x => x.CompetidorId,
                        principalSchema: "AdventureWorks",
                        principalTable: "Competidor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HistoricoCorrida_PistaCorrida_PistaCorridaId",
                        column: x => x.PistaCorridaId,
                        principalSchema: "AdventureWorks",
                        principalTable: "PistaCorrida",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HistoricoCorrida_CompetidorId",
                schema: "AdventureWorks",
                table: "HistoricoCorrida",
                column: "CompetidorId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoricoCorrida_PistaCorridaId",
                schema: "AdventureWorks",
                table: "HistoricoCorrida",
                column: "PistaCorridaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HistoricoCorrida",
                schema: "AdventureWorks");

            migrationBuilder.DropTable(
                name: "Competidor",
                schema: "AdventureWorks");

            migrationBuilder.DropTable(
                name: "PistaCorrida",
                schema: "AdventureWorks");
        }
    }
}
