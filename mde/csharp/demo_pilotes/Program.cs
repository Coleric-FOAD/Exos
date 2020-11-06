using System;

namespace demo_pilotes
{
    class Program
    {
        static Pilote chefDescadrille;
        
        static Pilote sousChef;
        
        static Pilote ailier;
        
        static void Main(string[] args)
        {
            Console.WriteLine("Pilotes !");

            chefDescadrille = new Pilote("Colonel", "Martin", 123456, new DateTime(1990, 01, 02));

            sousChef = new Pilote("Lieutenant", "Dupont", 654321, new DateTime(2000, 02, 01));

            ailier = new Pilote("Sous-Lieutenant", "Tartempion", 121314, new DateTime(2001, 03, 03));
        }
    }
}
