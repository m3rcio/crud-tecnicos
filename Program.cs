using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud_tecnicos
{
    internal class Program
    {
        struct estudante
        {
            public string nome;
            public int idade;
        }
        static void Main(string[] args)
        {
            estudante std1 = new estudante();
            Console.WriteLine("crud com struct");
            Console.WriteLine("prima 1 para criar valores");
            Console.WriteLine("prima 2 para atualizar ");
            Console.WriteLine("prima 3 para ler o valor");
            Console.WriteLine("prima 4 para apagar o valor");

            int processo = Convert.ToInt32(Console.ReadKey());
            Console.ReadKey();

        }
    }
}
