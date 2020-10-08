using System;

namespace nombre_jeunes
{
    class Program
    {
        // déclaration d'une variable de type "int" (nombre entier)
        static int I;

        static int N;

        // tableau de string (chaine de caractères)
        static string[] AGES;

        static string saisie;


        static void Main(string[] args)
        {
            // Ecrit "Entrez 20 âges :" dans la console
            Console.WriteLine("Entrez 20 âges :");
            
            // Met le programme en pause et attend une saisie de l'utilisateur
            // la saisie sera récupérée dans la variable "saisie"
            saisie = Console.ReadLine();

            Console.WriteLine("Vous avez écrit: " + saisie);

            AGES = saisie.Split(' ');

            N = 0;

            for(I = 0; I < AGES.Length; I++)
            {
                Console.WriteLine(AGES[I]);

                int age = Convert.ToInt32(AGES[I]);

                if(age < 20)
                {
                    // equivalent: N = N + 1;
                    N++;

                } // fin du if (SI)

            } // fin du for (POUR)

            Console.WriteLine("Le nombre de personnes agées de moins de 20 ans est " + N);

        }
    }
}
