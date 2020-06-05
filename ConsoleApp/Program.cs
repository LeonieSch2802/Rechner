﻿using Rechner.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            // Verwendung der Klasse
            Rechenautomat rechner = new Rechenautomat();

            int korrekt = 0;
            int falsch = 0;

            string eingabe = "-";
            while (eingabe != "")
            {
                // Benutzereingabe - Achtung: Exception möglich

               
                //nur wenn eine Eingabe vorhanden ist
                if(eingabe != "")
                {
                    string ausgabe = rechner.NächsteBerechnung();
                    Console.Write("Rechne: {0} = ", ausgabe);


                    
                    eingabe = Console.ReadLine();
                    try
                    {
                        int zahl = Convert.ToInt32(eingabe);

                        if (rechner.Prüfe(zahl))
                        {
                            Console.WriteLine("Super");
                            korrekt++;
                        }
                        else
                        {
                            Console.WriteLine("Das kannst du besser");
                            falsch++;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Bitte geben Sie nur Zahlen ein.");
                    }

                }

               

            }
            Console.WriteLine("Du hast {0} Augaben richtig gelöst und {1} Aufgaben falsch gelöscht", korrekt, falsch);

        }
    }
}
