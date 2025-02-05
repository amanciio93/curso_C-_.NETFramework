using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;

namespace _002_variaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            // Declarando variáveis;
            // A-Z a-z | 0 - 9 | @, $, _, e camelCase;
            // Int = inteiro| Float = real | Bool = Verdadeiro ou Falso | String = tipo textual | Char = caractere;
            var meuTexto = "Olá mundo!\n  \tJonathan Amancio";
            int anoNascimento = 1993;
            string cor_favorita = "Cinza escuro";
            float peso = 95.5f;
            bool carteiraAssinada = true;
            char sexo = 'M';

            Console.WriteLine("### Trabalhando com variáveis. ###");
            
            //Exibindo o valor da variáve;
            Console.WriteLine(meuTexto);
            Console.WriteLine("\tNascimento " + anoNascimento);
            Console.WriteLine("\tCor favorita: " + cor_favorita);
            Console.WriteLine("\tPeso: " + peso);
            Console.WriteLine("\tCLT: " + carteiraAssinada);
            Console.WriteLine("\tSexo: " + sexo);

            //Alterando o valor de uma variável;
            carteiraAssinada = false;
            Console.WriteLine("\n\tCLT: " + carteiraAssinada);
            */

            //Outras maneiras de declarar variáveis.
            //Ocultar o tipo de dado, C# vai identificar automaticamente o tipo;
            var nome = "Jonathan";
            var altura = 1.85;
            Console.WriteLine(nome);
            Console.WriteLine(altura);

            //Tipagem dinamica. Permite alterar o TIPO da variável na execução do programa;
            dynamic carro = "Citroen C3";
            Console.WriteLine(carro);
            carro = 2025;
            Console.WriteLine(carro);
        }
    }
}
