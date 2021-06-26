using Data.Context;
using Data.Context.Entities;
using System.Data.Entity;
using MarketService.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketService.Implementations
{
    public class CustomerManagementService
    {
        private MarketSystemDBContext ctx = new MarketSystemDBContext();

        public List<CustomerDTO> Get(string filter)
        {
            List<CustomerDTO> CustomerDto = new List<CustomerDTO>();
            var CustomerList = ctx.Customers.Include(x => x.TradeItem).ToList();
            foreach (var item in CustomerList.Where(x => x.Username.Contains(filter)))
            {
                CustomerDto.Add(new CustomerDTO
                {
                    ID = item.ID,
                    Username = item.Username,
                    PrefferedPaymentType = item.PrefferedPaymentType,
                    TotalSpent = item.TotalSpent,
                    ProductsRated = item.ProductsRated,
                    TradeItemID = item.TradeItemID,
                    TradeItem = new TradeItemDTO
                    {
                        ID = item.TradeItemID,
                        Name = item.TradeItem.Name,
                        Quantity = item.TradeItem.Quantity,
                        PricePerItem = item.TradeItem.PricePerItem,
                        Rating = item.TradeItem.Rating,
                        FreeDelivery = item.TradeItem.FreeDelivery
                    },
                    MostPurchasedProduct = item.MostPurchasedProduct,
                    PremiumAccount = item.PremiumAccount

                });
            }
            return CustomerDto;
        }

        public bool Save(CustomerDTO CustomerDTO)
        {
            Customer Customer = new Customer
            {
                //ID = CustomerDTO.ID,
                Username = CustomerDTO.Username,
                PrefferedPaymentType = CustomerDTO.PrefferedPaymentType,
                TotalSpent = CustomerDTO.TotalSpent,
                ProductsRated = CustomerDTO.ProductsRated,
                TradeItemID = CustomerDTO.TradeItemID,
                MostPurchasedProduct = CustomerDTO.MostPurchasedProduct,
                PremiumAccount = CustomerDTO.PremiumAccount
            };
            try
            {
                ctx.Customers.Add(Customer);
                ctx.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(int ID)
        {
            try
            {
                Customer Customer = ctx.Customers.Find(ID);
                ctx.Customers.Remove(Customer);
                ctx.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public CustomerDTO GetByID(int ID)
        {
            Customer customer = ctx.Customers.Where(x => ID == x.ID).Include(x => x.TradeItem).FirstOrDefault();
            CustomerDTO customerDTO = new CustomerDTO
            {
                ID = customer.ID,
                Username = customer.Username,
                PrefferedPaymentType = customer.PrefferedPaymentType,
                TotalSpent = customer.TotalSpent,
                ProductsRated = customer.ProductsRated,
                TradeItemID = customer.TradeItemID,
                MostPurchasedProduct = customer.MostPurchasedProduct,
                PremiumAccount = customer.PremiumAccount
            };
            return customerDTO;
        }

        public bool Edit(CustomerDTO customersDTO)
        {
            Customer customer = new Customer
            {
                ID = customersDTO.ID,
                Username = customersDTO.Username,
                PrefferedPaymentType = customersDTO.PrefferedPaymentType,
                TotalSpent = customersDTO.TotalSpent,
                ProductsRated = customersDTO.ProductsRated,
                TradeItemID = customersDTO.TradeItemID,
                PremiumAccount = customersDTO.PremiumAccount
            };
            try
            {
                ctx.Customers.Attach(customer);
                ctx.Entry(customer).State = EntityState.Modified;
                ctx.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
