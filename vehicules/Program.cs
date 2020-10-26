using System;

namespace vehicules
{
    class Program
    {
        static Vehicule monVehicule;
        static Vehicule tonVehicule;

        static void Main(string[] args)
        {
            Console.WriteLine("Programme Véhicule !");

            monVehicule = new Vehicule("Jaune", 50);
            monVehicule.Accelerer();

            tonVehicule = new Vehicule("Bleu", 120);          
            tonVehicule.Accelerer();

            /*monVehicule.Demarrer();
            monVehicule.Accelerer();
            monVehicule.Avancer();
            monVehicule.Ralentir();
            monVehicule.Arreter();*/

            Console.ReadLine();

        }
    }
}
