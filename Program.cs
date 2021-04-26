using System;

namespace Exerc_cio_Bhaskara
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            double x1, x2, delta;
            bool valorValido;


            Console.WriteLine("Bhaskara");
            
            Console.Write("Digite o valor de a: ");
            valorValido = Double.TryParse(Console.ReadLine(), out a);


            if (a != 0)
            {
                Console.Write("Digite o valor de b: ");
                valorValido = Double.TryParse(Console.ReadLine(), out b);

                Console.Write("Digite o valor de c: ");
                valorValido = Double.TryParse(Console.ReadLine(), out c);

                delta = Math.Pow(b, 2) - (4 * a * c);


                if (delta > 0)
                {
                    double raizQuad = Math.Sqrt(delta);
                    Console.WriteLine($"\ndelta = {delta} A sua Raiz Quadrada é {raizQuad:N1} ");

                    x1 = (((b * (-1)) + raizQuad) / (2 * a));

                    Console.WriteLine($"\n X1 = {x1:N1}");
                    x2 = (((b * (-1)) - raizQuad) / (2 * a));

                    Console.WriteLine($"X2 = {x2:N1}");
                }
                else
                {
                    Console.WriteLine("\n A equação não tem raízes reais");
                }
            }
            else
            {
                Console.WriteLine("\n Essa não é uma equação de segundo grau.");
            }
        }
    }
}
