using MarketService.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.ViewModels
{
    public class SellerVM
    {
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        //-Address string 50
        [Required]
        public string Address { get; set; }

        //-Country string 50
        [Required]
        public string Country { get; set; }

        //-TotalQuantitySold int
        [Required]
        public int TotalQuantitySold { get; set; }

        //-Profit float
        [Required]
        public float Profit { get; set; }

        //-PremiumAccount bool
        [Required]
        public bool PremiumAccount { get; set; }

        public SellerVM() {}

        public SellerVM(SellerDTO SellerDTO)
        {
            ID = SellerDTO.ID;
            Name = SellerDTO.Name;
            Address = SellerDTO.Address;
            Country = SellerDTO.Country;
            TotalQuantitySold = SellerDTO.TotalQuantitySold;
            Profit = SellerDTO.Profit;
            PremiumAccount = SellerDTO.PremiumAccount;
        }
    }
}