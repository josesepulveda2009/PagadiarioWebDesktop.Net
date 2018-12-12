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
    public interface IPagoBusiness
    {
        [OperationContract]
        List<Pago> GetAbonos();

        [OperationContract]
        int Sp_pago(Pago pago);
    }
}
