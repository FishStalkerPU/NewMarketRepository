using MarketService.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MarketMVC.ViewModels
{
    public class TradeItemVM
    {
        public int ID { get; set; }

        [MaxLength(50)]
        [Required]
        public string Name { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public float PricePerItem { get; set; }

        [Required]
        public int SellerID { get; set; }

        public SellerVM Seller { get; set; }

        [Required]
        public float Rating { get; set; }

        [Required]
        public bool FreeDelivery { get; set; }

        public TradeItemVM()
        {

        }

        public TradeItemVM(TradeItemDTO TradeItemDTO)
        {
            ID = TradeItemDTO.ID;
            Name = TradeItemDTO.Name;
            Quantity = TradeItemDTO.Quantity;
            PricePerItem = TradeItemDTO.PricePerItem;
            SellerID = TradeItemDTO.SellerID;
            Seller = new SellerVM
            {
                ID = TradeItemDTO.SellerID,
                Name = TradeItemDTO.Seller.Name,
                Address = TradeItemDTO.Seller.Address,
                Country = TradeItemDTO.Seller.Country,
                TotalQuantitySold = TradeItemDTO.Seller.TotalQuantitySold,
                Profit = TradeItemDTO.Seller.Profit,
                PremiumAccount = TradeItemDTO.Seller.PremiumAccount

            };
            Rating = TradeItemDTO.Rating;
            FreeDelivery = TradeItemDTO.FreeDelivery;
        }
    }
}