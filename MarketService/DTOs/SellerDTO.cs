using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketService.DTOs
{
    public class SellerDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public int TotalQuantitySold { get; set; }
        public float Profit { get; set; }
        public bool PremiumAccount { get; set; }
    }
}
