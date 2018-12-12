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

    public class ClienteData
    {
        SqlConnection conexion;
        SqlCommand comando;
        SqlDataReader lector;
               
        public List<Cliente> GetClientes()
        {
            List<Cliente> clientes = new List<Cliente>();

            using (conexion = new SqlConnection(Conexion.Conectar()))
            {
                conexion.Open();

                using (comando = new SqlCommand("select * from Cliente", conexion))
                {
                    lector = comando.ExecuteReader();
                    
                    while (lector.Read())
                    {
                        Cliente clientex = new Cliente()
                        {
                            Cedula = Convert.ToString(lector["cedula"]),
                            Apellidos = Convert.ToString(lector["apellidos"]),
                            Nombres = Convert.ToString(lector["nombres"]),
                            Telefono = Convert.ToString(lector["telefono"]),
                            Celular = Convert.ToString(lector["celular"]),
                            Direccion = Convert.ToString(lector["direccion"]),
                            Id = Convert.ToUInt16(lector["id"]),
                            Notas = Convert.ToString(lector["notas"]),
                            Activo = Convert.ToBoolean(lector["activo"]),
                            Img = Convert.ToString(lector["img"])
                        };

                        clientes.Add(clientex);
                    }
                }
            }
            return clientes;
        }
        
        public int InsertCliente(Cliente cliente)
        {
            int i;
            using (conexion = new SqlConnection(Conexion.Conectar()))
            {
                conexion.Open();

                using (comando = new SqlCommand("insert into Cliente(cedula, apellidos, nombres, telefono, celular, direccion, notas, usuario, activo, img) values(@cedula, @apellidos, @nombres, @telefono, @celular, @direccion, @notas, @usuario, @activo, @img)", conexion))
                {
                    comando.Parameters.AddWithValue("@CEDULA", cliente.Cedula);
                    comando.Parameters.AddWithValue("@APELLIDOS", cliente.Apellidos);
                    comando.Parameters.AddWithValue("@NOMBRES", cliente.Nombres);
                    comando.Parameters.AddWithValue("@TELEFONO", cliente.Telefono);
                    comando.Parameters.AddWithValue("@CELULAR", cliente.Celular);
                    comando.Parameters.AddWithValue("@DIRECCION", cliente.Direccion);
                    comando.Parameters.AddWithValue("@NOTAS", cliente.Notas);
                    comando.Parameters.AddWithValue("@USUARIO", cliente.Usuario);
                    comando.Parameters.AddWithValue("@ACTIVO", cliente.Activo);
                    comando.Parameters.AddWithValue("IMG", cliente.Img);

                    i = comando.ExecuteNonQuery();
                }
            }
            return i; 
        }

        public int UpdateCliente(Cliente cliente)
        {
            int i;
            using (conexion = new SqlConnection(Conexion.Conectar()))
            {
                conexion.Open();

                using (comando = new SqlCommand("update Cliente set cedula=@cedula, apellidos=@apellidos, nombres=@nombres, telefono=@telefono, celular=@celular, direccion=@direccion, notas=@notas, activo=@activo, img=img where id=@id", conexion))
                {
                    comando.Parameters.AddWithValue("@CEDULA", cliente.Cedula);
                    comando.Parameters.AddWithValue("@APELLIDOS", cliente.Apellidos);
                    comando.Parameters.AddWithValue("@NOMBRES", cliente.Nombres);
                    comando.Parameters.AddWithValue("@TELEFONO", cliente.Telefono);
                    comando.Parameters.AddWithValue("@CELULAR", cliente.Celular);
                    comando.Parameters.AddWithValue("@DIRECCION", cliente.Direccion);
                    comando.Parameters.AddWithValue("@NOTAS", cliente.Notas);
                    comando.Parameters.AddWithValue("@ACTIVO", cliente.Activo);
                    comando.Parameters.AddWithValue("@ID", cliente.Id);
                    comando.Parameters.AddWithValue("IMG", cliente.Img);

                    i = comando.ExecuteNonQuery();
                }
            }
            return i;
        }

        public List<Cliente> BuscarCliente(Cliente cliente, string campo, string valor)
        {
            List<Cliente> clientes = new List<Cliente>();

            using (conexion = new SqlConnection(Conexion.Conectar()))
            {
                conexion.Open();

                if (campo == "cedula")
                {
                    comando = new SqlCommand("select * from Cliente where cedula like '%" + valor + "%'", conexion);
                }
                else if (campo == "apellidos")
                {
                    comando = new SqlCommand("select * from Cliente where apellidos like '%" + valor + "%'", conexion);
                }
                else if (campo == "nombres")
                {
                    comando = new SqlCommand("select * from Cliente where nombres like '%" + valor + "%'", conexion);
                }
                else if (campo == "telefono")
                {
                    comando = new SqlCommand("select * from Cliente where telefono like '%" + valor + "%'", conexion);
                }
                else if (campo == "celular")
                {
                    comando = new SqlCommand("select * from Cliente where celular like '%" + valor + "%'", conexion);
                }
                else if (campo == "direccion")
                {
                    comando = new SqlCommand("select * from Cliente where direccion like '%" + valor + "%'", conexion);
                }
                else if (campo == "notas")
                {
                    comando = new SqlCommand("select * from Cliente where notas like '%" + valor + "%'", conexion);
                }

                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Cliente clientex = new Cliente()
                    {
                        Cedula = Convert.ToString(lector["cedula"]),
                        Apellidos = Convert.ToString(lector["apellidos"]),
                        Nombres = Convert.ToString(lector["nombres"]),
                        Celular = Convert.ToString(lector["celular"]),
                        Direccion = Convert.ToString(lector["direccion"]),
                        Id = Convert.ToUInt16(lector["id"]),
                        Notas = Convert.ToString(lector["notas"]),
                        Activo = Convert.ToBoolean(lector["activo"])
                    };

                    clientes.Add(clientex);
                }
                
            }

            return clientes;            
        }

    }//end class
}//end namespace
