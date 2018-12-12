using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Prestamo
    {        
        public int Opcion { get; set; }
        public string Numero { get; set; }
        public DateTime Fecha { get; set; }
        public double Cantidad { get; set; }
        public double Interes { get; set; }
        public string FormaPago { get; set; }
        public DateTime fechaLimite { get; set; }
        public int IdCliente { get; set; }
        public int Id { get; set; }
        public double TotalPagar { get; set; }
    }
}
