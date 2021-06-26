using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context.Entities
{
    public class Customer : BaseEntity
    {
        //-Username string 50
        [Required]
        [MaxLength(50)]
        public string Username { get; set; }

        //-PrefferedPaymentType string 50
        [Required]
        [MaxLength(50)]
        public string PrefferedPaymentType { get; set; }

        //-TotalSpent float
        [Required]
        public float TotalSpent { get; set; }

        //-ProductsRated int 
        [Required]
        public int ProductsRated { get; set; }

        //-MostPurchasedProduct TradeItem? (foreign key)
        [Required]
        public int TradeItemID { get; set; }

        [ForeignKey("TradeItemID")]
        public TradeItem TradeItem { get; set; }

        [Required]
        [MaxLength(50)]
        public string MostPurchasedProduct { get; set; }

        //-PremiumAccount Bool
        [Required]
        public bool PremiumAccount { get; set; }
    }
}
