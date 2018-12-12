using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Pago
    {
        public int Opcion { get; set; }
        public string Numero { get; set; }
        public double Cantidad { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime ProximoPago { get; set; }
        public int IdPrestamo { get; set; }
        public int IdCobrador { get; set; }
        public int Id { get; set; }
    }
}
