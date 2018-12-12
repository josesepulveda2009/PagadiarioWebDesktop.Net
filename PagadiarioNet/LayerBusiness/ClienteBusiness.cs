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
    public class ClienteBusiness : IClienteBusiness
    {
        ClienteData clienteData;
        Cliente cliente;

        public List<Cliente> BuscarCliente(Cliente cliente, string campo, string valor)
        {
            clienteData = new ClienteData();

            return clienteData.BuscarCliente(cliente, campo, valor);
        }

        public List<Cliente> GetClientes()
        {
            clienteData = new ClienteData();

            return clienteData.GetClientes();
        }

        public int InsertCliente(Cliente cliente)
        {
            clienteData = new ClienteData();

            return clienteData.InsertCliente(cliente);
        }

        public int UpdateCliente(Cliente cliente)
        {
            clienteData = new ClienteData();

            return clienteData.UpdateCliente(cliente);
        }     

    }//end class        
}//end namespace
