using System;

namespace barnabe
{
    class Program
    {
        static double somme_depart;

        static double somme_restante;

        static double nombre_magasins;

        static string saisie;

        static void Main(string[] args)
        {
            Console.WriteLine("Barnabé fait ses courses");
            
            Console.WriteLine("De combien barnabé dispose-t-il ?");

            saisie = Console.ReadLine();

            somme_depart = Convert.ToDouble(saisie);

            Console.WriteLine("Barnabé dispose de " + saisie + " Euros");

            nombre_magasins = 0;

            somme_restante = somme_depart;

            while(somme_restante > 0)
            {
                if(somme_restante <= 1) {
                    somme_restante = 0;
                }
                else {
                    somme_restante = somme_restante - (somme_restante / 2);
                    somme_restante = somme_restante - 1;
                }
                
                nombre_magasins++;

                Console.WriteLine("Magasin N° " + nombre_magasins + ": il reste : " + somme_restante);
            }

            Console.WriteLine("Barnabé a visité " + nombre_magasins + " magasins.");


        }
    }
}
