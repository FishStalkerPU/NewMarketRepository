using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Context.Entities;

namespace MarketService.DTOs
{
    public class TradeItemDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public float PricePerItem { get; set; }
        public int SellerID { get; set; }
        public SellerDTO Seller { get; set; }
        public float Rating { get; set; }
        public bool FreeDelivery { get; set; }
    }
}
