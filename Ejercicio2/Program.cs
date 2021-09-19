using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*2. Una empresa de viajes le solicita ingresar que continente le gustaría visitar y la cantidad de días , 
             *   la oferta dice que por día se cobra $100 , que se puede pagar de todas las maneras:
             *      a. Crear un método que valide continentes: recibe un continente y retorna true si se trata de un continente 
             *         válido (América, Asia, Europa, Africa, Oceanía). Crear un método que valide forma de pago: recibe la forma 
             *         de pago y retorna true si se trata de una forma de pago válido (Débito, Crédito, Efectivo, Mercado Pago, Cheque,
             *         Leliq)
             *      b. Si es América tiene un 15% de descuento y si además paga por débito se le agrega un 10% más de descuento
             *      c. Si es África u Oceanía tiene un 30% de descuento y si además paga por mercadoPago o efectivo se le agrega un 15% 
             *         más de descuento.
                    d. Si es Europa tiene un 20% de descuento y si además paga por débito se le agrega un 15% , por mercadoPago un 10% y
                       cualquier otro medio 5% 
                    e. cualquier otro continente tiene un recargo del 20% 
                    f. en cualquier continente , si paga con cheque, se recarga un 15% de impuesto al cheque
            */

            Console.WriteLine("***EMPRESA DE VIAJES***");

            string continente;
            string medioPago;
            int cantDias;
            int estadia = 100;
            double precioFinal;
            bool diasValido;

            do
            {
                Console.WriteLine("Ingrese continente: ");
                continente = Console.ReadLine().ToLower();

                if (ValidarContinente(continente) == false)
                {
                    Console.WriteLine("No valido! Continentes: Europa-Asia-Oceania-Africa-America");
                }
            } while (!(ValidarContinente(continente)));

            do
            {
                Console.WriteLine("Ingrese cantidad de dias: ");
                diasValido = Int32.TryParse(Console.ReadLine(), out cantDias);
                if (!diasValido)
                {
                    Console.WriteLine("Ingrese dias expresado en numeros");
                }
                if (cantDias < 0)
                {
                    Console.WriteLine("Debe ser mayor a 0");
                }
            } while ((!diasValido) || (cantDias < 0 ));
            


            do
            {
                Console.WriteLine("Ingrese medio de pago: ");
                medioPago = Console.ReadLine().ToLower();
                if (ValidarMedioPago(medioPago) == false)
                {
                    Console.WriteLine("No valido! Medios de pago: efectivo-debito-credito-mercado pago-cheque-leliq");
                }
            } while (!(ValidarMedioPago(medioPago)));


            switch (continente)
            {
                case "america":
                    precioFinal = (cantDias * estadia) - ((cantDias * estadia)* 0.15);
                    if (medioPago == "debito")
                    {
                        precioFinal = precioFinal - (precioFinal * 0.10);
                        Console.WriteLine("El precio final a {0} por {1} dias es: ${2}.\nTiene un descuento del 15% "
                        + "y ademas por el medio de pago elegido se le agrega un 10% mas de descuento.", continente,cantDias,precioFinal);
                    }
                    else
                    {
                        Console.WriteLine("El precio final a {0} por {1} dias es: ${2}.\nTiene un descuento del 15% ",continente,cantDias,precioFinal);
                    }
                    break;
                case "africa":
                case "oceania":
                    precioFinal = (cantDias * estadia) - ((cantDias * estadia) * 0.30);
                    if (medioPago == "mercado pago" || medioPago == "efectivo")
                    {
                        precioFinal = precioFinal - (precioFinal * 0.15);
                        Console.WriteLine("El precio final a {0} por {1} dias es: ${2}.\nTiene un descuento del 30% "
                        + "y ademas por el medio de pago elegido se le agrega un 15% mas de descuento.", continente, cantDias, precioFinal);
                    }
                    else
                    {
                        Console.WriteLine("El precio final a {0} por {1} dias es: ${2}.\nTiene un descuento del 30% ", continente, cantDias, precioFinal);
                    }

                    break;
                case "europa":
                    precioFinal = (cantDias * estadia) - ((cantDias * estadia) * 0.20);
                    switch (medioPago)
                    {
                        case "debito":
                            precioFinal = precioFinal - (precioFinal * 0.15);
                            Console.WriteLine("El precio final a {0} por {1} dias es: ${2}.\nTiene un descuento del 20% "
                        + "y ademas por el medio de pago elegido se le agrega un 15% mas de descuento.", continente, cantDias, precioFinal);
                            break;
                        case "mercado pago":
                            precioFinal = precioFinal - (precioFinal * 0.10);
                            Console.WriteLine("El precio final a {0} por {1} dias es: ${2}.\nTiene un descuento del 20% "
                        + "y ademas por el medio de pago elegido se le agrega un 10% mas de descuento.", continente, cantDias, precioFinal);
                            break;
                        case "cheque":
                            precioFinal = ((cantDias * estadia) - (cantDias * estadia) * 0.05) * 1.15;
                            Console.WriteLine("El precio final a {0} por {1} dias es ${2} con un descuento del 20%.\nTiene un recargo del 15% de impuesto al medio de pago elegido: {3}",continente,cantDias, precioFinal, medioPago);
                            break;
                        default:
                            precioFinal = precioFinal - (precioFinal * 0.05);
                            Console.WriteLine("El precio final a {0} por {1} dias es: ${2}.\nTiene un descuento del 20% "
                        + "y ademas por el medio de pago elegido se le agrega un 5% mas de descuento.", continente, cantDias, precioFinal);
                            break;
                    }
                    break;
                default:
                    precioFinal = (cantDias * estadia) * 1.20;
                    if (medioPago == "cheque")
                    {
                        precioFinal = precioFinal * 1.15;
                        Console.WriteLine("el precio final a {0}  por {1} dias es ${2} con un recargo de 20%.\nTiene un recargo del 15% de impuesto al medio de pago elegido {3}",continente,cantDias, precioFinal,medioPago);
                    }
                    else
                    {
                        Console.WriteLine("El precio final a {0} por {1} dias es: ${2}. Con un recargo de 20%.",continente,cantDias, precioFinal);
                    }
                    break;
            }


            Console.ReadKey();

            
        }
        static bool  ValidarContinente(string continente)
        {

            if (continente == "asia" || continente == "africa" || continente == "america" || continente == "oceania" || continente == "europa")
            {
                return  true;
            }
            else
            {
                return false;
            }
        }
        static bool ValidarMedioPago(string medioPago)
        {

            if (medioPago == "debito" || medioPago == "credito" || medioPago == "efectivo" || medioPago == "mercado pago" || medioPago == "cheque" || medioPago == "leliq")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
