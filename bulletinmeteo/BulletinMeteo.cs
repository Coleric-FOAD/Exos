using System;

namespace bulletinmeteo
{

    class Bulletin
    {

        private DateTime date;

        private string heure;

        private string localisation;

        private string region;
    
        private bool presentateur;



        public Bulletin (DateTime nouvelledate, string nouvelleheure, string nouvellelocalisation, string nouvelleregion, bool nouveaupresentateur)
        {

            this.date = nouvelledate;
            this.heure = nouvelleheure;
            this.localisation = nouvellelocalisation;
            this.region = nouvelleregion;
            this.presentateur = nouveaupresentateur;

            Console.WriteLine("Création d'un bulletin météo du " + this.date + this.heure);


        }

        public void Parler()
        {

        }  

    }// Fin de classe (Bulletin)


   
}  // Fin du NameSpace (bulletinmeteo)


