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
    public class CobradorData
    {
        SqlConnection conexion;
        SqlCommand comando;
        SqlDataReader lector;

        public List<Cobrador> GetCobrador()
        {
            List<Cobrador> cobradores = new List<Cobrador>();

            using (conexion = new SqlConnection(Conexion.Conectar()))
            {
                conexion.Open();

                using (comando = new SqlCommand("select * from Cobrador", conexion))
                {
                    lector = comando.ExecuteReader();

                    while (lector.Read())
                    {
                        Cobrador cobradorx = new Cobrador()
                        { 
                            Cobradorx = Convert.ToString(lector["cobrador"]),
                            Celular = Convert.ToString(lector["celular"]),
                            Zona = Convert.ToString(lector["zona"]),
                            Id = Convert.ToUInt16(lector["id"])
                            
                        };

                        cobradores.Add(cobradorx);
                    }
                }
            }
            return cobradores;
        }

        public int InsertCobrador(Cobrador cobrador)
        {
            int i;

            using (conexion = new SqlConnection(Conexion.Conectar()))
            {
                conexion.Open();

                using (comando = new SqlCommand("insert into cobrador(cobrador, celular, zona) values(@cobrador, @celular, @zona)", conexion))
                {   
                    comando.Parameters.AddWithValue("@COBRADOR", cobrador.Cobradorx);
                    comando.Parameters.AddWithValue("@CELULAR", cobrador.Celular);
                    comando.Parameters.AddWithValue("@ZONA", cobrador.Zona);
                    
                    i = comando.ExecuteNonQuery();
                }
            }

            return i;
        }

        public int UpdateCobrador(Cobrador cobrador)
        {
            int i;

            using (conexion = new SqlConnection(Conexion.Conectar()))
            {
                conexion.Open(); 

                using (comando = new SqlCommand("update cobrador set cobrador=@cobrador, celular=@celular, zona=@zona where id=@id", conexion))
                {
                    comando.Parameters.AddWithValue("@COBRADOR", cobrador.Cobradorx);
                    comando.Parameters.AddWithValue("@CELULAR", cobrador.Celular);
                    comando.Parameters.AddWithValue("@ZONA", cobrador.Zona);
                    comando.Parameters.AddWithValue("@ID", cobrador.Id);
                    i = comando.ExecuteNonQuery();
                }
            }

            return i; 
        }

    }//end class
}//end namespace
