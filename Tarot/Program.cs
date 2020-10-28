using System;

namespace tarot
{
    class Program
    {
        static CarteTarot dameDeCoeur;
        static CarteTarot asDeTrefle;
        static CarteTarot roiDeCarreau;
        static CarteTarot huitDePique;
        static CarteTarot douzeAtout;
        static CarteTarot deuxDeCarreau;
        static CarteTarot septDeTrefle;

        
        static void Main(string[] args)
        {
            Console.WriteLine("Création de cartes de Tarot");

            // définition des objets à partir de la classe CarteTarot


                dameDeCoeur = new CarteTarot ("Coeur", "Dame");
                asDeTrefle = new CarteTarot ("As", "Trèfle");
                roiDeCarreau = new CarteTarot ("Carreau", "Roi");
                huitDePique = new CarteTarot ("Pique", "Huit");
                douzeAtout = new CarteTarot ("Atout", "Douze");
                deuxDeCarreau = new CarteTarot ("Carreau", "Deux");
                septDeTrefle = new CarteTarot ("Trèfle", "Sept");


        }
    }
}
