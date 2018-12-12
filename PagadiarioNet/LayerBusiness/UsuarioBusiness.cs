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
    public class UsuarioBusiness : IUsuarioBusiness
    {
        UsuarioData usuarioData; 

        public bool Loguear(Usuario usuario)
        {
            usuarioData = new UsuarioData();

            return usuarioData.Loguear(usuario);
        }

    }//end class
}//end namespace
