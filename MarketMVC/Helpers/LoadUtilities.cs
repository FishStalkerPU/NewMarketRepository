using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MarketMVC.Helpers
{
    public class LoadUtilities
    {
        public static SelectList LoadSellerData()
        {
            using (ServiceReference.Service1Client service = new ServiceReference.Service1Client())
            {
                return new SelectList(service.GetSellers(""), "Id", "Name");
            }
        }

        public static SelectList LoadTradeItemData()
        {
            using (ServiceReference.Service1Client service = new ServiceReference.Service1Client())
            {
                return new SelectList(service.GetTradeItems(""), "Id", "Name");
            }
        }

        public static SelectList LoadCustomerData()
        {
            using (ServiceReference.Service1Client service = new ServiceReference.Service1Client())
            {
                return new SelectList(service.GetCustomers(""), "Id", "Name");
            }
        }
    }
}