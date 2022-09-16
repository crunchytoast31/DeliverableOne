using System;

namespace DeliverableOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var response = "";

            do
            {
                Console.WriteLine("How many people are we making PB and J sandwiches for?");
                var peopleCount = Int32.Parse(Console.ReadLine());
                double totalSlicesNeeded = peopleCount * 2;
                double pbTbspNeeded = peopleCount * 2;
                double jellyTbspNeeded = peopleCount * 4;
                double Loaf = 28;
                double pbPerJar = 32;
                double jellyPerJar = 48;
                double totalLoavesNeeded = Math.Ceiling(totalSlicesNeeded / Loaf);
                double totalJarPbNeeded = Math.Ceiling(pbTbspNeeded / pbPerJar);
                double totalJarJellyNeeded = Math.Ceiling(jellyTbspNeeded / jellyPerJar);
                Console.WriteLine("You need" + totalSlicesNeeded + " slices of bread.");
                Console.WriteLine("You need" + pbTbspNeeded + "table spoons of peanut butter.");
                Console.WriteLine("You need" + jellyTbspNeeded + "teaspoons of jelly.");
                Console.WriteLine("which needs a total of" + totalLoavesNeeded + "loaves of bread");
                Console.WriteLine("which needs a total of" + totalJarPbNeeded + "jars of peanut butter");
                Console.WriteLine("which needs a total of" + totalJarJellyNeeded + "jars of jelly");
                Console.WriteLine("Would you like to restart? Enter yes or y to continue, or enter any other key to exit");
                response = Console.ReadLine();


            }
            while (response == "y" || response == "yes");

            Console.WriteLine("Goodbye!");
        }
    }
}
