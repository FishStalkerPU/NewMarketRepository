using Data.Context;
using Data.Context.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Implementations
{
    public class UnitOfWork : IDisposable
    {
        private MarketSystemDBContext context = new MarketSystemDBContext();
        private GenericRepository<TradeItem> tradeItemRepository;
        private GenericRepository<Seller> sellerRepository;
        private GenericRepository<Customer> customerRepository;

        public GenericRepository<TradeItem> TradeItemRepository
        {
            get
            {

                if (this.tradeItemRepository == null)
                {
                    this.tradeItemRepository = new GenericRepository<TradeItem>(context);
                }
                return tradeItemRepository;
            }
        }

        public GenericRepository<Seller> SellerRepository
        {
            get
            {

                if (this.sellerRepository == null)
                {
                    this.sellerRepository = new GenericRepository<Seller>(context);
                }
                return sellerRepository;
            }
        }

        public GenericRepository<Customer> CustomerRepository
        {
            get
            {

                if (this.customerRepository == null)
                {
                    this.customerRepository = new GenericRepository<Customer>(context);
                }
                return customerRepository;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
