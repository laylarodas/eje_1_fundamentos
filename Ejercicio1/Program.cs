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
            float resto = num1 % num2;

            if (num1 == num2)
            {
                Console.WriteLine("Los numeros ingresados son iguales. El cuadrado del numero es: " + (Math.Pow(num1,2))); ;

            }else if (resto == 0)
            {
                Console.WriteLine("El numero {0} es divisible por {1}, el resto es {2}. La resta de los numeros ingresados es: {3} ",num1,num2,resto, (num1 - num2)); ;
            }
            else if (resto != 0 && resto < 3)
            {
                Console.WriteLine("El resto de los numeros ingresados es: " + resto);
            }
            else
            {
                Console.WriteLine("El resto es mayor a 3: " + resto);
            }

            Console.ReadKey();
        }
    }
}
