using MarketService.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MarketMVC.ViewModels
{
    public class CustomerVM
    {
        public int ID { get; set; }

        [MaxLength(50)]
        [Required]
        public string Username { get; set; }

        [MaxLength(50)]
        [Required]
        public string PrefferedPaymentType { get; set; }

        [Required]
        public float TotalSpent { get; set; }

        [Required]
        public int ProductsRated { get; set; }

        [Required]
        public int TradeItemID { get; set; }

        public TradeItemVM TradeItem { get; set; }

        [MaxLength(50)]
        [Required]
        public string MostPurchasedProduct { get; set; }

        [Required]
        public bool PremiumAccount { get; set; }

        public CustomerVM()
        { }

        public CustomerVM(CustomerDTO CustomerDTO)
        {
            ID = CustomerDTO.ID;
            Username = CustomerDTO.Username;
            PrefferedPaymentType = CustomerDTO.PrefferedPaymentType;
            TotalSpent = CustomerDTO.TotalSpent;
            ProductsRated = CustomerDTO.ProductsRated;
            TradeItemID = CustomerDTO.TradeItemID;
            TradeItem = new TradeItemVM
            {
                ID = CustomerDTO.TradeItemID,
                Name = CustomerDTO.TradeItem.Name,
                Quantity = CustomerDTO.TradeItem.Quantity,
                PricePerItem = CustomerDTO.TradeItem.PricePerItem,
                Rating = CustomerDTO.TradeItem.Rating,
                FreeDelivery = CustomerDTO.TradeItem.FreeDelivery
            };
            MostPurchasedProduct = CustomerDTO.MostPurchasedProduct;
            PremiumAccount = CustomerDTO.PremiumAccount;
        }
    }
}