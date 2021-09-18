using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {

            /*1. Pedir dos números por consola y mostrar el resultado:
             *   a. Si son iguales muestro el cuadrado del número.
             *   b. Si el primero es divisible por el segundo, los resto, de lo contrario muestro solo el resto.
             *   c. si el resto es mayor a 3(tres ) informar por consola.
             */
            Console.WriteLine("Ingrese dos numeros:");
            Console.WriteLine("Numero 1:");
            float num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Numero 2:");
            float num2 = float.Parse(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine("El cuadrado del numero es: " + (Math.Pow(num1,2))); ;

            }
            if (num1 % num2 == 0)
            {
                Console.WriteLine("La resta de los numeros ingresados es: " + (num1 - num2)); ;
            }
            else if (num1 % num2 > 3)
            {
                Console.WriteLine("El resto es mayor a 3: " + (num1 % num2));
            }
            else
            {
                Console.WriteLine("El resto de los numeros ingresados es: " + (num1 % num2));
            }

            Console.ReadKey();
        }
    }
}
