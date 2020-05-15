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
				Console.writeln("*** Elija una opcion ***");
                Console.writeln("Ingrese primer numero");
                int num1 = (int)Console.readln().trim;
                Console.writeln("Ingrese segundo numero");
                int num2 = (int)Console.readln().trim;                
                Console.writeln("1) suma \n2) resta \n3)multiplicacion \n4)division ");
                int respuesta = (int)Console.readln().trim;
                Console.writeln("la respuesta es: ");

                switch (respuesta) {
                    case 1:
                        Console.writeln("la suma es: "+ suma(num1, num2)); 
                        break;
                    case 2:
                        Console.writeln("la resta es: " + Restar(num1, num2));                                                
                        break;
                    case 3:
                        Console.writeln("la multiplicacion es: " + multiplicacion(num1, num2));                                               
                        break;
                    case 4:
                        Console.writeln("la division es: " + division(num1, num2));                        
                        break;
                    default:
                        Console.writeln("Selecciona una opción válida");
                }
        }

        public int suma(int a, int b)
        {
            return a + b;
        }

        public int Restar(int A, int B)
		{
			return A - B;
		}	
		
		public double multiplicacion(double num1, double num2)
		{
			return num1 * num2;			
		}
		public double division (double num1, double num2)
		{
     	 return num1 / num2;
		}
	
    }
}
