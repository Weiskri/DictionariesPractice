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
            // Syntax - Dictionary <key data type, value data type> dictionaryname
            Dictionary<string, int> studentGrades = new Dictionary<string, int>()
            {
                {"Kerry", 90 }, // "kerry is the key", 90 is the value (her grade)
                {"Barry", 85 },
                {"Michelle", 100 }
            };

            Dictionary<string, string> snackMachine = new Dictionary<string, string>()
            {
                {"A1", "Snickers" },
                {"A2", "Swedish Fish" },
                {"A3", "Sour Patch Kids" },
                {"A4", "Funyuns" },

            };

            Dictionary<int, string> drinkMachine = new Dictionary<int, string>();
            // Using the Add method, let's add drinks to our drink machine.
            // This machine uses just a number to vend an item, instead of a letter-Number pair

            drinkMachine.Add(10, "Ginger Ale");
            drinkMachine.Add(11, "Coke");
            drinkMachine.Add(12, "Bottled water");
            drinkMachine.Add(13, "Orange soda");
            drinkMachine.Add(14, "Vitamin Water");
            drinkMachine.Add(15, "A&W Root Beer");

            // Count is a property. Returns the size of the dictionary.
            Console.WriteLine(drinkMachine.Count);

            // We have another property, called .Key
            foreach (KeyValuePair<int, string> drink in drinkMachine)
            {
                Console.WriteLine(drink.Key);
            }
            foreach (KeyValuePair<int, string> drink in drinkMachine)
            {
                Console.WriteLine(drink.Value);
            }

            // Create a dictionary for a theater coat check with 10 elements.
            // The key will be a number and the value will be the coat style.
            // Print all values to the console.

            Dictionary<int, string> coatCheck = new Dictionary<int, string>()
            {
                {1, "faux fur coat" },
                {2, "North Face coat" },
                {3, "pleather jacket" },
                {4, "parka" },
                {5, "faux wool coat" },
                {6, "Columbia jacket" },
                {7, "parka" },
                {8, "rain coat" },
                {9, "faux fur coat" },
                {10, "pleather jacket"}
            };

            foreach (KeyValuePair<int, string> coat in coatCheck)
            {
                Console.WriteLine(coat.Value);
            }

            // Create a dictionary for a car valet service with 10 cars.
            // The key will be the customer's last name and the value will be the car's make.
            // Print all keys to the console. 

            Dictionary<string, string> carValet = new Dictionary<string, string>()
            {
                {"Pullano", "Tesla" },
                {"Weis", "Audi" },
                {"Smith", "Lincoln" },
                {"Page", "Honda" },
                {"Johnson", "Land Rover" },
                {"Edison", "Toyota" },
                {"Marx", "Lotus" },
                {"Daniels", "AMG" },
                {"Robinson", "Kia" },
                {"Vivacqua", "Hyundai" },
            };

            foreach (KeyValuePair<string, string> car in carValet)
            {
                Console.WriteLine(car.Key);
            }

            // Create a dictionary of 10 zoo animals. The key will be the animal type and the value
            // will be the number of that animal type at the zoo.
            // Print the animal with the highest quantity to the console.

            Dictionary<string, int> zooAnimals = new Dictionary<string, int>()
            {
                {"llama", 1 },
                {"rabbit", 2 },
                {"sun bear", 3 },
                {"giraffe", 4 },
                {"zebra", 5 },
                {"panda", 6 },
                {"sloth", 7 },
                {"toucan", 8 },
                {"jaguar", 9 },
                {"armadillo", 10 }
            };

            int highest = 0;
            foreach (KeyValuePair<string, int> animal in zooAnimals)
            {
                if (animal.Value > highest)
                {
                    highest = animal.Value;
                }
            }

            Console.WriteLine(highest);
            
            foreach(KeyValuePair<string, int> animal in zooAnimals)
            {
                if (animal.Value == highest)
                {
                    Console.WriteLine(animal.Key);
                }
            }
           
        }
    }
}
