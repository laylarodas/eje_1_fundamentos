using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*3. Realizar el algoritmo que permita el ingreso de 10 bolsas de alimento para mascotas, con los kilos (validar entre 0 y
             *   500) , sabor validar (carne vegetales pollo) e informar por consola:
             *   a. El promedio de los kilos totales.
             *   b. La bolsa más liviana y su sabor
             *   c. La cantidad de bolsas sabor carne y el promedio de kilos de sabor carne
             */

            int cantBolsas = 10;
            float kilos;
            string sabor;
            float sumaKilos = 0;
            float promedioKilos;
            float bolsaLivina = float.MaxValue;
            string bolsaLivianaSabor = " ";
            int cantBolsaCarne = 0;
            float sumaBolsasCarne = 0;
            float promedioKilosCarne;

            for (int i = 0; i < cantBolsas; i++)
            {
                do
                {
                    Console.WriteLine("Ingrese cantidad de kilos: ");
                    kilos = float.Parse(Console.ReadLine());
                    if (kilos < 0 || kilos > 500)
                    {
                        Console.WriteLine("No valido! (entre 0 a 500)");
                    }
                } while (kilos < 0 || kilos > 500);

                do
                {
                    Console.WriteLine("Ingrese sabor:");
                    sabor = Console.ReadLine();
                    if (sabor != "carne" && sabor != "vegetales" && sabor != "pollo")
                    {
                        Console.WriteLine("No valido! Opciones: carne-vegetales-pollo");
                    }
                } while (sabor != "carne" && sabor != "vegetales" && sabor != "pollo");

                if (bolsaLivina > kilos)
                {
                    bolsaLivina = kilos;
                    bolsaLivianaSabor = sabor;
                }

                if (sabor == "carne")
                {
                    cantBolsaCarne++;
                    sumaBolsasCarne += kilos;
                }
                sumaKilos += kilos;
            }

            promedioKilos = sumaKilos / cantBolsas;
            promedioKilosCarne = sumaBolsasCarne / cantBolsaCarne;

            Console.WriteLine("El promedio de kilos totales es: {0}",promedioKilos);
            Console.WriteLine("La bolsa mas liviana {0} y su sabor {1}. ", bolsaLivina,bolsaLivianaSabor);
            Console.WriteLine("La cantidad de bolsas de carnes es: {0} y su promedio de kilos es: {1}", cantBolsaCarne,promedioKilosCarne);


            Console.ReadKey();
        }
    }
}
