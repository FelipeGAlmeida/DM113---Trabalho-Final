using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using EstoqueEntityModel;
using System.ServiceModel.Activation;

namespace ServicoEstoque {
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da classe "Service1" no arquivo de código, svc e configuração ao mesmo tempo.
    // OBSERVAÇÃO: Para iniciar o cliente de teste do WCF para testar esse serviço, selecione Service1.svc ou Service1.svc.cs no Gerenciador de Soluções e inicie a depuração.

    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class EstoqueService : IEstoqueService, IEstoqueServiceV2 {

        public List<string> ListarProdutos() {
            // Create a list of products names
            List<String> productsList = new List<String>();
            try {
                // Connect to the ProductsModel database
                using (ProvedorEstoque database = new ProvedorEstoque()) {
                    // Fetch the products names in the database
                    productsList = (from product in database.ProdutosEstoque select product.NomeProduto).ToList();
                }
            } catch {
                // Ignore exceptions in this implementation
            }
            // Return the list of products names
            return productsList;
        }

        public bool IncluirProduto(Produto Produto) {
            try {
                // Connect to the ProductsModel database
                using (ProvedorEstoque database = new ProvedorEstoque()) {
                    // Create a ProductModel object
                    ProdutoEstoque produtoEstoque = new ProdutoEstoque();
                    produtoEstoque.NumeroProduto = Produto.NumeroProduto;
                    produtoEstoque.NomeProduto = Produto.NomeProduto;
                    produtoEstoque.DescricaoProduto = Produto.DescricaoProduto;
                    produtoEstoque.EstoqueProduto = Produto.EstoqueProduto;
                    // Add it to Stock
                    database.ProdutosEstoque.Add(produtoEstoque);
                    database.SaveChanges();
                }
            } catch {
                return false;
            }
            return true;
        }

        public bool RemoverProduto(string NumeroProduto) {
            try {
                // Connect to the ProductsModel database
                using (ProvedorEstoque database = new ProvedorEstoque()) {
                    // Find the product based in its number
                    ProdutoEstoque produtoEstoque = database.ProdutosEstoque.First(
                        p => String.Compare(p.NumeroProduto, NumeroProduto) == 0);
                    // Remove it
                    database.ProdutosEstoque.Remove(produtoEstoque);
                    database.SaveChanges();
                }
            } catch {
                return false;
            }

            return true;
        }

        public int ConsultarEstoque(string NumeroProduto) {
            try {
                // Connect to the ProductsModel database
                using (ProvedorEstoque database = new ProvedorEstoque()) {
                    // Find the product based in its number
                    ProdutoEstoque produtoEstoque = database.ProdutosEstoque.First(
                        p => String.Compare(p.NumeroProduto, NumeroProduto) == 0);
                    // Return its stock value
                    return produtoEstoque.EstoqueProduto;
                }
            } catch {
            }
            return -1;
        }

        public bool AdicionarEstoque(string NumeroProduto, int Quantidade) {
            try {
                // Connect to the ProductsModel database
                using (ProvedorEstoque database = new ProvedorEstoque()) {
                    // Find the product based in its number
                    ProdutoEstoque produtoEstoque = database.ProdutosEstoque.First(
                        p => String.Compare(p.NumeroProduto, NumeroProduto) == 0);
                    // Add the quantity to its stock value and save
                    produtoEstoque.EstoqueProduto += Quantidade;
                    database.SaveChanges();
                }
            } catch {
                return false;
            }

            return true;
        }

        public bool RemoverEstoque(string NumeroProduto, int Quantidade) {
            try {
                // Connect to the ProductsModel database
                using (ProvedorEstoque database = new ProvedorEstoque()) {
                    // Find the product based in its number
                    ProdutoEstoque produtoEstoque = database.ProdutosEstoque.First(
                        p => String.Compare(p.NumeroProduto, NumeroProduto) == 0);
                    // Remove the quantity from its stock value and save
                    produtoEstoque.EstoqueProduto -= Quantidade;
                    database.SaveChanges();
                }
            } catch {
                return false;
            }
            return true;
        }

        public Produto VerProduto(string NumeroProduto) {
            Produto produto = null;
            try {
                // Connect to the ProductsModel database
                using (ProvedorEstoque database = new ProvedorEstoque()) {
                    // Find the product based in its number
                    ProdutoEstoque produtoEstoque = database.ProdutosEstoque.First(
                        p => String.Compare(p.NumeroProduto, NumeroProduto) == 0);
                    // Create an object from de ProductModel
                    produto = new Produto() {
                        NumeroProduto = produtoEstoque.NumeroProduto,
                        NomeProduto = produtoEstoque.NomeProduto,
                        DescricaoProduto = produtoEstoque.DescricaoProduto,
                        EstoqueProduto = produtoEstoque.EstoqueProduto
                    };
                }
            } catch {
            }
            // Return the object if found
            return produto;
        }
    }
}
