using System;

namespace bulletinmeteo
{

    class Bulletin
    {

        private DateTime date;

        private string heure;

        private string localisation;

        private string region;
    
        public bool presentateur;



        public Bulletin (DateTime nouvelledate, string nouvelleheure, string nouvellelocalisation, string nouvelleregion, bool nouveaupresentateur)
        {

            this.date = nouvelledate;
            this.heure = nouvelleheure;
            this.localisation = nouvellelocalisation;
            this.region = nouvelleregion;
            this.presentateur = nouveaupresentateur;

            Console.WriteLine("Création d'un bulletin météo du " + this.date + this.heure);


        }

        public Bulletin (string stroumpf, string zimb)
        {

            this.localisation = stroumpf;
            this.region = zimb;

            Console.WriteLine(" Création nouveau bulletin avec nouveau constructeur ");


        }
                    

        public void Parler()
        {

        }  

    }// Fin de classe (Bulletin)


   
}  // Fin du NameSpace (bulletinmeteo)


