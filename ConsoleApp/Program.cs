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

            string eingabe = "-";
            while (eingabe != "")
            {
                // Benutzereingabe - Achtung: Exception möglich

                Console.Write("Bitte geben Sie eine Zahl ein: ");
                eingabe = Console.ReadLine();


                //nur wenn eine Eingabe vorhanden ist
                if(eingabe != "")
                {
                    string ausgabe = rechner.NächsteBerechnung();
                    Console.Write("Rechne: {0}", ausgabe);

                    eingabe = Console.ReadLine();
                    try
                    {
                        int zahl = Convert.ToInt32(eingabe);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Bitte geben Sie nur Zahlen ein.");
                    }

                }

               

            }

        }
    }
}
