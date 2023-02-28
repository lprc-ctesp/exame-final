using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exame_Final
{
    public class Equacao
    {

     //  int[] myNum = { 10, 20, 30, 40 };

        public double a, b, c, beta;
        public double X, X2, rqd;


        public Equacao(double a, double b, double c) 
        { 
            this.a = a;
            this.b = b;
            this.c = c;
          //this.beta= beta;
        
        }


      public void CalcularEquacao()

        {
            Console.WriteLine("Introduza o valor de A");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de B:");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de C:");
            c = double.Parse(Console.ReadLine());


            if (a == 0) 
            {
                Console.WriteLine("O valor introduzido indica que não é uma equação de 2º grau");
                Console.ReadLine();


            }
            else if (a != 0) { 
            
                Console.WriteLine("O valor introduzido indica que é uma equação de 2º grau");
            
                Console.WriteLine("");
                if (a > 0 ) 
                {
                    Console.WriteLine("É uma função crescente");
                   
                    Console.WriteLine("");
                }
                else if (a < 0)
                {
                    Console.WriteLine("É uma função crescente");
                    
                    Console.WriteLine("");
                }

                beta = b * b - 4 * a * c;

                Console.WriteLine("Introduza o Beta");
                beta = double.Parse(Console.ReadLine());


                if (beta > 0)
                {
                    
                    Console.WriteLine("Esta equação possui duas raízes distintas.");
                    Console.ReadLine();
                    rqd = Math.Sqrt(beta);
                    X = (-b + rqd) / (2 * a);
                    X2 = (-b -rqd) / (2 * a);
                    Console.WriteLine("x1 = " + X);
                    Console.ReadLine();
                    Console.WriteLine("x2 = " + X2 );
                    Console.ReadLine();


                }
                else if (beta == 0)
                {
                    Console.WriteLine("Esta equação possui uma raiz real.");
                    Console.ReadLine();
                    rqd = Math.Sqrt(beta);
                    X = (-b + rqd) / (2 * a);
                    X2 = (-b - rqd) / (2 * a);
                    Console.WriteLine("x1 = " + X);
                    Console.ReadLine();
                    Console.WriteLine("x2 = " + X2);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Esta equação não possui raízes reais.");
                }

            }

        }
        

    }
}


/*  ´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´
 *  double a, b, c, delta;

        Console.WriteLine("Digite o valor de a:");
        a = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor de b:");
        b = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor de c:");
        c = double.Parse(Console.ReadLine());
''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''




        if (a == 0) {
            Console.WriteLine("Esta não é uma equação do segundo grau.");
        } else {
            Console.WriteLine("Esta é uma equação do segundo grau.");

            if (a > 0) {
                Console.WriteLine("Esta é uma função crescente.");
            } else {
                Console.WriteLine("Esta é uma função decrescente.");
            }

            delta = b*b - 4*a*c;

            if (delta > 0) {
                Console.WriteLine("Esta equação possui duas raízes distintas.");
            } else if (delta == 0) {
                Console.WriteLine("Esta equação possui uma raiz real.");
            } else {
                Console.WriteLine("Esta equação não possui raízes reais.");
            }*/
