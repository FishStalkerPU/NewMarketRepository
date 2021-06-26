using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context.Entities
{
    public class TradeItem : BaseEntity
    {
        //-Name string 50
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        //-Quantity int
        [Required]
        public int Quantity { get; set; }

        //-PricePerItem float
        [Required]
        public float PricePerItem { get; set; }

        //-Seller Seller(foreign key)
        [Required]
        public int SellerID { get; set; }

        [ForeignKey("SellerID")]
        public  Seller Seller { get; set; }

        //-Rating float <=5
        [Required]
        public float Rating { get; set; }

        //-FreeDelivery Bool
        [Required]
        public bool FreeDelivery { get; set; }

    }
}
