using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Constantes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Contantes são como variáveis, porém, não mudam seu valor em nenhum momento;
            const int anoNasc = 1993;
            string nome = "Jonathan";

            Console.WriteLine("NOME: " + nome);
            Console.WriteLine("NASCIMENTO: " + anoNasc);

            nome = "Jonathan Amancio";
            // anoNasc = 1995; - Não é permitido alterar seu valor por ser constante;

            Console.WriteLine("NOME: " + nome);
            Console.WriteLine("NASCIMENTO: " + anoNasc);
        }
    }
}
