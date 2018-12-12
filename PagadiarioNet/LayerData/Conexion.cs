using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerData
{
    public class Conexion
    {
        static string cnn; 

        public static string Conectar()
        {
            cnn = @"Server=.; Initial Catalog=pagadiario; Integrated Security=True;";
            //cnn = @"Server=.\SQLEXPRESS; Initial Catalog=pagadiario; User ID=sa; Password=chmod-rwx";
            return cnn;
        }
    }
}
