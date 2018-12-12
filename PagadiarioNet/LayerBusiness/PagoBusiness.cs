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
    public class PagoBusiness : IPagoBusiness
    {
        PagoData pagoData; 

        public List<Pago> GetAbonos()
        {
            pagoData = new PagoData();

            return pagoData.GetAbonos(); 
        }

        public int Sp_pago(Pago pago)
        {
            pagoData = new PagoData();

            return pagoData.Sp_pago(pago);
        }

    }//end class
}//end namespace
