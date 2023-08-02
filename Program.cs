using System;

namespace C_Teste
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.Write("Entre com um numero entre 1 e 5: ");

            int num = Convert.ToInt32(Console.ReadLine());

            switch (num){
                case 1:
                    Console.WriteLine("Um");
                    break;
                case 2:
                    Console.WriteLine("Dois");
                    break;
                case 3:
                    Console.WriteLine("Tres");
                    break;
                case 4:
                    Console.WriteLine("Quatro");
                    break;
                case 5:
                    Console.WriteLine("Cinco");
                    break;
                default :
                    Console.WriteLine("Default");
                    break;
            }

            // Espera para fechar.
            Console.ReadKey();
        }
    }
}
