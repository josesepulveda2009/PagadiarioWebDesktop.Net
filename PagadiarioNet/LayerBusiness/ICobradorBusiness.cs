using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using Entity;
using LayerData;

namespace LayerBusiness
{    
    [ServiceContract]
    public interface ICobradorBusiness
    {
        [OperationContract]
        List<Cobrador> GetCobrador();

        [OperationContract]
        int InsertCobrador(Cobrador cobrador);

        [OperationContract]
        int UpdateCobrador(Cobrador cobrador);
    }
}
