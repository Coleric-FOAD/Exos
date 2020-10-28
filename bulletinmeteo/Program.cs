using System;

namespace bulletinmeteo
{
    class Program
    {
        static Bulletin matin;
        static Bulletin midi;
        static Bulletin soir;
        static Bulletin nuit;
        
        
        
        static void Main(string[] args)
        {
            Console.WriteLine("Création de bulletins météo");

            // définition des objets à partir de la classe Bulletin

            matin = new Bulletin (new DateTime(2020,10,29), "Bulletin du Matin")
            midi = new Bulletin ();
            soir = new Bulletin ();
            nuit = new Bulletin ();
             


        }
    }
}
