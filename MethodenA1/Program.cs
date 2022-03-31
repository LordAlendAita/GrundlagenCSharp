using System;

namespace abschreib_bar
{
    class Program
    {
        public static void Main()
        {
            int anzahl = 0;
            Console.WriteLine("Geben sie ihren Text ein !");
            string eingabe_str = Console.ReadLine();

            Console.WriteLine("Geben sie ihre Zahl ein !");
            int zahl = Convert.ToInt32(Console.ReadLine());


            anzahl = ausgabeTextMalX(eingabe_str, zahl);
            Console.Write("\n Anzahlder Buchstaben: {0}", anzahl);

            Console.ReadLine();
        }

        public static int ausgabeTextMalX(string text, int anzahl)
        {
            for (int i = 0; i < anzahl; i++)
            {
                System.Console.WriteLine(text);
                // System.Console.WriteLine(anzahl);
            }
            int anzahl_zeichen = text.Length * anzahl;

            return anzahl_zeichen;

        }

        //Alend Ibrahim und Andi Sojeva


    }
}