using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ü115142AAIFT
{
    class Program
    {
        static void Main(string[] args)
        {
            //Christoph Kurz | Ü115 | Temperatur Umrechner

            double Fahrenheit, Kelvin, Réaumur, Rankine, Temperatur;    //Double wegen Kommerdarstellung
            char Einheit; 

            Console.WriteLine("Temperatur Rechner"); // schreibt in die Konsole "Temperatur Rechner"

            Console.WriteLine();    //Zeilenabstand (Konsole)

            Console.Write("Geben Sie bitte die Temperatur (unter 1000°C) in °C ein: "); 
            Temperatur = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            if (Temperatur <= 1000 && Temperatur >= -273.15)
            {
                Console.Write("In welche Einheit ((F)ahrenheit, (K)elvin, (R)éaumur, R(A)nkine) wollen Sie umrechnen?: ");
                Einheit = Convert.ToChar(Console.ReadLine());
                Einheit = Char.ToUpper(Einheit);

                Console.WriteLine();

                if (Einheit == 'F' )
                {
                    Fahrenheit = Temperatur * 1.8 + 32;
                    Console.WriteLine("Die Temperatur in Fahrenheit beträgt: " + Fahrenheit + "°F");
                }
                else
                {
                    if (Einheit == 'K')
                    {
                        Kelvin = Temperatur + 273.15;
                        Console.WriteLine("Die Temperatur in Kelvin beträgt: " + Kelvin + "K");
                    }
                    else
                    {
                        if (Einheit == 'R')
                        {
                            Réaumur = Temperatur * 0.8;
                            Console.WriteLine("Die Temperatur in Réaumur beträgt: " + Réaumur + "°R");
                        }
                        else
                        {
                            if (Einheit == 'A')
                            {
                                Rankine = Temperatur * 1.8 + 491.67;
                                Console.WriteLine("Die Temperatur in Rankine beträgt: " + Rankine + "°Ra");
                            }
                            else
                            {
                                Console.WriteLine("Eingabefehler");
                            }
                        }
                    }
                }
            }
            else
            {
                if (Temperatur >= 1000)
                {
                    Console.WriteLine("Temperatur darf nicht über 1000°C liegen");
                }
                if (Temperatur <= -273.15)
                {
                    Console.WriteLine("Temperatur darf nicht unter -273,15°C liegen");
                }
            }
            Console.ReadLine();
        }
    }
}
