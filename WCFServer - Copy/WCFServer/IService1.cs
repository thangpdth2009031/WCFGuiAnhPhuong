using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WCFServer.Entity;

namespace WCFServer
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        Product Save(Product product);
        [OperationContract]
        Product Edit(Product product);
        [OperationContract]
        Product EditPrd(int id);
        [OperationContract]
        Product DeleteFind(int id);
        [OperationContract]
        Product Delete(int id);
        [OperationContract]
        List<Product> GetList();

    }
}
