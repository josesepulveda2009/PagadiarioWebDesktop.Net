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
    public interface IPrestamoBusiness
    {
        [OperationContract]
        List<Prestamo> GetPrestamos();

        [OperationContract]
        int Sp_prestamo(Prestamo prestamo);
    }
}
