using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _007_operadores_logicos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // && Operador and;
            // || Operador or;

            int idade = 17;
            char sexo = 'm';

            if (sexo == 'm' && idade >= 18)
            {
                Console.WriteLine("Já deve se alistar!");
            }
            else if (sexo == 'f' && idade >= 18)
            {
                Console.WriteLine("Alistamento opcional!");
            } else if ((sexo == 'm' || sexo == 'f') && idade < 18) {
                Console.WriteLine("Parabéns pelo interesse!");
            }
            else if (sexo != 'm' && sexo != 'f') {
                Console.WriteLine("Sexo inexistente!");
            }
            else
            {
                Console.WriteLine("Ainda não tem idade para se alistar!");
            }

            
        }
    }
}
