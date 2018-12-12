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
    public interface IClienteBusiness
    {
        [OperationContract]
        List<Cliente> GetClientes();

        [OperationContract]
        int InsertCliente(Cliente cliente);

        [OperationContract]
        int UpdateCliente(Cliente cliente);

        [OperationContract]
        List<Cliente> BuscarCliente(Cliente cliente, string campo, string valor);
    }    
}
