using System;
using System.Collections.Generic;
using System.Linq;

//
using PracticaDeLinq.EL;
using PracticaDeLinq.Logica;

namespace PracticaDeLinq.AppConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prueba con scores
            //ScoreBL scoreBL = new ScoreBL();
            //var scores = scoreBL.ScoresMayor6();

            //var scoresMayor6 =
            //    from score in scores
            //    where score > 6
            //    select score;

            //foreach (var i in scores)
            //{
            //    Console.WriteLine(i);
            //}

            // Prueba con usuarios
            UsuarioBL usuarioBL = new UsuarioBL();

            // Filtrar mayores de 18
            //var usuariosMayores = usuarioBL.ObtenerMayores18();

            //foreach (var usuario in usuariosMayores)
            //{
            //    Console.WriteLine(usuario.Nombre);
            //}

            var usuario = usuarioBL.ObtenerPorId(2);

            foreach (var item in usuario)
            {
                Console.WriteLine(item.Nombre);
            }

        }
    }
}
