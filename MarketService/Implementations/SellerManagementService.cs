using Data.Context;
using Data.Context.Entities;
using MarketService.DTOs;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketService.Implementations
{
    public class SellerManagementService
    {
        private MarketSystemDBContext ctx = new MarketSystemDBContext();

        public List<SellerDTO> Get(string filter)
        {
            List<SellerDTO> SellerDto = new List<SellerDTO>();
            //using (UnitOfWork unitOfWork = new UnitOfWork())
            //{
            //    foreach (var item in unitOfWork.SellerRepository.Get())
            //    {
            //           SellerDto.Add(new SellerDTO
            //            {
            //                ID = item.ID,
            //               Name = item.Name,
            //                Address = item.Address,
            //                Country = item.Country,
            //                TotalQuantitySold = item.TotalQuantitySold,
            //                Profit = item.Profit,
            //                PremiumAccount = item.PremiumAccount
            //        
            //            });
            //    }
            //}
                foreach (var item in ctx.Sellers.ToList().Where(x => x.Name.Contains(filter)))
                {
                   SellerDto.Add(new SellerDTO
                    {
                        ID = item.ID,
                        Name = item.Name,
                        Address = item.Address,
                        Country = item.Country,
                        TotalQuantitySold = item.TotalQuantitySold,
                        Profit = item.Profit,
                       PremiumAccount = item.PremiumAccount
                
                    });
                }
            return SellerDto;
        }

        public bool Save(SellerDTO SellerDTO)
        {
            Seller Seller = new Seller
            {
                //ID = SellerDTO.ID,
                Name = SellerDTO.Name,
                Address = SellerDTO.Address,
                Country = SellerDTO.Country,
                TotalQuantitySold = SellerDTO.TotalQuantitySold,
                Profit = SellerDTO.Profit,
                PremiumAccount = SellerDTO.PremiumAccount
            };
            try
            {
                ctx.Sellers.Add(Seller);
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
                Seller Seller = ctx.Sellers.Find(ID);
                ctx.Sellers.Remove(Seller);
                ctx.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public SellerDTO GetByID(int ID)
        {
            Seller seller = ctx.Sellers.Where(x => ID == x.ID).FirstOrDefault();
            SellerDTO sellerDTO = new SellerDTO
            {
                ID = seller.ID,
                Name = seller.Name,
                Address = seller.Address,
                Country = seller.Country,
                TotalQuantitySold = seller.TotalQuantitySold,
                Profit = seller.Profit,
                PremiumAccount = seller.PremiumAccount
            };
            return sellerDTO;
        }

        public bool Edit(SellerDTO sellerDTO)
        {
            Seller seller = new Seller
            {
                ID = sellerDTO.ID,
                Name = sellerDTO.Name,
                Address = sellerDTO.Address,
                Country = sellerDTO.Country,
                TotalQuantitySold = sellerDTO.TotalQuantitySold,
                Profit = sellerDTO.Profit,
                PremiumAccount = sellerDTO.PremiumAccount
            };
            try
            {
                ctx.Sellers.Attach(seller);
                ctx.Entry(seller).State = EntityState.Modified;
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
