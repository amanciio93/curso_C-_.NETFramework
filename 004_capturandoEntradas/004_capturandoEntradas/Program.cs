using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_capturandoEntradas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Capturar entradas do usuário;
            Console.Write("Informe o nome: ");
            string nome = Console.ReadLine(); //Captura e retorna o valor inserido e armazena na var nome;

            Console.WriteLine("O nome informado foi: " + nome);
        }
    }
}
