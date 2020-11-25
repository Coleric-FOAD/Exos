using System;

namespace pilotes
{
    class Program    
    {   
        static Pilote chefDescadrille;
        static Pilote souschef;
        static Pilote ailier;

        static Avion chasseur;
        static Avion bombardier;
        static Avion intercepteur;
        static Avion reco;




        static void Main(string[] args)
        {

            Console.WriteLine("Programme Pilotes");

          // définition des objets à partir de la classe Pilote

            chefDescadrille = new Pilote ("Colonel", "Martin", 123456, new DateTime(1990,01,02));
            souschef = new Pilote ("Lieutenant", "Dupont", 654321, new DateTime(2000,02,01));
            ailier = new Pilote ("Sous-Lieutenant", "Tartempion", 121314, new DateTime(2001,11,03));



            // définition des objets à partir de la classe Avion 

            chasseur = new Avion (2500, 15000, 2000, "Mirage 2000", "Dassault");
            bombardier = new Avion (2300, 13300, 60800, "Tu-22M", "Tupolev");
            intercepteur = new Avion (2500, 20000, 1500, "F22 raptor", "Lockheed Martin");
            // intercepteur = new Avion (2600, 23000, 2200, "Rafale", "Dassault"); 
            reco = new Avion (855, 12500, 7400, "E-3 Sentry", "Boeing");

            Console.WriteLine("Appuyez sur une touche");

            Console.ReadLine();

        }
    }
}
