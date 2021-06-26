using MarketMVC.ViewModels;
using MarketService.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MarketMVC.Controllers
{
    public class TradeItemController : Controller
    {
        // GET: TradeItem
        public ActionResult Index(string Search_Data = "")
        {
            List<TradeItemVM> TradeItemVMs = new List<TradeItemVM>();
            using (ServiceReference.Service1Client service = new ServiceReference.Service1Client())
            {
                foreach (var item in service.GetTradeItems(Search_Data))
                {
                    TradeItemVMs.Add(new TradeItemVM(item));
                }
            }
            return View(TradeItemVMs);
        }

        public ActionResult Create()
        {
            ViewBag.Sellers = Helpers.LoadUtilities.LoadSellerData();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TradeItemVM tradeItemVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (ServiceReference.Service1Client service = new ServiceReference.Service1Client())
                    {
                        TradeItemDTO TradeItemDto = new TradeItemDTO
                        {
                            ID = tradeItemVM.ID,
                            Name = tradeItemVM.Name,
                            Quantity = tradeItemVM.Quantity,
                            PricePerItem = tradeItemVM.PricePerItem,
                            SellerID = tradeItemVM.SellerID,
                            //Seller = new SellerDTO
                            //{
                            //    ID = tradeItemVM.SellerID,
                            //    Name = tradeItemVM.Seller.Name,
                            //    Address = tradeItemVM.Seller.Address,
                            //    Country = tradeItemVM.Seller.Country,
                            //   TotalQuantitySold = tradeItemVM.Seller.TotalQuantitySold,
                            //    Profit = tradeItemVM.Seller.Profit,
                            //   PremiumAccount = tradeItemVM.Seller.PremiumAccount
                            //
                            //},
                            Rating = tradeItemVM.Rating,
                            FreeDelivery = tradeItemVM.FreeDelivery
                        };
                        service.PostTradeItem(TradeItemDto);
                        return RedirectToAction("Index");
                    }
                }
                return View();
            }
            catch
            {
                ViewBag.Sellers = Helpers.LoadUtilities.LoadSellerData();
                return View();
            }

        }

        public ActionResult Delete(int id)
        {
            using (ServiceReference.Service1Client service = new ServiceReference.Service1Client())
            {
                service.DeleteTradeItem(id);
            }
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int ID)
        {
            ViewBag.Sellers = Helpers.LoadUtilities.LoadSellerData();
            TradeItemVM tradeItemVM = new TradeItemVM();
            using (ServiceReference.Service1Client service = new ServiceReference.Service1Client())
            {
                TradeItemDTO tradeItemDTO = service.GetTradeItemByID(ID);
                tradeItemVM.Name = tradeItemDTO.Name;
                tradeItemVM.Quantity = tradeItemDTO.Quantity;
                tradeItemVM.PricePerItem = tradeItemDTO.PricePerItem;
                tradeItemVM.SellerID = tradeItemDTO.SellerID;
                tradeItemVM.Rating = tradeItemDTO.Rating;
                tradeItemVM.FreeDelivery = tradeItemDTO.FreeDelivery;
            }
            return View(tradeItemVM);
        }

        [HttpPost]
        public ActionResult Edit(TradeItemVM tradeItemVM)
        {
            using (ServiceReference.Service1Client service = new ServiceReference.Service1Client())
            {
                TradeItemDTO tradeItemDTO = new TradeItemDTO
                {
                    ID = tradeItemVM.ID,
                    Name = tradeItemVM.Name,
                    Quantity = tradeItemVM.Quantity,
                    PricePerItem = tradeItemVM.PricePerItem,
                    SellerID = tradeItemVM.SellerID,
                    Rating = tradeItemVM.Rating,
                    FreeDelivery = tradeItemVM.FreeDelivery
                };
                service.PutTradeItems(tradeItemDTO);
            }
            return RedirectToAction("Index");
        }
    }
}