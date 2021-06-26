using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Context.Entities;

namespace MarketService.DTOs
{
    public class CustomerDTO
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string PrefferedPaymentType { get; set; }
        public float TotalSpent { get; set; }
        public int ProductsRated { get; set; }
        public int TradeItemID { get; set; }
        public TradeItemDTO TradeItem { get; set; }
        public string MostPurchasedProduct { get; set; }
        public bool PremiumAccount { get; set; }
    }
}
