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
    public class CobradorBusiness : ICobradorBusiness
    {
        CobradorData cobradorData;
        Cobrador cobrador; 

        public List<Cobrador> GetCobrador()
        {
            cobradorData = new CobradorData();

            return cobradorData.GetCobrador();
        }

        public int InsertCobrador(Cobrador cobrador)
        {
            cobradorData = new CobradorData(); 

            return cobradorData.InsertCobrador(cobrador);
        }

        public int UpdateCobrador(Cobrador cobrador)
        {
            cobradorData = new CobradorData();

            return cobradorData.UpdateCobrador(cobrador);
        }

    }//end class
}//end namescape
