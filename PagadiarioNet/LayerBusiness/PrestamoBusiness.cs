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
    public class PrestamoBusiness : IPrestamoBusiness
    {
        PrestamoData prestamoData; 

        public List<Prestamo> GetPrestamos()
        {
            prestamoData = new PrestamoData();

            return prestamoData.GetPrestamos(); 
        }

        public int Sp_prestamo(Prestamo prestamo)
        {
            prestamoData = new PrestamoData();

            return prestamoData.Sp_prestamo(prestamo);
        }

    }//end class
}//end namespace
