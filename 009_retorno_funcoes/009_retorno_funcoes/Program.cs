using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_retorno_funcoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exibindo o return dentro da função WriteLine();
            Console.WriteLine(somar(1, 2, 3));

            //Outra maneira de exibir o retorno é armazendo ele em variaveis;
            int soma1 = somar(2, 2, 2);
            int soma2 = somar(2, 4, 6);
            int soma3 = somar(5, 5, 5);
            Console.WriteLine(soma1);
            Console.WriteLine(soma2);
            Console.WriteLine(soma3);

            Console.ReadLine();

        }

        //Void = Função vazia, sem retorno;
        static int somar(int a, int b, int c) {
            int resultadoFinal = a + b + c;
            //return = Retorna a chamada da função o parametro resultadoFinal;
            return resultadoFinal;
        }
    }
}
