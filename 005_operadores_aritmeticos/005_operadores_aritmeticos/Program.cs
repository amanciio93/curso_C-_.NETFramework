using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_operadores_aritmeticos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Operadores aritméticos:
            
                + SOMA;
                - SUBTRAÇÃO;
                * MULTIPLICAÇÃO;
                / DIVISÃO;

                Precedência de operadores:
                * e /
                + e -
                Da esquerda para direita e de cima para baixo;
             
             */

            int soma = 34 + 66;
            int sub = 100 - 37;
            int mult = 10 * 3;
            //Divisão com resultado tipo int;
            int div = 100 / 5;
            //Boa prática é realizar divisões e armazenar o resultado em variáveis float;
            float divf = 50f / 3f;

            Console.WriteLine(soma);
            Console.WriteLine(sub);
            Console.WriteLine(mult);
            Console.WriteLine(div);
            Console.WriteLine(divf);

            int somaPrecedencia = 10 + 4 * 8 + 3 - 9 / 3 + 8; // 50
            Console.WriteLine(somaPrecedencia);
            // Se eu quiser priorizar alguma operação eu a envolvo entre parenteses ();
            int somaPrecedencia2 = 10 + (4 * 8) + 3 - 9 / 3 + 8; // 
            Console.WriteLine(somaPrecedencia2); 
        }
    }
}
