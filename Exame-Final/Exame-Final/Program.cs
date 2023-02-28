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
            double a, b, c, delta, rqd, x1, x2;

            Console.WriteLine("Digite o valor de a:");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de b:");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de c:");
            c = double.Parse(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine("Esta não é uma equação do segundo grau.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Esta é uma equação do segundo grau.");
                Console.ReadLine();

                if (a > 0)
                {
                    Console.WriteLine("Esta é uma função crescente.");
                    Console.ReadLine();

                }
                else
                {
                    Console.WriteLine("Esta é uma função decrescente.");
                    Console.ReadLine();

                }

                delta = b * b - 4 * a * c;

                if (delta > 0)
                {
                    Console.WriteLine("Esta equação possui duas raízes distintas e reais.");
                    Console.ReadLine();
                    rqd = Math.Sqrt(delta);
                    x1 = (-b + rqd) / (2 * a);
                    x2 = (-b - rqd) / (2 * a);
                    Console.WriteLine("x1 = " + x1);
                    Console.ReadLine();
                    Console.WriteLine("x2 = " + x2);
                    Console.ReadLine();

                }
                else if (delta == 0)
                {
                  
                    Console.WriteLine("Esta equação possui uma raiz real.");
                    Console.ReadLine();
                    rqd = Math.Sqrt(delta);
                    x1 = (-b + rqd) / (2 * a);
                    x2 = (-b - rqd) / (2 * a);
                    Console.WriteLine("x1 = " + x1);
                    Console.ReadLine();
                    Console.WriteLine("x2 = " + x2);
                    Console.ReadLine();


                }
                else
                {
                    Console.WriteLine("Esta equação não possui raízes.");
                    Console.ReadLine();

                }
            }

        }
    }
}


