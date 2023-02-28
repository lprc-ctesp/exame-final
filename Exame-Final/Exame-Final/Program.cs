using System;

class Program
{
    static void Main(string[] args)
    {
        double a, b, c, delta, raiz_qd, pos, neg;

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
                Console.WriteLine("Esta equação possui duas raízes distintas.");
                Console.ReadLine();
                raiz_qd = Math.Sqrt(delta);
                pos = (-b + raiz_qd) / (2 * a);
                neg = (-b - raiz_qd) / (2 * a);
                Console.WriteLine("Raiz Positiva" + pos);
                Console.ReadLine();
                Console.WriteLine("Raiz Negativa" + neg);
                Console.ReadLine();
            }
            else if (delta == 0)
            {
                Console.WriteLine("Esta equação possui uma raiz real.");
                Console.ReadLine();
                raiz_qd = Math.Sqrt(delta);
                pos = (-b + raiz_qd) / (2 * a);
                neg = (-b - raiz_qd) / (2 * a);
                Console.WriteLine("Raiz Positiva" + pos);
                Console.ReadLine();
                Console.WriteLine("Raiz Negativa" + neg);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Esta equação não possui raízes reais.");
                Console.ReadLine();

            }
        }
    }
}
