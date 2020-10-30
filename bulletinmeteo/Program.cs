using System;

namespace bulletinmeteo
{
    class Program
    {
        
           
        static void Main(string[] args)
        {
            Console.WriteLine("Création de bulletins météo");

            // Création de la date 
            DateTime DTM = new DateTime(2020,10,29);

            // définition des objets à partir de la classe Bulletin


            Bulletin matin = new Bulletin (DTM," 8 H "," Schiltigheim "," Alsace ", true);
            Bulletin midi = new Bulletin (DTM, " 12 H ", " Paris ", " Ile de France ", true);
            Bulletin soir = new Bulletin (DTM, " 19 H ", " Merseille ", " PACA ", false);
            Bulletin nuit = new Bulletin (DTM, " 24 H ", " Nancy ", " Lorraine ", false);
             


        }
    }
}
