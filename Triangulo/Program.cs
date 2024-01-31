using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lado1, lado2, lado3;

            Console.WriteLine("Insira o valor do primeiro lado do triângulo");
            lado1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor do segundo lado do triângulo");
            lado2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor do terceiro lado do triângulo");
            lado3 = int.Parse(Console.ReadLine());

            if (lado1 + lado2 > lado3 && lado1 + lado3 > 2 && lado2 + lado3 > lado1)
            {
                if (lado1 == lado2 && lado2 == lado3)
                {
                    Console.WriteLine("Seu triângulo é equilátero");
                }
                else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
                {
                    Console.WriteLine("Seu triângulo é isósceles");
                }
                else
                {
                    Console.WriteLine("Seu triângulo é escaleno");
                }
            }
            else
            {
                Console.WriteLine("Triângulo inválido");
            }

            Console.ReadKey();
        }
    }
}