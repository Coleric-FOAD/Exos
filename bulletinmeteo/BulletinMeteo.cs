using System;

namespace bulletinmeteo
{

    class Bulletin
    {

        private DateTime date;

        private DateTime heure;

        private string localisation;

        private string regiondumonde;
    
        private bool presentateur;



        public Bulletin (DateTime nouvelledate, DateTime nouvelleheure, string nouvellelocalisation, string nouvelleregiondumonde, bool nouveaupresentateur)
        {

            this.date = nouvelledate;
            this.heure = nouvelleheure;
            this.localisation = nouvellelocalisation;
            this.regiondumonde = nouvelleregiondumonde;
            this.presentateur = nouveaupresentateur;

            Console.WriteLine("Création d'un bulletin météo du " + this.date + this.heure);


        }

        public void Parler()
        {

        }  

    }// Fin de classe (Bulletin)


   
}  // Fin du NameSpace (bulletinmeteo)


