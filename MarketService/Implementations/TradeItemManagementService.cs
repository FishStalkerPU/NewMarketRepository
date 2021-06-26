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
    public class TradeItemManagementService
    {
        private MarketSystemDBContext ctx = new MarketSystemDBContext();

        public List<TradeItemDTO> Get(string filter)
        {
            List<TradeItemDTO> TradeItemsDto = new List<TradeItemDTO>();
            var TradeItemList = ctx.TradeItems.Include(x => x.Seller).ToList();
            foreach (var item in TradeItemList.Where(x => x.Name.Contains(filter)))
            {
                TradeItemsDto.Add(new TradeItemDTO
                {
                    ID = item.ID,
                    Name = item.Name,
                    Quantity = item.Quantity,
                    PricePerItem = item.PricePerItem,
                    SellerID = item.SellerID,
                    Seller = new SellerDTO
                    {
                        ID = item.SellerID,
                        Name = item.Seller.Name,
                        Address = item.Seller.Address,
                        Country = item.Seller.Country,
                        TotalQuantitySold = item.Seller.TotalQuantitySold,
                        Profit = item.Seller.Profit,
                        PremiumAccount = item.Seller.PremiumAccount

                    },
                    Rating = item.Rating,
                    FreeDelivery = item.FreeDelivery

                });
            }
            return TradeItemsDto;
        }

        public bool Save(TradeItemDTO TradeItemDTO)
        {
            TradeItem TradeItem = new TradeItem
            {
                //ID = TradeItemDTO.ID,
                Name = TradeItemDTO.Name,
                Quantity = TradeItemDTO.Quantity,
                PricePerItem = TradeItemDTO.PricePerItem,
                SellerID = TradeItemDTO.SellerID,
                Rating = TradeItemDTO.Rating,
                FreeDelivery = TradeItemDTO.FreeDelivery
            };
            try
            {
                ctx.TradeItems.Add(TradeItem);
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
                TradeItem TradeItem = ctx.TradeItems.Find(ID);
                ctx.TradeItems.Remove(TradeItem);
                ctx.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public TradeItemDTO GetByID(int ID)
        {
            TradeItem tradeItem = ctx.TradeItems.Where(x => ID == x.ID).Include(x => x.Seller).FirstOrDefault();
            TradeItemDTO tradeItemDTO = new TradeItemDTO
            {
                ID = tradeItem.ID,
                Name = tradeItem.Name,
                Quantity = tradeItem.Quantity,
                PricePerItem = tradeItem.PricePerItem,
                SellerID = tradeItem.SellerID,
                Rating = tradeItem.Rating,
                FreeDelivery = tradeItem.FreeDelivery
            };
            return tradeItemDTO;
        }

        public bool Edit(TradeItemDTO tradeItemDTO)
        {
            TradeItem tradeItem = new TradeItem
            {
                ID = tradeItemDTO.ID,
                Name = tradeItemDTO.Name,
                Quantity = tradeItemDTO.Quantity,
                PricePerItem = tradeItemDTO.PricePerItem,
                SellerID = tradeItemDTO.SellerID,
                Rating = tradeItemDTO.Rating,
                FreeDelivery = tradeItemDTO.FreeDelivery
            };
            try
            {
                ctx.TradeItems.Attach(tradeItem);
                ctx.Entry(tradeItem).State = EntityState.Modified;
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
