using System;


namespace intro_objet
{
    class Vehicule
    {
        string genre;

        private string couleur;

        public Vehicule(string _type, string _couleur)
        {
            this.genre = _type;
            this.couleur = _couleur;
        }

        public string GetGenre()
        {
            return this.genre;
        }

        public void Demarrer()
        {
            
        }
    }
}