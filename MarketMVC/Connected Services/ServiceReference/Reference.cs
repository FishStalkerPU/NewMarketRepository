﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MarketMVC.ServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/MarketSoap")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
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
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        MarketMVC.ServiceReference.CompositeType GetDataUsingDataContract(MarketMVC.ServiceReference.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<MarketMVC.ServiceReference.CompositeType> GetDataUsingDataContractAsync(MarketMVC.ServiceReference.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetTradeItems", ReplyAction="http://tempuri.org/IService1/GetTradeItemsResponse")]
        MarketService.DTOs.TradeItemDTO[] GetTradeItems(string filter);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetTradeItems", ReplyAction="http://tempuri.org/IService1/GetTradeItemsResponse")]
        System.Threading.Tasks.Task<MarketService.DTOs.TradeItemDTO[]> GetTradeItemsAsync(string filter);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PostTradeItem", ReplyAction="http://tempuri.org/IService1/PostTradeItemResponse")]
        string PostTradeItem(MarketService.DTOs.TradeItemDTO TradeItemDTO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PostTradeItem", ReplyAction="http://tempuri.org/IService1/PostTradeItemResponse")]
        System.Threading.Tasks.Task<string> PostTradeItemAsync(MarketService.DTOs.TradeItemDTO TradeItemDTO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteTradeItem", ReplyAction="http://tempuri.org/IService1/DeleteTradeItemResponse")]
        string DeleteTradeItem(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteTradeItem", ReplyAction="http://tempuri.org/IService1/DeleteTradeItemResponse")]
        System.Threading.Tasks.Task<string> DeleteTradeItemAsync(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PutTradeItems", ReplyAction="http://tempuri.org/IService1/PutTradeItemsResponse")]
        string PutTradeItems(MarketService.DTOs.TradeItemDTO TradeItemDTO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PutTradeItems", ReplyAction="http://tempuri.org/IService1/PutTradeItemsResponse")]
        System.Threading.Tasks.Task<string> PutTradeItemsAsync(MarketService.DTOs.TradeItemDTO TradeItemDTO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetTradeItemByID", ReplyAction="http://tempuri.org/IService1/GetTradeItemByIDResponse")]
        MarketService.DTOs.TradeItemDTO GetTradeItemByID(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetTradeItemByID", ReplyAction="http://tempuri.org/IService1/GetTradeItemByIDResponse")]
        System.Threading.Tasks.Task<MarketService.DTOs.TradeItemDTO> GetTradeItemByIDAsync(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetCustomers", ReplyAction="http://tempuri.org/IService1/GetCustomersResponse")]
        MarketService.DTOs.CustomerDTO[] GetCustomers(string filter);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetCustomers", ReplyAction="http://tempuri.org/IService1/GetCustomersResponse")]
        System.Threading.Tasks.Task<MarketService.DTOs.CustomerDTO[]> GetCustomersAsync(string filter);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PostCustomer", ReplyAction="http://tempuri.org/IService1/PostCustomerResponse")]
        string PostCustomer(MarketService.DTOs.CustomerDTO CustomerDTO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PostCustomer", ReplyAction="http://tempuri.org/IService1/PostCustomerResponse")]
        System.Threading.Tasks.Task<string> PostCustomerAsync(MarketService.DTOs.CustomerDTO CustomerDTO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteCustomer", ReplyAction="http://tempuri.org/IService1/DeleteCustomerResponse")]
        string DeleteCustomer(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteCustomer", ReplyAction="http://tempuri.org/IService1/DeleteCustomerResponse")]
        System.Threading.Tasks.Task<string> DeleteCustomerAsync(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PutCustomers", ReplyAction="http://tempuri.org/IService1/PutCustomersResponse")]
        string PutCustomers(MarketService.DTOs.CustomerDTO CustomerDTO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PutCustomers", ReplyAction="http://tempuri.org/IService1/PutCustomersResponse")]
        System.Threading.Tasks.Task<string> PutCustomersAsync(MarketService.DTOs.CustomerDTO CustomerDTO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetCustomerByID", ReplyAction="http://tempuri.org/IService1/GetCustomerByIDResponse")]
        MarketService.DTOs.CustomerDTO GetCustomerByID(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetCustomerByID", ReplyAction="http://tempuri.org/IService1/GetCustomerByIDResponse")]
        System.Threading.Tasks.Task<MarketService.DTOs.CustomerDTO> GetCustomerByIDAsync(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetSellers", ReplyAction="http://tempuri.org/IService1/GetSellersResponse")]
        MarketService.DTOs.SellerDTO[] GetSellers(string filter);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetSellers", ReplyAction="http://tempuri.org/IService1/GetSellersResponse")]
        System.Threading.Tasks.Task<MarketService.DTOs.SellerDTO[]> GetSellersAsync(string filter);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PostSeller", ReplyAction="http://tempuri.org/IService1/PostSellerResponse")]
        string PostSeller(MarketService.DTOs.SellerDTO SellerDTO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PostSeller", ReplyAction="http://tempuri.org/IService1/PostSellerResponse")]
        System.Threading.Tasks.Task<string> PostSellerAsync(MarketService.DTOs.SellerDTO SellerDTO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteSeller", ReplyAction="http://tempuri.org/IService1/DeleteSellerResponse")]
        string DeleteSeller(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteSeller", ReplyAction="http://tempuri.org/IService1/DeleteSellerResponse")]
        System.Threading.Tasks.Task<string> DeleteSellerAsync(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PutSellers", ReplyAction="http://tempuri.org/IService1/PutSellersResponse")]
        string PutSellers(MarketService.DTOs.SellerDTO SellerDTO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PutSellers", ReplyAction="http://tempuri.org/IService1/PutSellersResponse")]
        System.Threading.Tasks.Task<string> PutSellersAsync(MarketService.DTOs.SellerDTO SellerDTO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetSellerByID", ReplyAction="http://tempuri.org/IService1/GetSellerByIDResponse")]
        MarketService.DTOs.SellerDTO GetSellerByID(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetSellerByID", ReplyAction="http://tempuri.org/IService1/GetSellerByIDResponse")]
        System.Threading.Tasks.Task<MarketService.DTOs.SellerDTO> GetSellerByIDAsync(int ID);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : MarketMVC.ServiceReference.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<MarketMVC.ServiceReference.IService1>, MarketMVC.ServiceReference.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public MarketMVC.ServiceReference.CompositeType GetDataUsingDataContract(MarketMVC.ServiceReference.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<MarketMVC.ServiceReference.CompositeType> GetDataUsingDataContractAsync(MarketMVC.ServiceReference.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public MarketService.DTOs.TradeItemDTO[] GetTradeItems(string filter) {
            return base.Channel.GetTradeItems(filter);
        }
        
        public System.Threading.Tasks.Task<MarketService.DTOs.TradeItemDTO[]> GetTradeItemsAsync(string filter) {
            return base.Channel.GetTradeItemsAsync(filter);
        }
        
        public string PostTradeItem(MarketService.DTOs.TradeItemDTO TradeItemDTO) {
            return base.Channel.PostTradeItem(TradeItemDTO);
        }
        
        public System.Threading.Tasks.Task<string> PostTradeItemAsync(MarketService.DTOs.TradeItemDTO TradeItemDTO) {
            return base.Channel.PostTradeItemAsync(TradeItemDTO);
        }
        
        public string DeleteTradeItem(int ID) {
            return base.Channel.DeleteTradeItem(ID);
        }
        
        public System.Threading.Tasks.Task<string> DeleteTradeItemAsync(int ID) {
            return base.Channel.DeleteTradeItemAsync(ID);
        }
        
        public string PutTradeItems(MarketService.DTOs.TradeItemDTO TradeItemDTO) {
            return base.Channel.PutTradeItems(TradeItemDTO);
        }
        
        public System.Threading.Tasks.Task<string> PutTradeItemsAsync(MarketService.DTOs.TradeItemDTO TradeItemDTO) {
            return base.Channel.PutTradeItemsAsync(TradeItemDTO);
        }
        
        public MarketService.DTOs.TradeItemDTO GetTradeItemByID(int ID) {
            return base.Channel.GetTradeItemByID(ID);
        }
        
        public System.Threading.Tasks.Task<MarketService.DTOs.TradeItemDTO> GetTradeItemByIDAsync(int ID) {
            return base.Channel.GetTradeItemByIDAsync(ID);
        }
        
        public MarketService.DTOs.CustomerDTO[] GetCustomers(string filter) {
            return base.Channel.GetCustomers(filter);
        }
        
        public System.Threading.Tasks.Task<MarketService.DTOs.CustomerDTO[]> GetCustomersAsync(string filter) {
            return base.Channel.GetCustomersAsync(filter);
        }
        
        public string PostCustomer(MarketService.DTOs.CustomerDTO CustomerDTO) {
            return base.Channel.PostCustomer(CustomerDTO);
        }
        
        public System.Threading.Tasks.Task<string> PostCustomerAsync(MarketService.DTOs.CustomerDTO CustomerDTO) {
            return base.Channel.PostCustomerAsync(CustomerDTO);
        }
        
        public string DeleteCustomer(int ID) {
            return base.Channel.DeleteCustomer(ID);
        }
        
        public System.Threading.Tasks.Task<string> DeleteCustomerAsync(int ID) {
            return base.Channel.DeleteCustomerAsync(ID);
        }
        
        public string PutCustomers(MarketService.DTOs.CustomerDTO CustomerDTO) {
            return base.Channel.PutCustomers(CustomerDTO);
        }
        
        public System.Threading.Tasks.Task<string> PutCustomersAsync(MarketService.DTOs.CustomerDTO CustomerDTO) {
            return base.Channel.PutCustomersAsync(CustomerDTO);
        }
        
        public MarketService.DTOs.CustomerDTO GetCustomerByID(int ID) {
            return base.Channel.GetCustomerByID(ID);
        }
        
        public System.Threading.Tasks.Task<MarketService.DTOs.CustomerDTO> GetCustomerByIDAsync(int ID) {
            return base.Channel.GetCustomerByIDAsync(ID);
        }
        
        public MarketService.DTOs.SellerDTO[] GetSellers(string filter) {
            return base.Channel.GetSellers(filter);
        }
        
        public System.Threading.Tasks.Task<MarketService.DTOs.SellerDTO[]> GetSellersAsync(string filter) {
            return base.Channel.GetSellersAsync(filter);
        }
        
        public string PostSeller(MarketService.DTOs.SellerDTO SellerDTO) {
            return base.Channel.PostSeller(SellerDTO);
        }
        
        public System.Threading.Tasks.Task<string> PostSellerAsync(MarketService.DTOs.SellerDTO SellerDTO) {
            return base.Channel.PostSellerAsync(SellerDTO);
        }
        
        public string DeleteSeller(int ID) {
            return base.Channel.DeleteSeller(ID);
        }
        
        public System.Threading.Tasks.Task<string> DeleteSellerAsync(int ID) {
            return base.Channel.DeleteSellerAsync(ID);
        }
        
        public string PutSellers(MarketService.DTOs.SellerDTO SellerDTO) {
            return base.Channel.PutSellers(SellerDTO);
        }
        
        public System.Threading.Tasks.Task<string> PutSellersAsync(MarketService.DTOs.SellerDTO SellerDTO) {
            return base.Channel.PutSellersAsync(SellerDTO);
        }
        
        public MarketService.DTOs.SellerDTO GetSellerByID(int ID) {
            return base.Channel.GetSellerByID(ID);
        }
        
        public System.Threading.Tasks.Task<MarketService.DTOs.SellerDTO> GetSellerByIDAsync(int ID) {
            return base.Channel.GetSellerByIDAsync(ID);
        }
    }
}