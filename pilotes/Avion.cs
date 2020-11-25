using System;
using System.Collections.Generic;
using System.Text;

namespace pilotes
{
    class Avion
    {

        private int vitessemax;

        private int plafond;

        private int rayonaction;

        private string modele;

        private string marque;



        public Avion (int nouvellevitessemax, int nouveauplafond, int nouveaurayonaction, string nouveaumodele, string nouvellemarque)
        {
            this.vitessemax = nouvellevitessemax;
            this.plafond = nouveauplafond;
            this.rayonaction = nouveaurayonaction;
            this.modele = nouveaumodele;
            this.type = nouveautype;

            Console.WriteLine("Utilisation d'un nouvel avion  " + this.modele + " de type " + this.type);


        }


        public void Accelerer ()
        {

        }
        public void Ralentir ()
        { 
        
        }

        public void Attaquer ()
        {


        }

    } // Fin de classe (Avion) 
}
