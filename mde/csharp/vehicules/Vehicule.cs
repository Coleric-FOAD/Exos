using System;

namespace vehicules
{
    class Vehicule
    {
        private string couleur;

        private int vitesseMax;


        public Vehicule(string nouvelleCouleur, int nouvelleVitesse)
        {
            this.couleur = nouvelleCouleur;
            this.vitesseMax = nouvelleVitesse;
            
            Console.WriteLine("Construction d'un nouveau véhicule " + this.couleur);
        }

        public void Demarrer()
        {
            Console.WriteLine("Je démarre !");
        }

        public void Avancer()
        {
            Console.WriteLine("J'avance !");
        }

        public void Arreter()
        {
            Console.WriteLine("Je m'arrête !");
        }

        public void Ralentir()
        {
            Console.WriteLine("Je ralentis !");
        }

        public void Accelerer()
        {
            Console.WriteLine("J'accélère mais pas plus que " + this.vitesseMax + " km/h !");
        }
    } // fin de classe
}