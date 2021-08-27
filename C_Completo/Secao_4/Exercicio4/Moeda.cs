using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    static class Moeda
    {
        public static double Iof = 6;

        public static double ConversaoReal(double cotacao, double qtdeDolar)
        {
            return qtdeDolar * (1 + (Iof / 100)) * cotacao;
        }
    }
}
