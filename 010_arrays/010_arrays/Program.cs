using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] produtos = new string[5] {
                "Gran Turismo", //0
                "Need for speed", //1
                "Counter Strike", //2
                "GTA SanAndreas", //3
                "TribalWars" //4
            };

            Console.WriteLine(produtos[0]);
            Console.WriteLine(produtos[1]);
            Console.WriteLine(produtos[2]);
            Console.WriteLine(produtos[3]);
            Console.WriteLine(produtos[4]);

            //Alterando um valor dentro do Array;
            produtos[3] = "GTA VI";
            Console.WriteLine(produtos[3]);

        }
    }
}
