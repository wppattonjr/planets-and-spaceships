using System;
using System.Collections.Generic;
using System.Linq;

namespace PlanetsAndSpaceships
{
    class Program
    {
        static void Main(string[] args)
        {
            var planetList = new List<string>() { "Mercury", "Mars" };

            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            var lastTwoPlanets = new List<string>() { "Uranus", "Neptune" };
            planetList.AddRange(lastTwoPlanets);
            planetList.Insert(2, "Earth");
            planetList.Insert(1, "Venus");
            planetList.Add("Pluto");
            var rockyPlanets = planetList.GetRange(0, 3);
            planetList.Remove("Pluto");

            var spacecraft = new Dictionary<string, List<string>>();
            {
                spacecraft.Add("Mercury", new List<string> { "Apollo", "Mercury", "Gemini"  });
                spacecraft.Add("Venus", new List<string> { "Shenzhou", "Crew Dtragon", "Atlantis","Voskhod" });
                spacecraft.Add("Earth", new List<string> { "Soyuz", "Space Shuttle"});
                spacecraft.Add("Mars", new List<string> { "Mars 6", "Phobos", "Beagle 2", "Phoenix Lander", "Mars Polar Lander"});
                spacecraft.Add("Jupiter", new List<string> {"Pioneer 5", "Helios A", "SOHO", "ACE"});
                spacecraft.Add("Saturn", new List<string> { "DSCOVR", "Parker Solar Probe", "Mariner 10" });
                spacecraft.Add("Uranus", new List<string> { "Sputnik 19", "Venera", "BepiColombo" });
                spacecraft.Add("Neptune", new List<string>{ "Magellan", "Cassini", "Venus Express", "JUICE" });
            }

            foreach(var key in spacecraft.Keys)
            {
                Console.WriteLine($"{key}");
                foreach (var value in spacecraft[key])
                {
                    Console.WriteLine($"Planet: {key} Spacecraft: {value}");
                }
            }







        }
    }
}
