using System;

namespace Ask_anyone_reverse_number_byWell
{
    class Program
    {
        static void Main(string[] args)
        {
            char r = 's';
            Console.WriteLine("Digite um numero para encontrar o inverso dele:");
            while (r == 's')
            {
                Console.Write("Digite:");
                double n = double.Parse(Console.ReadLine());
                if (n == 0)
                {
                    Console.WriteLine("Zero não é possivel encontrar o inverso!");
                }
                else
                {
                    Console.WriteLine($"O inverso de {n} é: " + 1 / n);
                }
                Console.WriteLine("Deseja continuar? (s/n)");
                r = char.Parse(Console.ReadLine());
                Console.WriteLine();
            }
        }
    }
}//by Wellington Henrique Moreira Vitorino.
