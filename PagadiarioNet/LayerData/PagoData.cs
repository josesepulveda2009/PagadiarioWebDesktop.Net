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
    public class PagoData
    {
        SqlConnection conexion;
        SqlCommand comando;
        SqlDataReader lector;
                
        public List<Pago> GetAbonos()
        {
            List<Pago> pagos = new List<Pago>();

            using (conexion = new SqlConnection(Conexion.Conectar()))
            {
                conexion.Open();

                using (comando = new SqlCommand("select * from Pago", conexion))
                {
                    lector = comando.ExecuteReader();

                    while (lector.Read())
                    {
                        Pago pagox = new Pago()
                        {
                            Numero = Convert.ToString(lector["numero"]),
                            Cantidad = Convert.ToDouble(lector["cantidad"]),
                            Fecha = Convert.ToDateTime(lector["fecha"]),
                            ProximoPago = Convert.ToDateTime(lector["proximoPago"]),
                            IdPrestamo = Convert.ToInt16(lector["idPrestamo"]),
                            IdCobrador = Convert.ToInt16(lector["idCobrador"]),
                            Id = Convert.ToInt16(lector["id"])
                        };

                        pagos.Add(pagox);
                    }
                }
            }
            return pagos;
        }

        public int Sp_pago(Pago pago)
        {
            int res;

            using (conexion = new SqlConnection(Conexion.Conectar()))
            {
                conexion.Open();

                using (comando = new SqlCommand("SP_PAGO", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@OPCION", pago.Opcion);
                    comando.Parameters.AddWithValue("@NUMERO", pago.Numero);
                    comando.Parameters.AddWithValue("CANTIDAD", pago.Cantidad);
                    comando.Parameters.AddWithValue("FECHA", pago.Fecha);
                    comando.Parameters.AddWithValue("PROXIMOPAGO", pago.ProximoPago);
                    comando.Parameters.AddWithValue("IDPRESTAMO", pago.IdPrestamo);
                    comando.Parameters.AddWithValue("IDCOBRADOR", pago.IdCobrador);                    
                    comando.Parameters.AddWithValue("@ID", pago.Id);
                    res = comando.ExecuteNonQuery();
                }
            }

            return res;
        }

    }//end class
}//end namespace
