using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace LuckyCatWcfService
{
    /// <summary>
    /// This class uses switch function to get corresponding discount.
    /// 
    /// Created by: Qing Ge
    /// </summary>
    public class Service1 : IService1
    {
        public double GetDiscount(string percentage)
        {
            double discount;
            switch (percentage)
            {
                case "Holiday Discount -20%":
                    discount = 0.8;
                    break;
                case "Old Customer -25%":
                    discount = 0.75;
                    break;
                case "Pay Cash -10%":
                    discount = 0.9;
                    break;
                default:
                    discount = 1;
                    break;
            }
            return discount;
        }
    }
}
