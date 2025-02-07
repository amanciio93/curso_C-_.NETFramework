using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_funcoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Executando a função declarada;
            mostraNome();
            gerarPreco("Garrafa Stanley", 55); // 55 é o parametro;
        }

        //Declarando funções - Devem ser declaradas dentro do internal class Program;
        //static + retorno + nome da função
        static void mostraNome() {
            Console.WriteLine("Jonathan Amancio");
        }

        //Passando parametros e argumentos;
        static void gerarPreco(string nome, int preco) { // "int preco" recebe o argumento que é o valor enviado pelo parametro preco na chamada da função;
            Console.WriteLine("Nome do produto: " + nome);
            Console.WriteLine("Preço: " + preco);
        }

    }
}
