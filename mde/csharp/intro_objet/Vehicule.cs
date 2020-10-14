using System;


namespace intro_objet
{
    class Vehicule
    {
        string genre;

        string couleur;

        public Vehicule(string _type, string _couleur)
        {
            this.genre = _type;
            this.couleur = _couleur;
        }

        public string GetGenre()
        {
            return this.genre;
        }
    }
}