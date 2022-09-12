using System;

namespace Opgave_5_ConCalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKey tast;
            do
            {
                SkrivVelkomst();
                Console.Write("Vælg funktion: ");
                string funktion = Console.ReadLine();
                double resultat = 0;
                if (funktion == "1")
                {
                    resultat = ConAdd();
                }
                else if (funktion == "2")
                {
                    resultat = ConSub();
                }
                else if (funktion == "3")
                {
                    resultat = ConTimes();
                }
                else if (funktion == "4")
                {
                    resultat = ConDivide();
                }
                else if (funktion == "5")
                {
                    resultat = ConLon();
                }
                else if (funktion == "6")
                {
                    resultat = ConFradrag();
                }

                ShowResult(resultat);
                Console.WriteLine("Skriv 'ESC' for at afslutte");
                tast = Console.ReadKey().Key;
            } while (tast != ConsoleKey.Escape) ;
        }
        

        static double ConAdd()
        {
            double tal1 = ReadDouble("Tal 1: ");
            double tal2 = ReadDouble("Tal 2: ");
            return tal1 + tal2;
        }
        static double ConSub()
        {
            double tal1 = ReadDouble("Tal 1: ");
            double tal2 = ReadDouble("Tal 2: ");
            return tal1 - tal2;
        }
        static double ConTimes()
        {
            double tal1 = ReadDouble("Tal 1: ");
            double tal2 = ReadDouble("Tal 2: ");
            return tal1 * tal2;
        }
        static double ConDivide()
        {
            double tal1 = ReadDouble("Tal 1: ");
            double tal2 = ReadDouble("Tal 2: ");
            return tal1 / tal2;
        }
        static double ConLon()
        {
            double tal1 = ReadDouble("Løn: ");
            double tal2 = ReadDouble("Fradrag: ");
            double tal3 = ReadDouble("Skat i %: ");
            return (tal1 - tal2) * ((100 - tal3) / 100); ;
        }
        static double ConFradrag()
        {
            double tal1 = ReadDouble("Antal arbejdsdage: ");
            double tal2 = ReadDouble("Antal km kørt: ");
            double fradrag;
            if (tal2 < 24)
            {
                fradrag = 0;
            }
            else if (tal2 < 120)
                    {
                fradrag = 1.98;
            }
            else
            {
                fradrag = 0.99;
            }

            return tal1 * tal2 * fradrag;
        }

        static double ReadDouble(string promt)
        {
            Console.Write(promt);
            string input = Console.ReadLine();
            double value = Convert.ToDouble(input);
            return value;
        }
        static void ShowResult(double result)
        {
            Console.WriteLine("---------------------");
            Console.Write("Resultat: ");
            Console.WriteLine(result);
            Console.WriteLine("---------------------");
        }
        static void SkrivVelkomst()
        {
            Console.Clear();
            Console.WriteLine("Velkommen til ConCalc");
            Console.WriteLine("---------------------");
            Console.WriteLine("1. Plus");
            Console.WriteLine("2. Træk fra");
            Console.WriteLine("3. Gange");
            Console.WriteLine("4. Dividere");
            Console.WriteLine("5. Nettoløn");
            Console.WriteLine("6. Kørselsfradrag");
            Console.WriteLine("---------------------");
        }
    }
}
