using System;

/**
*/
namespace vehicules
{
    class Vehicule
    {
        private string grade;

        private string nom;

        private int matricule;

        private DateTime dateDeNaissance;


        public Pilote(string nouveauGrade, string nouveauNom, string nouveauMatricule, DateTime nouvelleDate)
        {
            this.grade = nouveauGrade;
            this.nom = nouveauNom;
            this.matricule = nouveauMatricule;
            this.dateDeNaissance = nouvelleDate;
            
            Console.WriteLine("Embauche du nouveau pilote " + this.nom);
        }

        public void GetAge()
        {
            Console.WriteLine(this.nom + " est né le : " + this.dateDeNaissance);

            DateTime auj = new DateTime();

            int age = auj.Year - this.dateDeNaissance.Year;

            Console.WriteLine("l'âge de " + this.nom + " est " + age);
        }

    } // fin de classe
}