using System;

namespace parcial01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de variables 
            int mil = 1000, cantidadLimiteMil=18, cantidadMil;
            int quinientos = 500, cantidadLimiteQuinientos=19, cantidadQuinientos;
            int doscientos = 200, cantidadLimiteDoscientos=23, cantidadDoscientos;
            int cien = 100, cantidadLimiteCien=50, cantidadCien;
            int banco;
            int limite;
            int monto;
            //Inicializacion de variables 
            cantidadMil = 0;
            cantidadQuinientos = 0;
            cantidadDoscientos = 0;
            cantidadCien = 0;
            do
            {
                Console.WriteLine("\n Bienvenidos a FDP INVERSMENTS \n Escoge tu banco \n 1: FDP INVERSMENTS \n 2: otro");
                banco = int.Parse(Console.ReadLine());
                if (banco == 1)  //Asignacion de limite para FDP
                {
                    limite = 20000;
                    break;
                }
                else if (banco == 2) //Asignacion para otro 
                {
                    limite = 10000;
                    break;
                }
            } while (true);
            Console.WriteLine("¿Cuanto desea retirar?: ");
            monto = int.Parse(Console.ReadLine());
            if (monto <= limite) // Validar que el monto no pase del limite
            {
                if (monto % 100 == 0) //Validar que el monto es multiplo de 100
                {
                    while (monto > 0)//Bucle para que el programa vaya revisando si el monto puede ser restado del banco y si aun sobran de esos billetes
                    {
                        if (monto - mil >= 0 && cantidadLimiteMil > 0)
                        {
                            monto -= mil;
                            cantidadLimiteMil--;
                            cantidadMil++;
                        }
                        else if (monto - quinientos >= 0 && cantidadLimiteQuinientos > 0)
                        {
                            monto -= quinientos;
                            cantidadLimiteQuinientos--;
                            cantidadQuinientos++;
                        }
                        else if (monto - doscientos >= 0 && cantidadLimiteDoscientos > 0)
                        {
                            monto -= doscientos;
                            cantidadLimiteDoscientos--;
                            cantidadDoscientos++;
                        }
                        else if (monto - cien >= 0 && cantidadLimiteCien > 0)
                        {
                            monto -= cien;
                            cantidadLimiteCien--;
                            cantidadCien++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (monto>0)//Si se acaban los billetes y el banco no puede devolver todo el monto, no se retira el dinero
                    {
                        cantidadLimiteMil += cantidadMil;
                        cantidadLimiteQuinientos += cantidadQuinientos;
                        cantidadLimiteDoscientos += cantidadDoscientos;
                        cantidadLimiteCien += cantidadCien;

                        cantidadMil = 0;
                        cantidadQuinientos = 0;
                        cantidadDoscientos = 0;
                        cantidadCien = 0;
                        Console.WriteLine("No se puede retirar el monto especificado. ");
                    }
                    else
                    {
                        Console.Write("Usted ha retirado: ");
                    }
                    if (cantidadMil > 0)
                    {
                        Console.Write(cantidadMil + " de mil ");
                    }
                    if (cantidadQuinientos > 0)
                    {
                        Console.Write(cantidadQuinientos + " de quinientos ");

                    }
                    if (cantidadDoscientos > 0)
                    {
                        Console.Write(cantidadDoscientos + " de doscientos ");

                    }
                    if (cantidadCien > 0)
                    {
                        Console.Write(cantidadCien + " de cien ");

                    }

                }
                else
                {
                    Console.WriteLine("El monto debe ser multiplo de 100");
                }
            }
            else
            {
                Console.WriteLine("No puede retirar mas de: " + limite);
            }                
        }
    }
}
