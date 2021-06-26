using MarketMVC.ViewModels;
using MarketService.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MarketMVC.Controllers
{
    public class SellerController : Controller
    {
        // GET: Seller
        public ActionResult Index(string Search_Data = "")
        {
            List<SellerVM> SellerVMs = new List<SellerVM>();
            using (ServiceReference.Service1Client service = new ServiceReference.Service1Client())
            {
                foreach (var item in service.GetSellers(Search_Data))
                {
                    SellerVMs.Add(new SellerVM(item));
                }
            }
                return View(SellerVMs);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SellerVM sellerVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (ServiceReference.Service1Client service = new ServiceReference.Service1Client())
                    {
                        SellerDTO SellerDto = new SellerDTO
                        {
                            Name = sellerVM.Name,
                            Address = sellerVM.Address,
                            Country = sellerVM.Country,
                            TotalQuantitySold = sellerVM.TotalQuantitySold,
                            Profit = sellerVM.Profit,
                            PremiumAccount = sellerVM.PremiumAccount
                        };
                        service.PostSeller(SellerDto);
                        return RedirectToAction("Index");
                    }
                }
                return View();
            }
            catch
            {
                return View();
            }
            
        }

        public ActionResult Delete(int id)
        {
            using (ServiceReference.Service1Client service = new ServiceReference.Service1Client())
            {
                service.DeleteSeller(id);
            }
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int ID)
        {
            SellerVM sellerVM = new SellerVM();
            using (ServiceReference.Service1Client service = new ServiceReference.Service1Client())
            {
                SellerDTO sellerDTO = service.GetSellerByID(ID);
                sellerVM.Name = sellerDTO.Name;
                sellerVM.Address = sellerDTO.Address;
                sellerVM.Country = sellerDTO.Country;
                sellerVM.TotalQuantitySold = sellerDTO.TotalQuantitySold;
                sellerVM.Profit = sellerDTO.Profit;
                sellerVM.PremiumAccount = sellerDTO.PremiumAccount;
            }
            return View(sellerVM);
        }

        [HttpPost]
        public ActionResult Edit(SellerVM sellerVM)
        {
            using (ServiceReference.Service1Client service = new ServiceReference.Service1Client())
            {
                SellerDTO sellerDTO = new SellerDTO
                {
                    ID = sellerVM.ID,
                    Name = sellerVM.Name,
                    Address = sellerVM.Address,
                    Country = sellerVM.Country,
                    TotalQuantitySold = sellerVM.TotalQuantitySold,
                    Profit = sellerVM.Profit,
                    PremiumAccount = sellerVM.PremiumAccount
                };
                service.PutSellers(sellerDTO);
            }
            return RedirectToAction("Index");
        }
    }
}