using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio_Dolar
{
    internal class ConversorDeMoeda
    {
        public static double cotacao;

        public static double IOF = 6.0;
        
        public static double Conversor(double quantia, double cotacao)
        {
            double total = quantia * cotacao;
            return total + total * IOF / 100.0;
        }
    }
}
