using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaDeLinq.EL
{
    public class Usuario
    {
        private int id;
        private string nombre;
        private string apellido;
        private int edad;

        public int Id { get { return id; } }
        public string Nombre { get { return nombre; } }
        public string Apellido { get { return apellido; } }
        public int Edad { get { return edad; } }

        public Usuario(int pId, string pNombre, string pApellido, int pEdad)
        {
            id = pId;
            nombre = pNombre;
            apellido = pApellido;
            edad = pEdad;
        }
    }
}
