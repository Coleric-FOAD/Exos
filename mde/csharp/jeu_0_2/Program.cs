using System;

namespace jeu_0_2
{
    class Program
    {
        // CONSTANTES

        const int SCORE_MAX = 10;

        const int PTS_PAR_TOUR = 3;

        // VARIABLES

        static int number_computer;

        static int number_player;

        static string saisie;

        static Random random;
        
        static int diff;

        static int total_computer;

        static int total_player;

        static void Main(string[] args)
        {
            Console.WriteLine("Jeu du 0 - 2 !");
           
            random = new Random();

            do 
            {
                TourDeJeu();
            }
            while(total_computer < SCORE_MAX && total_player < SCORE_MAX);


            if(total_computer > total_player) 
            {
                Console.WriteLine("Le computer a gagné");
            }
            else 
            {
                Console.WriteLine("Le joueur a gagné");
            }
            
            Console.ReadLine();
        }


        static void TourDeJeu()
        {
            // choix de l'ordinateur
            number_computer = random.Next(3);
            Console.WriteLine("L'ordinateur a choisi :" + number_computer);

            Console.WriteLine("Choisissez un nombre entre 0, 1 et 2 :");

            saisie = Console.ReadLine(); 

            if(int.TryParse(saisie, out number_player)) 
            {
                Console.WriteLine("Le joueur a choisi :" + number_player);
            }
            else 
            {
                Console.WriteLine("Vous n'avez pas saisi un nombre.");
            }

            if(number_player >= 0 && number_player <= 2)
            {
                diff = Math.Abs(number_computer-number_player);

                Console.WriteLine("Différence entre les 2 nombres: " + (diff));

                if(diff == 0) 
                {
                    Console.WriteLine("Personne ne marque de point !");
                }
                else if (diff == 1)
                {
                    if(number_computer < number_player)
                    {
                        total_computer += PTS_PAR_TOUR;
                    }
                    else 
                    {
                        total_player += PTS_PAR_TOUR;
                    }
                }
                else if(diff == 2) 
                {
                    if(number_computer > number_player)
                    {
                        total_computer += PTS_PAR_TOUR;
                    }
                    else 
                    {
                        total_player += PTS_PAR_TOUR;
                    }
                }
                else {
                    Console.WriteLine("Impossible !");
                }

                Console.WriteLine("Computer : \t" + total_computer + " points.");
                Console.WriteLine("Player : \t" + total_player + " points.");

            }
            else {
                Console.WriteLine("Le nombre entré doit être 0, 1 ou 2 !");
            }
        }


    }
}
