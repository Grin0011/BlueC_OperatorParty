﻿using System;

namespace BlueC_OperatorParty
{
    class Program
    {

        private static void Parse()
        {
            string invoer = Console.ReadLine();

            string[] opgesplitsteInvoer = invoer.Split(" ");

            string operatorr = opgesplitsteInvoer[0];

            string getal1 = opgesplitsteInvoer[1];
            int number1 = int.Parse(getal1);

            string getal2 = opgesplitsteInvoer[2];
            int number2 = int.Parse(getal2);

            if (operatorr == "+")
            {
                // roep hier netjes de methode
                // van de calculatorclass aan
                int r = number1 + number2;

                Console.WriteLine(r);
            }
        }

        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Geef een som in (prefix notatie)...");

                Parse();
            }
        }
    }
}
