using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AplicacaoInterativa.Migrations
{
    public partial class PopularLanches : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl,ImagemUrl,IsLanchePreferido,Nome,Preco) VALUES(1,'Brigadeiro de chocolate Belga','Feito com os melhores chocolates belgas.',1, '/images/produtos/brigadeiro.jpg','/images/produtos/brigadeiro.jpg', 0 ,'Brigadeiro', 12.50)");
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl,ImagemUrl,IsLanchePreferido,Nome,Preco) VALUES(1,'Torta Holandesa','Torta holandesa com recheio de cereja.',1, '/images/produtos/torta.jpg','/images/produtos/torta.jpg', 0 ,'Torta', 22.50)");
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl,ImagemUrl,IsLanchePreferido,Nome,Preco) VALUES(1,'Mousse de chocolate','Mousse de chocolates .',1, '/images/produtos/mousse.jpg','/images/produtos/mousse.jpg', 0 ,'Mousse', 10.00)");
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl,ImagemUrl,IsLanchePreferido,Nome,Preco) VALUES(2,'Pizza','Pizza portuguesa.',1, '/images/produtos/pizzaportuguesa.jpg','/images/produtos/pizzaportuguesa.jpg', 0 ,'Pizza Portuguesa',42.50)");
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl,ImagemUrl,IsLanchePreferido,Nome,Preco) VALUES(2,'Pizza','Pizza pepperoni.',1, '/images/produtos/pizzapepperoni.jpg','/images/produtos/pizzapepperoni.jpg', 0 ,'Pizza Pepperoni', 60.00)");
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl,ImagemUrl,IsLanchePreferido,Nome,Preco) VALUES(2,'Lasanha','Lasanha de frango.',1, '/images/produtos/lasanhas.jpg','/images/produtos/lasanhas.jpg', 0 ,'Lasanha de frango', 42.00)");
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl,ImagemUrl,IsLanchePreferido,Nome,Preco) VALUES(3,'Tacos','Tacos veganos de grao de bico.',1, '/images/produtos/tacosgraodebico.jpg','/images/produtos/tacosgraodebico.jpg', 0 ,'Tacos Veganos', 22.50)");
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl,ImagemUrl,IsLanchePreferido,Nome,Preco) VALUES(3,'Cuscuz','Cuscuz de cebola e alho poró.',1, '/images/produtos/cuscuz.jpg','/images/produtos/cuscuz.jpg', 0 ,'Cuscuz', 30.00)");



        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Lanches");
        }
    }
}
