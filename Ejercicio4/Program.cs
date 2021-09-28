using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*4. Realizar el algoritmo que permita iterar el ingreso de dos datos de un vehiculo, un color (rojo verde o amarillo) y 
             *   un valor entre 0 y 10000 hasta que el usuario quiera e informar al terminar el ingreso por consola:
             *   a. La cantidad de rojos
             *   b. La cantidad de rojos con precio mayor a 5000
             *   c. La cantidad de vehículos con precio inferior a 5000
             *   d. El promedio de todos los vehículos ingresados.
             *   e. El más caro y su color.
             */

            string color;
            double valor;
            int cantRojos = 0;
            int cantRojosPrecioMayor = 0;
            int cantPrecioMenor = 0;
            int cantVehiculos = 0;
            double promedio,sumatoria = 0;
            string colorVehiculoCaro = " ";
            double max = double.MinValue;
            char opcion;

            do
            {
                do
                {
                    Console.WriteLine("Ingrese color del vehiculo: ");
                    color = Console.ReadLine();
                    if (color != "rojo" && color != "verde" && color != "amarillo")
                    {
                        Console.WriteLine("Color no valido (Opciones: rojo, verde, amarillo)");
                    }
                } while (color != "rojo" && color != "verde" && color != "amarillo");


                do
                {
                    Console.WriteLine("Ingrese valor del vehiculo: ");
                    valor = double.Parse(Console.ReadLine());
                    if ((valor < 0) || (valor > 10000))
                    {
                        Console.WriteLine("Error!! Ingrese un valor entre 0 a 10000");
                    }
                } while ((valor < 0) || (valor > 10000));


                if (color == "rojo")
                {
                    cantRojos++;
                }
                if (color == "rojo" && valor > 5000)
                {
                    cantRojosPrecioMayor++;
                }
                if (valor < 5000)
                {
                    cantPrecioMenor++;
                }

                if (max < valor)
                {
                    max = valor;
                    colorVehiculoCaro = color;
                }

                sumatoria += valor;
                cantVehiculos++;

                Console.WriteLine("Desea ingresar mas datos? s/n");
                opcion = char.Parse(Console.ReadLine());
            } while (opcion != 'n');

            promedio = sumatoria / cantVehiculos;

            Console.WriteLine("Cantidad de vehiculos color rojo : {0}", cantRojos);
            Console.WriteLine("Cantidad de vehiculos color rojo con valor mayor a 5000: {0}", cantRojosPrecioMayor);
            Console.WriteLine("Cantidad de vehiculos con valor menor a 5000 es: {0}", cantPrecioMenor);
            Console.WriteLine("El promedio del valor de todos los vehiculos ingresados es: {0}",promedio);
            Console.WriteLine("El vehiculo mas caro es de: {0} y su color es {1}",max,colorVehiculoCaro);

            Console.ReadKey();
        }
    }
}
