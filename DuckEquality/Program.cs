using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckEquality
{
    class Program
    {
        static void Main(string[] args)
        {
            var quack = new Ducks("Sgt QuackAlot", "Mallard", 100, 17);
            var quackers = new Ducks("Pvt Quackish", "Crested", 200, 12);
            var quacky = new Ducks("Cpl QuackAttack", "Ancona", 150, 20);
            var quavers = new Ducks("Cpt Quaver", "Marbled", 125, 10);
            var quackula = new Ducks("Mjr Quakula", "Albio", 110, 18);


            Dictionary<Ducks, int> DuckDiction = new Dictionary<Ducks, int>();
            List<Ducks> DuckList = new List<Ducks>();

            DuckList.Add(quack);
            DuckList.Add(quackers);
            DuckList.Add(quacky);
            DuckList.Add(quavers);
            DuckList.Add(quackula);
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Ducks have been added to a list.");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            foreach (var duck in DuckList)
            {
                Console.WriteLine(duck.Name);
            }
            DuckList.Sort(new NameComparer());
            foreach (var duck in DuckList)
            {
                Console.WriteLine(duck.ToString());
            }
            WeightComparer sortByWeight = new WeightComparer();
            DuckList.Sort(sortByWeight);

            Console.ResetColor();
            Console.WriteLine("========================================");
            Console.WriteLine("List of Ducks Ordered By Weight");
            Console.WriteLine("========================================");

            foreach (var duck in DuckList)
            {
              
                Console.WriteLine(duck.ToString());
            }

            Console.ReadLine();
        }
    }
}
