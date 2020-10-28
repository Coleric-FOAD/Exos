using System;

namespace tarot
{

    class CarteTarot
    {

        private string couleur;
        
        private string valeur;

        // private string type;

 

        public CarteTarot (string nouvellecouleur, string nouvellevaleur)
        {
                    this.couleur = nouvellecouleur;
                    this.valeur = nouvellevaleur;
                    // this.type = nouveautype;

                    Console.WriteLine("Création d'une nouvelle carte " + this.valeur + " de " + this.couleur);
                    
        }

        public void Jouer()

        {
            Console.WriteLine(this.valeur + "est jouée avec la valeur " + "et la couleur " + this.couleur);

            

        }

        public void Couper()
        {


        } // Fin de classe (CarteTarot)


    } // Fin du NameSpace (tarot)

        
}