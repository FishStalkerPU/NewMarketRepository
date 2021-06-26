using MarketService.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MarketSoap
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here

        [OperationContract]
        List<TradeItemDTO> GetTradeItems(string filter);

        [OperationContract]
        string PostTradeItem(TradeItemDTO TradeItemDTO);

        [OperationContract]
        string DeleteTradeItem(int ID);

        [OperationContract]
        string PutTradeItems(TradeItemDTO TradeItemDTO);

        [OperationContract]
        TradeItemDTO GetTradeItemByID(int ID);

        [OperationContract]
        List<CustomerDTO> GetCustomers(string filter);

        [OperationContract]
        string PostCustomer(CustomerDTO CustomerDTO);

        [OperationContract]
        string DeleteCustomer(int ID);

        [OperationContract]
        string PutCustomers(CustomerDTO CustomerDTO);

        [OperationContract]
        CustomerDTO GetCustomerByID(int ID);

        [OperationContract]
        List<SellerDTO> GetSellers(string filter);

        [OperationContract]
        string PostSeller(SellerDTO SellerDTO);

        [OperationContract]
        string DeleteSeller(int ID);

        [OperationContract]
        string PutSellers(SellerDTO SellerDTO);

        [OperationContract]
        SellerDTO GetSellerByID(int ID);
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "MarketSoap.ContractType".
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
