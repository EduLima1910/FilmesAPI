using Microsoft.EntityFrameworkCore.Migrations;

namespace FilmesAPI.Migrations
{
    public partial class AdicionandoClassificaçãoEtaria : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClassificacaoEtaria",
                table: "Filme",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClassificacaoEtaria",
                table: "Filme");
        }
    }
}
