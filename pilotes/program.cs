using System;

namespace pilotes
{
    class Program    
    {   
        static Pilote chefDescadrille;
        static Pilote souschef;
        static Pilote ailier;

        
        static void Main(string[] args)
        {

            Console.WriteLine("Programme Pilotes");

          // définition des objets à partir de la classe Pilote

            chefDescadrille = new Pilote ("Colonel", "Martin", 123456, new DateTime(1990,01,02));
            souschef = new Pilote ("Lieutenant", "Dupont", 654321, new DateTime(2000,02,01));
            ailier = new Pilote ("Sous-Lieutenant", "Tartempion", 121314, new DateTime(2001,11,03));
                        

        }
    }
}
