using System;

namespace tarot
{

    class CarteTarot
    {

        private string couleur;
        
        private string valeur;

        private string type;

        
 

        public CarteTarot (string nouveautype, string nouvellevaleur,string nouvellecouleur)
        {
                    this.couleur = nouvellecouleur;
                    this.valeur = nouvellevaleur;
                    this.type = nouveautype;

                    Console.WriteLine("Création d'une nouvelle carte " + this.type + " , " + this.valeur + " de " + this.couleur);
                    
        }

        public void Jouer()

        {
            Console.WriteLine(this.type + " est jouée avec la valeur " + this.valeur + " et la couleur " + this.couleur);

            

        }

        public void Couper()
        {

            Console.WriteLine(" est coupé(e) par le " + this.couleur + " d'" + this.valeur );



        }
        public void Couper(CarteTarot nouvellecarte)
        {

            Console.WriteLine(nouvellecarte.valeur + " est coupé(e) par le " + this.couleur + " d'" + this.valeur);


        }

        // Fin de classe (CarteTarot)


    } // Fin du NameSpace (tarot)

        
}