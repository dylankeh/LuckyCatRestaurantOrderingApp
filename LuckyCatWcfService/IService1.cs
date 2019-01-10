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
    /// This web service receives a string type 'percentage' and return a double type 'discount'
    /// 
    /// Created by: Qing Ge
    /// </summary>
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        double GetDiscount(string percentage);
       
    }
    
}
