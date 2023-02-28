using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exame_Final
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Introduzir os valores dos coeficientes a, b e c da equação do segundo grau:");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            
            double delta = b * b - 4 * a * c;

            
            if (delta > 0)
            {
                
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                
                Console.WriteLine("A equação tem duas raízes reais distintas:");
                Console.WriteLine("x1 = " + x1);
                Console.WriteLine("x2 = " + x2);
            }
            else if (delta == 0)
            {
                
                double x = -b / (2 * a);

                
                Console.WriteLine("A equação tem uma raiz real única:");
                Console.WriteLine("x = " + x);
            }
            else
            {
                
                Console.WriteLine("A equação não tem solução real.");
            }
        }
    }
}

