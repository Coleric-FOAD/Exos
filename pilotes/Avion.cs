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

        private Pilote pilote;


        public Avion (int nouvellevitessemax, int nouveauplafond, int nouveaurayonaction, string nouveaumodele, string nouvellemarque)
        {
            this.vitessemax = nouvellevitessemax;
            this.plafond = nouveauplafond;
            this.rayonaction = nouveaurayonaction;
            this.modele = nouveaumodele;
            this.marque = nouvellemarque;
            Console.WriteLine("Utilisation d'un nouvel avion  " + this.modele + " de type " + this.marque);
        }

        public void AssocierPilote(Pilote nouveaupilote)
        {
            this.pilote = nouveaupilote;
            Console.WriteLine("Le pilote " + pilote.nom + " a été associé à l'avion " + this.modele);
        }


        public void Accelerer()
        {
            if(this.pilote != null)
            {
                Console.WriteLine(pilote.nom + "s'envole. L'avion " + this.modele + " accélère");
            }
            else
            {
                Console.WriteLine("L'avion n'a pas de pilote");
            }            
        }
        public void Ralentir ()
        { 
        
        }

        public void Attaquer ()
        {


        }

    } // Fin de classe (Avion) 
}
