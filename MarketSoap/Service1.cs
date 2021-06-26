using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MarketService.DTOs;
using MarketService.Implementations;

namespace MarketSoap
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        private TradeItemManagementService TradeItemService = new TradeItemManagementService();

        public List<TradeItemDTO> GetTradeItems(string filter)
        {
            return TradeItemService.Get(filter);
        }

        public string PostTradeItem(TradeItemDTO TradeItemDTO)
        {
            if (!TradeItemService.Save(TradeItemDTO))
            {
                return "Trade Item is not Saved";
            }
            else
            {
                return "Trade Item is Saved";
            }
        }

        public string DeleteTradeItem(int ID)
        {
            if (!TradeItemService.Delete(ID))
            {
                return "Trade Item is not Deleted";
            }
            else
            {
                return "Trade Item is Deleted";
            }
        }

        public string PutTradeItems(TradeItemDTO TradeItemDTO)
        {
            if (!TradeItemService.Edit(TradeItemDTO))
            {
                return "Fail";
            }
            else
            {
                return "Success";
            }
        }

        public TradeItemDTO GetTradeItemByID(int ID)
        {
            return TradeItemService.GetByID(ID);
        }

        private CustomerManagementService CustomerService = new CustomerManagementService();

        public List<CustomerDTO> GetCustomers(string filter)
        {
            return CustomerService.Get(filter);
        }

        public string PostCustomer(CustomerDTO CustomerDTO)
        {
            if (!CustomerService.Save(CustomerDTO))
            {
                return "Customer is not Saved";
            }
            else
            {
                return "Customer is Saved";
            }
        }

        public string DeleteCustomer(int ID)
        {
            if (!CustomerService.Delete(ID))
            {
                return "Customer is not Deleted";
            }
            else
            {
                return "Customer is Deleted";
            }
        }

        public string PutCustomers(CustomerDTO CustomerDTO)
        {
            if (!CustomerService.Edit(CustomerDTO))
            {
                return "Fail";
            }
            else
            {
                return "Success";
            }
        }

        public CustomerDTO GetCustomerByID(int ID)
        {
            return CustomerService.GetByID(ID);
        }

        private SellerManagementService SellerService = new SellerManagementService();

        public List<SellerDTO> GetSellers(string filter)
        {
            return SellerService.Get(filter);
        }

        public string PostSeller(SellerDTO SellerDTO)
        {
            if (!SellerService.Save(SellerDTO))
            {
                return "Seller is not Saved";
            }
            else
            {
                return "Seller is Saved";
            }
        }

        public string DeleteSeller(int ID)
        {
            if (!SellerService.Delete(ID))
            {
                return "Seller is not Deleted";
            }
            else
            {
                return "Seller is Deleted";
            }
        }

        public string PutSellers(SellerDTO SellerDTO)
        {
            if (!SellerService.Edit(SellerDTO))
            {
                return "Fail";
            }
            else
            {
                return "Success";
            }
        }

        public SellerDTO GetSellerByID(int ID)
        {
            return SellerService.GetByID(ID);
        }
    }
}
