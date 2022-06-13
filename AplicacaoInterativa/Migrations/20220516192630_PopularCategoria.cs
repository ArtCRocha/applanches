using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AplicacaoInterativa.Migrations
{
    public partial class PopularCategoria : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categorias(Nome, Descricao)" +
               "VALUES ('Doces', 'Doces de primeira qualidae')");

            migrationBuilder.Sql("INSERT INTO Categorias(Nome, Descricao)" +
                "VALUES ('Massas', 'A cozinha italiana até você')");

            migrationBuilder.Sql("INSERT INTO Categorias(Nome, Descricao)" +
                "VALUES ('Veganos', 'Nada de origem animal')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categorias");
        }
    }
}
