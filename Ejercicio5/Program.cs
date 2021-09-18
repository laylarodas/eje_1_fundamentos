using System;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*5. Realizar el algoritmo que permita ingresar el nombre de un estudiante, la edad (validar) , el sexo (validar) y 
             *   la nota del final (validar) hasta que el usuario quiera e informar al terminar el ingreso por consola:
             *   a. La cantidad de varones aprobados
             *   b. El promedio de notas de los menores de edad
             *   c. El promedio de notas de los adolescentes
             *   d. El promedio de notas de los mayores
             *   e. El promedio de notas por sexo.
             */

            string nombre;
            int edad;
            bool edadValida;
            bool notaValida;
            char sexo = ' ';
            float nota;
            char opcion;
            int cantVaronesAprobados = 0, cantMenores = 0, cantAdolescentes = 0, cantMayores= 0, cantMujeres = 0, cantVarones = 0, cantOtros = 0;
            float sumaMenores = 0, sumaAdolescentes = 0, sumaMayores = 0,sumaMujeres= 0, sumaVarones = 0, sumaOtros = 0;

            do
            {
                Console.WriteLine("Ingrese nombre del estudiante: ");
                nombre = Console.ReadLine();

                do
                {
                    Console.WriteLine("Ingrese edad: ");
                    edadValida = Int32.TryParse(Console.ReadLine(), out edad);
                    if (!edadValida)
                    {
                        Console.WriteLine("Ingrese edad expresado en numeros");
                    }
                    if ((edad < 5) || (edad > 25))
                    {
                        Console.WriteLine("Debe ser mayor a 5 y menor 25");
                    }
                } while ((!edadValida) || ((edad < 5) || (edad > 25)));


                do
                {
                    Console.WriteLine("Ingrese sexo: ");
                    sexo = char.Parse(Console.ReadLine());
                    if (sexo != 'f' && sexo != 'm' && sexo != 'x')
                    {
                        Console.WriteLine("No valido!");
                    }
                } while (sexo != 'f' && sexo != 'm' && sexo != 'x');

                do
                {
                    Console.WriteLine("Ingrese nota del alumno: ");
                    notaValida = float.TryParse(Console.ReadLine(), out nota);
                    if (!notaValida)
                    {
                        Console.WriteLine("Ingrese nota expresado en numeros");
                    }
                    if (nota < 0 || nota > 10)
                    {
                        Console.WriteLine("No valido!");
                    }
                } while (!notaValida || (nota < 0 || nota > 10));

                if (sexo == 'm' && nota >= 7)
                {
                    cantVaronesAprobados++;
                }
                if (edad < 13)
                {
                    sumaMenores += nota;
                    cantMenores++;
                }

                if (edad >= 13 && edad <= 17)
                {
                    sumaAdolescentes += nota;
                    cantAdolescentes++;
                }
                if (edad >= 18)
                {
                    sumaMayores += nota;
                    cantMayores++;
                }

                switch (sexo)
                {
                    case 'f':
                        cantMujeres++;
                        sumaMujeres += nota;
                        break;
                    case 'm':
                        cantVarones++;
                        sumaVarones += nota;
                        break;
                    default:
                        cantOtros++;
                        sumaOtros += nota;
                        break;
                }


                Console.WriteLine("Desea ingresar mas datos? s/n");
                opcion = char.Parse(Console.ReadLine());
            } while (opcion != 'n');

            float promMenores, promMujeres, promVarones, promOtros, promAdolescentes, promMayores;

            promMenores = Promedio(cantMenores, sumaMenores);
            promMayores = Promedio(cantMayores, sumaMayores);
            promAdolescentes = Promedio(cantAdolescentes, sumaAdolescentes);
            promMujeres = Promedio(cantMujeres, sumaMujeres);
            promVarones = Promedio(cantVarones, sumaVarones);
            promOtros = Promedio(cantOtros, sumaOtros);

            Console.WriteLine("La cantidad de varones aprobados es: {0}", cantVaronesAprobados);
            Console.WriteLine("El promedio de notas de menores de edad es: {0}",promMenores);
            Console.WriteLine("El promedio de notas de mayores de edad es: {0}", promMayores);
            Console.WriteLine("El promedio de notas de adolescentes de edad es: {0}", promAdolescentes);
            Console.WriteLine("El promedio de notas de mujeres de edad es: {0}", promMujeres);
            Console.WriteLine("El promedio de notas de varones de edad es: {0}", promVarones);
            Console.WriteLine("El promedio de notas de otros de edad es: {0}", promOtros);

            Console.ReadKey();

        }

        static float Promedio(int cantidad, float suma)
        {
            return suma / cantidad;
        }
    }
}
