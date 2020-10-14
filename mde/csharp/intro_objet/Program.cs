using System;

namespace intro_objet
{
    class Program
    {
        static Vehicule velo;
        static Vehicule moto;

        static void Main(string[] args)
        {
            Console.WriteLine("Intro Objet !");

            velo = new Vehicule("Vélo électrique", "Rouge");

            moto = new Vehicule("Moto à 3 roues", "Noire");

            Console.WriteLine(velo.GetGenre());
            Console.WriteLine(moto.GetGenre());

        }
    }
}
