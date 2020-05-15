using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
				Console.WriteLine("*** Elija una opcion ***");
                Console.WriteLine("Ingrese primer numero:");
                int num1 = int.Parse(Console.ReadLine().Trim());
                Console.WriteLine("Ingrese segundo numero:");
                int num2 = int.Parse(Console.ReadLine().Trim());
                Console.WriteLine("1) suma \n2) resta \n3)multiplicacion \n4)division ");
                int respuesta = int.Parse(Console.ReadLine().Trim());
                 Console.WriteLine("la respuesta es: ");
                switch (respuesta)
                {
                    case 1:
                        Console.WriteLine("la suma es: "+ suma(num1, num2));
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("la resta es: " + Restar(num1, num2));
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("la multiplicacion es: " + multiplicacion(num1, num2));
                        Console.ReadLine();
                        break;
                    case 4:
                        Console.WriteLine("la division es: " + division(num1, num2));
                        Console.ReadLine();
                    break;
                    default:
                        Console.WriteLine("Selecciona una opción válida");
                    break;
                }            
        }

        public static int suma(int a, int b)
        {
            return a + b;
        }

        public static int Restar(int A, int B)
		{
			return A - B;
		}	
		
		public static double multiplicacion(double num1, double num2)
		{
			return num1 * num2;			
		}
		public static double division (double num1, double num2)
		{
     	 return num1 / num2;
		}
	
    }
}
