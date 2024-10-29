using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace aula13_MTMPostgreSQL.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Habilidades",
                columns: table => new
                {
                    HabilidadeId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Habilidades", x => x.HabilidadeId);
                });

            migrationBuilder.CreateTable(
                name: "Pessoas",
                columns: table => new
                {
                    PessoaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoas", x => x.PessoaId);
                });

            migrationBuilder.CreateTable(
                name: "PessoaHabilidades",
                columns: table => new
                {
                    HabilidadesHabilidadeId = table.Column<int>(type: "INTEGER", nullable: false),
                    PessoasPessoaId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PessoaHabilidades", x => new { x.HabilidadesHabilidadeId, x.PessoasPessoaId });
                    table.ForeignKey(
                        name: "FK_PessoaHabilidades_Habilidades_HabilidadesHabilidadeId",
                        column: x => x.HabilidadesHabilidadeId,
                        principalTable: "Habilidades",
                        principalColumn: "HabilidadeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PessoaHabilidades_Pessoas_PessoasPessoaId",
                        column: x => x.PessoasPessoaId,
                        principalTable: "Pessoas",
                        principalColumn: "PessoaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PessoaHabilidades_PessoasPessoaId",
                table: "PessoaHabilidades",
                column: "PessoasPessoaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PessoaHabilidades");

            migrationBuilder.DropTable(
                name: "Habilidades");

            migrationBuilder.DropTable(
                name: "Pessoas");
        }
    }
}
