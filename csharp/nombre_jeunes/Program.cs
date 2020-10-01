using System;

namespace nombre_jeunes
{
    class Program
    {
        static int I;

        static int N;

        static string[] AGES;

        static string saisie;



        static void Main(string[] args)
        {
            Console.WriteLine("Entrez 20 âges : ");

            saisie = Console.ReadLine();

            Console.WriteLine("Vous avez écrit : " + saisie);

            AGES = saisie.Split(' ');

            for(I = 0; I < AGES.Length; I++)
            {
                    Console.WriteLine(AGES[I]);

            }

            Console.WriteLine("FINI");

        }
    }
}
