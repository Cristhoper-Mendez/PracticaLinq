using System;
using System.Collections.Generic;
using System.Text;

//
using System.Linq;

namespace PracticaDeLinq.Logica
{
    public class ScoreBL
    {
        // fuente de datos
        int[] scores = new int[] { 1, 3, 5, 6, 7, 8, 9, 8, 6 };

        public int[] ObtenerScores()
        {
            return scores;
        }

        public IEnumerable<int> ScoresMayor6()
        {
            IEnumerable<int> scoreQuery =
                from score in scores
                where score > 6
                select score;

            return scoreQuery;
        }
    }
}
