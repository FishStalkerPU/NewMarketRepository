using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context.Entities
{
    public class Seller : BaseEntity
    {
        //-Name string 50
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        //-Address string 50
        [Required]
        [MaxLength(50)]
        public string Address { get; set; }

        //-Country string 50
        [Required]
        [MaxLength(50)]
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
    }
}
