using System;

namespace tarot
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
            Console.WriteLine("Création de cartes de Tarot");

            // définition des objets à partir de la classe CarteTarot


                CarteTarot dameDeCoeur = new CarteTarot ("Figure", "Dame", "Coeur");
                CarteTarot asDeTrefle = new CarteTarot ("Chiffre", "As", "Trèfle");
                CarteTarot roiDeCarreau = new CarteTarot ("Figure","Roi", "Carreau");
                CarteTarot huitDePique = new CarteTarot ("Chiffre", "Huit", "Pique");
                CarteTarot douzeAtout = new CarteTarot ("Atout","Atout","Douze");
                CarteTarot deuxDeCarreau = new CarteTarot ("Chiffre", "Deux", "Carreau");
                CarteTarot septDeTrefle = new CarteTarot ("Chiffre","Sept","Trèfle");

            Console.WriteLine("\r");

            dameDeCoeur.Jouer();
            Console.WriteLine("\r");
            douzeAtout.Couper(dameDeCoeur);

            Console.ReadLine();

        }
    }
}
