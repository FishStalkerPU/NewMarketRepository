using Data.Context.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Data.Context
{
    public class MarketSystemDBContext : DbContext
    {
        public DbSet<TradeItem> TradeItems { get; set; }
        public DbSet<Seller> Sellers { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
