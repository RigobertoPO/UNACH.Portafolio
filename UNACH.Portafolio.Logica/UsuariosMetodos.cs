using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNACH.Portafolio.Datos;

namespace UNACH.Portafolio.Logica
{
    public class UsuariosMetodos
    {
        public Usuario ValidarUsuario(string nickname,string password)
        {
            using(var conexion = new PortafolioEntities())
            {
                var consulta = (from u in conexion.Usuarios
                                where u.Nickname == nickname &&
                                u.Password == password
                                select u).FirstOrDefault();
                return consulta;
            }
        }
    }
}
