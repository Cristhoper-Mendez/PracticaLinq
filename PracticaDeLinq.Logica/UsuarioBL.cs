using System;
using System.Collections.Generic;
using System.Text;

using System.Linq;
using PracticaDeLinq.DAL;
using PracticaDeLinq.EL;

namespace PracticaDeLinq.Logica
{
    public class UsuarioBL
    {
        UsuarioDAL usuarioDAL = new UsuarioDAL();
        public List<Usuario> ObtenerTodos()
        {
            var usuarios = usuarioDAL.ObtenerUsuarios();

            return usuarios;
        }

        public IEnumerable<Usuario> ObtenerMayores18()
        {
            var usuarios = usuarioDAL.ObtenerUsuarios();

            var usuariosMayores =
                from usuario in usuarios
                where usuario.Edad > 18
                select usuario;

            return usuariosMayores;

        }
    }
}
