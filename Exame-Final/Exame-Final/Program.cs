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

            int a = 0;
            int b = 0;
            int c = 0;

            float Delta = 0;

            
            double x1 = 0; 
            double x2 = 0;

           Console.WriteLine("Escrever valores de a,b e c.");
           
           Console.WriteLine("Escreva valor de a:");
            a =  Convert.ToInt16( Console.ReadLine());

           Console.WriteLine("Escreva valor de b:");
            b = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Escreva valor de c:");
            c = Convert.ToInt16(Console.ReadLine());


            if (a == 0)
           {
                Console.WriteLine("Não é uma equação de 2º grau");
           }
           else
            {
                Console.WriteLine("É uma equação de 2º grau");

                 if (a > 0)
                 {
                    Console.WriteLine("É uma função Crescente");
                 }
                 else if(a < 0)
                 {
                    Console.WriteLine("É uma função Decrescente");
                 }

                Delta = (b*b) - 4*(a*c);

                if (Delta > 0) 
                { 
                    Console.WriteLine("Duas raizes reais e distintas");
                    
                        x1 = (-b + Math.Sqrt(Delta))/ 2*a;
                        x2 = (-b - Math.Sqrt(Delta))/ 2*a;

                    Console.WriteLine("O valor de X1 é" + x1);
                    Console.WriteLine("O valor de X2 é" + x2);
                }
                else if (Delta == 0)
                {
                    Console.WriteLine("Uma raiz real");

                    x1 = (-b + Math.Sqrt(Delta))/ 2*a;

                    Console.WriteLine("O valor de X é", x1);
                }
                else if (Delta < 0)
                {
                    Console.WriteLine("Não possui raiz");
                }

               
              
            }
            Console.ReadKey();
        }  

       
    } 
}