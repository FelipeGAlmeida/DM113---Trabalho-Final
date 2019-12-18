using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ServicoEstoque {
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da interface "IService1" no arquivo de código e configuração ao mesmo tempo.
    [ServiceContract]
    public interface IEstoqueService {

        [OperationContract]
        List<String> ListarProdutos();

        [OperationContract]
        bool IncluirProduto(Produto Produto);

        [OperationContract]
        bool RemoverProduto(String NumeroProduto);

        [OperationContract]
        int ConsultarEstoque(String NumeroProduto);

        [OperationContract]
        bool AdicionarEstoque(String NumeroProduto, int Quantidade);

        [OperationContract]
        bool RemoverEstoque(String NumeroProduto, int Quantidade);

        [OperationContract]
        Produto VerProduto(String NumeroProduto);

        // TODO: Adicione suas operações de serviço aqui
    }


    // Use um contrato de dados como ilustrado no exemplo abaixo para adicionar tipos compostos a operações de serviço.
    [DataContract]
    public class Produto {

        [DataMember]
        public string NumeroProduto;

        [DataMember]
        public string NomeProduto;

        [DataMember]
        public string DescricaoProduto;

        [DataMember]
        public int EstoqueProduto;

    }
}
