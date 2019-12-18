﻿//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cliente2.EstoqueService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Produto", Namespace="http://schemas.datacontract.org/2004/07/ServicoEstoque")]
    [System.SerializableAttribute()]
    public partial class Produto : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescricaoProdutoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int EstoqueProdutoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeProdutoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NumeroProdutoField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DescricaoProduto {
            get {
                return this.DescricaoProdutoField;
            }
            set {
                if ((object.ReferenceEquals(this.DescricaoProdutoField, value) != true)) {
                    this.DescricaoProdutoField = value;
                    this.RaisePropertyChanged("DescricaoProduto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int EstoqueProduto {
            get {
                return this.EstoqueProdutoField;
            }
            set {
                if ((this.EstoqueProdutoField.Equals(value) != true)) {
                    this.EstoqueProdutoField = value;
                    this.RaisePropertyChanged("EstoqueProduto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NomeProduto {
            get {
                return this.NomeProdutoField;
            }
            set {
                if ((object.ReferenceEquals(this.NomeProdutoField, value) != true)) {
                    this.NomeProdutoField = value;
                    this.RaisePropertyChanged("NomeProduto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NumeroProduto {
            get {
                return this.NumeroProdutoField;
            }
            set {
                if ((object.ReferenceEquals(this.NumeroProdutoField, value) != true)) {
                    this.NumeroProdutoField = value;
                    this.RaisePropertyChanged("NumeroProduto");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EstoqueService.IEstoqueService")]
    public interface IEstoqueService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEstoqueService/ListarProdutos", ReplyAction="http://tempuri.org/IEstoqueService/ListarProdutosResponse")]
        string[] ListarProdutos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEstoqueService/ListarProdutos", ReplyAction="http://tempuri.org/IEstoqueService/ListarProdutosResponse")]
        System.Threading.Tasks.Task<string[]> ListarProdutosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEstoqueService/IncluirProduto", ReplyAction="http://tempuri.org/IEstoqueService/IncluirProdutoResponse")]
        bool IncluirProduto(Cliente2.EstoqueService.Produto Produto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEstoqueService/IncluirProduto", ReplyAction="http://tempuri.org/IEstoqueService/IncluirProdutoResponse")]
        System.Threading.Tasks.Task<bool> IncluirProdutoAsync(Cliente2.EstoqueService.Produto Produto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEstoqueService/RemoverProduto", ReplyAction="http://tempuri.org/IEstoqueService/RemoverProdutoResponse")]
        bool RemoverProduto(string NumeroProduto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEstoqueService/RemoverProduto", ReplyAction="http://tempuri.org/IEstoqueService/RemoverProdutoResponse")]
        System.Threading.Tasks.Task<bool> RemoverProdutoAsync(string NumeroProduto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEstoqueService/ConsultarEstoque", ReplyAction="http://tempuri.org/IEstoqueService/ConsultarEstoqueResponse")]
        int ConsultarEstoque(string NumeroProduto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEstoqueService/ConsultarEstoque", ReplyAction="http://tempuri.org/IEstoqueService/ConsultarEstoqueResponse")]
        System.Threading.Tasks.Task<int> ConsultarEstoqueAsync(string NumeroProduto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEstoqueService/AdicionarEstoque", ReplyAction="http://tempuri.org/IEstoqueService/AdicionarEstoqueResponse")]
        bool AdicionarEstoque(string NumeroProduto, int Quantidade);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEstoqueService/AdicionarEstoque", ReplyAction="http://tempuri.org/IEstoqueService/AdicionarEstoqueResponse")]
        System.Threading.Tasks.Task<bool> AdicionarEstoqueAsync(string NumeroProduto, int Quantidade);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEstoqueService/RemoverEstoque", ReplyAction="http://tempuri.org/IEstoqueService/RemoverEstoqueResponse")]
        bool RemoverEstoque(string NumeroProduto, int Quantidade);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEstoqueService/RemoverEstoque", ReplyAction="http://tempuri.org/IEstoqueService/RemoverEstoqueResponse")]
        System.Threading.Tasks.Task<bool> RemoverEstoqueAsync(string NumeroProduto, int Quantidade);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEstoqueService/VerProduto", ReplyAction="http://tempuri.org/IEstoqueService/VerProdutoResponse")]
        Cliente2.EstoqueService.Produto VerProduto(string NumeroProduto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEstoqueService/VerProduto", ReplyAction="http://tempuri.org/IEstoqueService/VerProdutoResponse")]
        System.Threading.Tasks.Task<Cliente2.EstoqueService.Produto> VerProdutoAsync(string NumeroProduto);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEstoqueServiceChannel : Cliente2.EstoqueService.IEstoqueService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EstoqueServiceClient : System.ServiceModel.ClientBase<Cliente2.EstoqueService.IEstoqueService>, Cliente2.EstoqueService.IEstoqueService {
        
        public EstoqueServiceClient() {
        }
        
        public EstoqueServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EstoqueServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EstoqueServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EstoqueServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string[] ListarProdutos() {
            return base.Channel.ListarProdutos();
        }
        
        public System.Threading.Tasks.Task<string[]> ListarProdutosAsync() {
            return base.Channel.ListarProdutosAsync();
        }
        
        public bool IncluirProduto(Cliente2.EstoqueService.Produto Produto) {
            return base.Channel.IncluirProduto(Produto);
        }
        
        public System.Threading.Tasks.Task<bool> IncluirProdutoAsync(Cliente2.EstoqueService.Produto Produto) {
            return base.Channel.IncluirProdutoAsync(Produto);
        }
        
        public bool RemoverProduto(string NumeroProduto) {
            return base.Channel.RemoverProduto(NumeroProduto);
        }
        
        public System.Threading.Tasks.Task<bool> RemoverProdutoAsync(string NumeroProduto) {
            return base.Channel.RemoverProdutoAsync(NumeroProduto);
        }
        
        public int ConsultarEstoque(string NumeroProduto) {
            return base.Channel.ConsultarEstoque(NumeroProduto);
        }
        
        public System.Threading.Tasks.Task<int> ConsultarEstoqueAsync(string NumeroProduto) {
            return base.Channel.ConsultarEstoqueAsync(NumeroProduto);
        }
        
        public bool AdicionarEstoque(string NumeroProduto, int Quantidade) {
            return base.Channel.AdicionarEstoque(NumeroProduto, Quantidade);
        }
        
        public System.Threading.Tasks.Task<bool> AdicionarEstoqueAsync(string NumeroProduto, int Quantidade) {
            return base.Channel.AdicionarEstoqueAsync(NumeroProduto, Quantidade);
        }
        
        public bool RemoverEstoque(string NumeroProduto, int Quantidade) {
            return base.Channel.RemoverEstoque(NumeroProduto, Quantidade);
        }
        
        public System.Threading.Tasks.Task<bool> RemoverEstoqueAsync(string NumeroProduto, int Quantidade) {
            return base.Channel.RemoverEstoqueAsync(NumeroProduto, Quantidade);
        }
        
        public Cliente2.EstoqueService.Produto VerProduto(string NumeroProduto) {
            return base.Channel.VerProduto(NumeroProduto);
        }
        
        public System.Threading.Tasks.Task<Cliente2.EstoqueService.Produto> VerProdutoAsync(string NumeroProduto) {
            return base.Channel.VerProdutoAsync(NumeroProduto);
        }
    }
}
