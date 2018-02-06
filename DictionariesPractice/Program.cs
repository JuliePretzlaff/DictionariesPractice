using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionariesPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //syntax: Dictionary<key data type, value data type> dictionaryName = new Dictionary<string, int>()

            Dictionary<string, int> studentGrades = new Dictionary<string, int>()
            {
                {"Kerry", 90},
                {"Barry", 85 },
                {"Michelle", 100 }
            };

            Dictionary<string, string> vendingMachine = new Dictionary<string, string>()
            {
                {"A1", "Snickers" },
                {"A2", "Swedish Fish" },
                { "A3", "Sour Patch Kids"},
                {"A4", "Funions" }
            };

            //empty dictionary:
            Dictionary<int, string> drinkMachine = new Dictionary<int, string>();
            //using Add method, add drinks to this dictionary:
            //this machine uses just a number to vend an item instead of a letter/number combo

            drinkMachine.Add(10, "Ginger Ale");
            drinkMachine.Add(11, "Pepsi");
            drinkMachine.Add(12, "Coke");
            drinkMachine.Add(13, "Root Beer");
            drinkMachine.Add(14, "Sprite");
            drinkMachine.Add(15, "Iced Tea");

            //count is a property, returns size:
            Console.WriteLine(drinkMachine.Count);

            //.Key property:
            foreach (KeyValuePair<int, string> drink in drinkMachine)
            {
                Console.WriteLine(drink.Key);
            }
            foreach (KeyValuePair<int, string> drink in drinkMachine)
            {
                Console.WriteLine(drink.Value);
            }

            //create coatcheck dictionary.  int, "coat style".  then print all values:
            Dictionary<int, string> coatCheck = new Dictionary<int, string>()
            {
                {01, "down coat" },
                {02, "rain coat" },
                {03, "yellow coat" },
                {04, "Columbia coat" },
                {05, "Patagucci coat" },
                {06, "blue rain coat" },
                {07, "leather coat" },
                {08, "long jacket" },
                {09, "ski jacket" },
                {10, "carhart" }
            };
            foreach (KeyValuePair<int, string> coat in coatCheck)
            {
                Console.WriteLine(coat.Value);
            }

            //car valet dictionary:
            Dictionary<string, string> carValet = new Dictionary<string, string>()
            {
                {"Smith", "Toyota" },
                {"Steven", "Toyota" },
                {"Lock", "Ford" },
                {"John", "Telsa" },
                {"Johnston", "Jeep" },
                {"Scott", "Lincoln" },
                {"Adam", "BMW" },
                {"Smithers", "Tesla" },
                {"Mermaid", "Hundai" },
                {"Meg", "Honda" }
            };

            //zoo animals dictionary
            Dictionary<string, int> zooAnimals = new Dictionary<string, int>()
            {
                {"lion", 4 },
                {"penguin", 20 },
                {"sloth", 7 },
                {"zebra", 12 },
                {"elephant", 15 },
                {"alligator", 12 },
                {"ant eater", 3 },
                {"butterfly", 100 },
                {"lemur", 6 },
                {"snow leopard", 2 },
            };

            Console.WriteLine("There are currently {0} types of animals at the zoo.", zooAnimals.Count);



            //to print the highest quantity:
            int highest = 0;

            foreach (KeyValuePair<string, int> animal in zooAnimals)
            {
                if (animal.Value > highest)
                {
                    highest = animal.Value;
                }
            }
            foreach (KeyValuePair<string, int> animal in zooAnimals)
            {
                if (animal.Value == highest)
                    Console.WriteLine("The animal with the highest population at the zoo: " + animal.Key);
            }

            //remove lowest quantity animal:
            int lowest = highest;
            foreach (KeyValuePair<string, int> animal in zooAnimals)
            {
                if (animal.Value < lowest)
                {
                    lowest = animal.Value;
                }
            }
            string lowestAnimalPop = "0";
            foreach (KeyValuePair<string, int> animal in zooAnimals)
            {
                if (animal.Value == lowest)
                {
                    Console.WriteLine("the animal with the lowest population is the " + animal.Key);
                    lowestAnimalPop = animal.Key;
                    
                }
            }
            zooAnimals.Remove(lowestAnimalPop);

            //count remaining and print to console
            Console.WriteLine("You moved an animal to another zoo, now there are {0} types of animals.", zooAnimals.Count);


            //allow user to input animal name and check to see if dictionary contains that animal
            //ask user if they'd like to add any animal that doesn't exist in dictionary

            Console.WriteLine("Please type the name of the animal you'd like to check: ");
            string userAnimal = Console.ReadLine();
            if (zooAnimals.ContainsKey(userAnimal) == true)
            {
                Console.WriteLine("{0} is in the dictionary.", userAnimal);
            }
            else
            {
                Console.WriteLine("This animal is not in the dictionary.  Would you like to add it?");
                string userAnswer = Console.ReadLine().ToLower();
                if (userAnswer == "yes")
                {
                    Console.WriteLine("How many animals of that type are there?");
                    int populationUserAnswer = int.Parse(Console.ReadLine());
                    zooAnimals.Add(userAnimal, populationUserAnswer);
                }
                else if (userAnswer == "no")
                {
                    Console.WriteLine("Ok, we won't add it.");
                }
                else
                {
                    Console.WriteLine("invalid response!");
                }
            }

        }
    }
}
