using System;
using System.Collections.Generic;
using System.Text;

//
using PracticaDeLinq.EL;
using System.Linq;


namespace PracticaDeLinq.DAL
{
    public class UsuarioDAL
    {
        List<Usuario> Usuarios = new List<Usuario>
        {
            new Usuario(1, "Carlos", "Mendoza", 17),
            new Usuario(2, "Ulises", "Hernandez", 19),
            new Usuario(3, "Anges", "Hernandez", 21),
            new Usuario(4, "Cristhoper", "Mendez", 19),
            new Usuario(5, "Josseline", "Alegria", 18),
            new Usuario(6, "Carolina", "Fuentes", 20),
            new Usuario(7, "Wendy", "Montes", 16),
        };
        public List<Usuario> ObtenerUsuarios()
        {
            List<Usuario> usuarios = Usuarios;

            return usuarios;
        }

        public IEnumerable<Usuario> ObtenerUsuarioPorId(int id)
        {
            List<Usuario> usuarios = Usuarios;

            var usuarioId =
                from usuario in usuarios
                where usuario.Id == id
                select usuario;

            return usuarioId;
        }
    }
}
