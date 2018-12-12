using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entity;
using System.Data;
using System.Data.SqlClient;

namespace LayerData
{
    public class PrestamoData
    {
        SqlConnection conexion;
        SqlCommand comando;
        SqlDataReader lector;

        public List<Prestamo> GetPrestamos()
        {
            List<Prestamo> prestamos = new List<Prestamo>();

            using (conexion = new SqlConnection(Conexion.Conectar()))
            {
                conexion.Open();

                using (comando = new SqlCommand("select * from Prestamo", conexion))
                {
                    lector = comando.ExecuteReader();

                    while (lector.Read())
                    {
                        Prestamo prestamox = new Prestamo()
                        {
                            Numero = Convert.ToString(lector["numero"]),
                            Fecha = Convert.ToDateTime(lector["fecha"]),
                            Cantidad = Convert.ToDouble(lector["cantidad"]),
                            Interes = Convert.ToDouble(lector["interes"]),
                            FormaPago = Convert.ToString(lector["formaPago"]),
                            fechaLimite = Convert.ToDateTime(lector["fechaLimite"]),
                            IdCliente = Convert.ToInt16(lector["idCliente"]),
                            Id = Convert.ToInt16(lector["id"]),
                            TotalPagar = Convert.ToDouble(lector["totalPagar"])
                        };

                        prestamos.Add(prestamox);
                    }
                }
            }
            return prestamos;
        }

        public int Sp_prestamo(Prestamo prestamo)
        {
            int res;

            using (conexion = new SqlConnection(Conexion.Conectar()))
            {
                conexion.Open();

                using (comando = new SqlCommand("SP_PRESTAMO", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@OPCION", prestamo.Opcion);
                    comando.Parameters.AddWithValue("@NUMERO", prestamo.Numero);
                    comando.Parameters.AddWithValue("@FECHA", prestamo.Fecha);
                    comando.Parameters.AddWithValue("@CANTIDAD", prestamo.Cantidad);
                    comando.Parameters.AddWithValue("@INTERES", prestamo.Interes);
                    comando.Parameters.AddWithValue("@FORMAPAGO", prestamo.FormaPago);
                    comando.Parameters.AddWithValue("@FECHALIMITE", prestamo.fechaLimite);
                    comando.Parameters.AddWithValue("@IDCLIENTE", prestamo.IdCliente);
                    comando.Parameters.AddWithValue("@ID", prestamo.Id);
                    res = comando.ExecuteNonQuery();
                }
            }

            return res;
        }
        
    }//end class
}//end namespace
