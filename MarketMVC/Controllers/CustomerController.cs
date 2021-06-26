using MarketMVC.ViewModels;
using MarketService.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MarketMVC.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index(string Search_Data = "")
        {
            List<CustomerVM> CustomerVMs = new List<CustomerVM>();
            using (ServiceReference.Service1Client service = new ServiceReference.Service1Client())
            {
                foreach (var item in service.GetCustomers(Search_Data))
                {
                    CustomerVMs.Add(new CustomerVM(item));
                }
            }
            return View(CustomerVMs);
        }

        public ActionResult Create()
        {
            ViewBag.TradeItems = Helpers.LoadUtilities.LoadTradeItemData();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CustomerVM customerVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (ServiceReference.Service1Client service = new ServiceReference.Service1Client())
                    {
                        CustomerDTO CustomerDto = new CustomerDTO
                        {
                            ID = customerVM.ID,
                            Username = customerVM.Username,
                            PrefferedPaymentType = customerVM.PrefferedPaymentType,
                            TotalSpent = customerVM.TotalSpent,
                            ProductsRated = customerVM.ProductsRated,
                            TradeItemID = customerVM.TradeItemID,
                            //TradeItem = new TradeItemDTO
                            //{
                            //    ID = customerVM.TradeItemID,
                            //    Name = customerVM.TradeItem.Name,
                            //    Quantity = customerVM.TradeItem.Quantity,
                            //    PricePerItem = customerVM.TradeItem.PricePerItem,
                            //    Rating = customerVM.TradeItem.Rating,
                            //    FreeDelivery = customerVM.TradeItem.FreeDelivery
                            //},
                            MostPurchasedProduct = customerVM.MostPurchasedProduct,
                            PremiumAccount = customerVM.PremiumAccount
                        };
                        service.PostCustomer(CustomerDto);
                        return RedirectToAction("Index");
                    }
                }
                return View();
            }
            catch
            {
                ViewBag.TradeItems = Helpers.LoadUtilities.LoadTradeItemData();
                return View();
            }

        }

        public ActionResult Delete(int id)
        {
            using (ServiceReference.Service1Client service = new ServiceReference.Service1Client())
            {
                service.DeleteCustomer(id);
            }
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int ID)
        {
            ViewBag.Customers = Helpers.LoadUtilities.LoadTradeItemData();
            CustomerVM customerVM = new CustomerVM();
            using (ServiceReference.Service1Client service = new ServiceReference.Service1Client())
            {
                CustomerDTO customerDTO = service.GetCustomerByID(ID);
                customerVM.Username = customerDTO.Username;
                customerVM.PrefferedPaymentType = customerDTO.PrefferedPaymentType;
                customerVM.TotalSpent = customerDTO.TotalSpent;
                customerVM.ProductsRated = customerDTO.ProductsRated;
                customerVM.TradeItemID = customerDTO.TradeItemID;
                customerVM.MostPurchasedProduct = customerDTO.MostPurchasedProduct;
                customerVM.PremiumAccount = customerDTO.PremiumAccount;
            }
            return View(customerVM);
        }

        [HttpPost]
        public ActionResult Edit(CustomerVM customerVM)
        {
            using (ServiceReference.Service1Client service = new ServiceReference.Service1Client())
            {
                CustomerDTO customerDTO = new CustomerDTO
                {
                    ID = customerVM.ID,
                    Username = customerVM.Username,
                    PrefferedPaymentType = customerVM.PrefferedPaymentType,
                    TotalSpent = customerVM.TotalSpent,
                    ProductsRated = customerVM.ProductsRated,
                    TradeItemID = customerVM.TradeItemID,
                    MostPurchasedProduct = customerVM.MostPurchasedProduct,
                    PremiumAccount = customerVM.PremiumAccount
                };
                service.PutCustomers(customerDTO);
            }
            return RedirectToAction("Index");
        }
    }
}