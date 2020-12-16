using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array");

            string[] nomes = new string[3];
            int[] idades = new int[3];

            for (var contador = 0; contador < 3; contador++) {
                Console.WriteLine($"Digite o {contador+1}º nome");
                nomes[contador] = Console.Readline();

                Console.WriteLine("Digite a idade");
                idades[contador] = int.Parse(Console.Readline());
            }

            Console.WriteLine("Nomes cadastrados:");
            
            for (var contador = 0; contador < 3; contador++) {
                Console.WriteLine("Nome: " +nomes[contador]);
                Console.WriteLine("Idade: " +idades[contador]);
            }

        }
    }
}
