namespace EstoqueEntityModel.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EstoqueEntityModel.ProvedorEstoque>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EstoqueEntityModel.ProvedorEstoque context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

			context.ProdutosEstoque.AddOrUpdate(
                p => p.Id,
                new ProdutoEstoque { NumeroProduto= "1000", NomeProduto = "Produto 1", DescricaoProduto = "Este � o produto 1", EstoqueProduto = 100 },
                new ProdutoEstoque { NumeroProduto = "2000", NomeProduto = "Produto 2", DescricaoProduto = "Este � o produto 2", EstoqueProduto = 10 },
                new ProdutoEstoque { NumeroProduto = "3000", NomeProduto = "Produto 3", DescricaoProduto = "Este � o produto 3", EstoqueProduto = 200 },
                new ProdutoEstoque { NumeroProduto = "4000", NomeProduto = "Produto 4", DescricaoProduto = "Este � o produto 4", EstoqueProduto = 300 },
                new ProdutoEstoque { NumeroProduto = "5000", NomeProduto = "Produto 5", DescricaoProduto = "Este � o produto 5", EstoqueProduto = 400 },
                new ProdutoEstoque { NumeroProduto = "6000", NomeProduto = "Produto 6", DescricaoProduto = "Este � o produto 6", EstoqueProduto = 500 },
                new ProdutoEstoque { NumeroProduto = "7000", NomeProduto = "Produto 7", DescricaoProduto = "Este � o produto 7", EstoqueProduto = 30 },
                new ProdutoEstoque { NumeroProduto = "8000", NomeProduto = "Produto 8", DescricaoProduto = "Este � o produto 8", EstoqueProduto = 30 },
                new ProdutoEstoque { NumeroProduto = "9000", NomeProduto = "Produto 9", DescricaoProduto = "Este � o produto 9", EstoqueProduto = 400 },
                new ProdutoEstoque { NumeroProduto = "10000", NomeProduto = "Produto 10", DescricaoProduto = "Este � o produto 10", EstoqueProduto = 2 }
             );
			context.SaveChanges();
        }
    }
}
