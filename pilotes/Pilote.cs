using System;

namespace pilotes
{

    class Pilote
    {

        public string grade;

        public string nom;

        public int matricule;

        public DateTime datedenaissance;


        public Pilote (string nouveaugrade, string nouveaunom, int nouveaumatricule, DateTime nouvelledatedenaissance)
        {
                this.grade = nouveaugrade;
                this.nom = nouveaunom;
                this.matricule = nouveaumatricule;
                this.datedenaissance = nouvelledatedenaissance;
                
                Console.WriteLine("Embauche d'un nouveau pilote " + this.nom);
                this.GetAge();

        }

        public void GetAge()
        {
           Console.WriteLine(this.nom + " est né le : " + this.datedenaissance.ToLongDateString());
           DateTime auj = DateTime.Today;
           int age = auj.Year - this.datedenaissance.Year;

           if (this.datedenaissance.Month > auj.Month)
            {
            age--;
            }
            
           Console.WriteLine(" l'âge de " + this.nom + " est " + age);




        }
    
        public void Piloter()
        {

        }

        public void Atterir()
        {

        }

        public void Decoller()
        {

        }

    }  // Fin de classe (Pilote)

} 

