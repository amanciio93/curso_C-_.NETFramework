using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_condicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Condicionais:
                    > Maior
                    < Menor
                    >= Maior ou igual
                    <= Menor ou igual
                    == Igual
                    != Diferente             
             */

            int idade = 18;

            if (idade > 18)
            {
                Console.WriteLine("maioridade");
            }
            else if (idade < 18) {
                Console.WriteLine("menoridade");
            }
            else {
                Console.WriteLine("Tem 18 anos.");
            }
        }
    }
}
