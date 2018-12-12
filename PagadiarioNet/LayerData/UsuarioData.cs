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
    public class UsuarioData
    {
        SqlConnection conexion;
        SqlCommand comando; 

        public bool Loguear(Usuario usuario)
        {
            int i; 

            using (conexion = new SqlConnection(Conexion.Conectar()))
            {
                conexion.Open();

                string sql = "select COUNT(*) from Usuario where usuario= '" + usuario.Usuariox + "' and contraseña = '" + usuario.Contraseña + "' ";

                using (comando = new SqlCommand(sql, conexion))
                {
                    comando = conexion.CreateCommand();
                    comando.CommandText = sql; 

                    i = Convert.ToInt16(comando.ExecuteScalar());
                }

                if (i == 0)
                {
                    return false;
                }
                else
                {
                    return true; 
                }
            }
        }

    }//end class
}//end namespace
