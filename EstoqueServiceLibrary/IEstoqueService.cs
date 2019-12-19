using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Net.Security;

namespace ServicoEstoque {
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da interface "IService1" no arquivo de código e configuração ao mesmo tempo.

    [ServiceContract(Namespace = "http://localhost/estoqueService/01", Name = "IEstoqueService")]
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

    [ServiceContract(Namespace = "http://localhost/estoqueService/02", Name = "IEstoqueServiceV2")]
    public interface IEstoqueServiceV2 {

        [OperationContract(ProtectionLevel = ProtectionLevel.EncryptAndSign)]
        bool AdicionarEstoque(String NumeroProduto, int Quantidade);

        [OperationContract(ProtectionLevel = ProtectionLevel.EncryptAndSign)]
        bool RemoverEstoque(String NumeroProduto, int Quantidade);

        [OperationContract(ProtectionLevel = ProtectionLevel.EncryptAndSign)]
        int ConsultarEstoque(String NumeroProduto);

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
