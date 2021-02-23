using System;
using System.Collections.Generic;
using System.Numerics;

namespace H1___Planeterne
{
    class Program
    {
        public static void Main(string[] args)
        {

            // oprette en liste med alle planeter

            List<string> planets = new List<string> { "Merkur", "Jorden", "Mars", "Jupiter", "Saturn", "Uranus", "Neptun", "Pluto" };
            planets.Add("Venus");
            planets.RemoveAt(7);
            planets.Add("Pluto");

            //Tæl planeterne
            Console.WriteLine("Antal planeter: " + planets.Count);


            //Fjern alle planeterne
           //Planets.Clear();

            foreach (string name in planets)
                Console.WriteLine(name + " ");
        }
    }
}
