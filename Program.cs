using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using MagicLandExplorer.Tasks;

namespace MagicLandExplorer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define the path to the JSON file
            string jsonFilePath = @"C:\Users\Student\Desktop\MagicLandExplorer\MagicLandExplorer\data\MagicLandData.json";

            // Ensure the file exists before attempting to read it
            if (!File.Exists(jsonFilePath))
            {
                Console.WriteLine($"Error: Could not find the JSON file at path: {jsonFilePath}");
                return;
            }

            // Load JSON data
            string json = File.ReadAllText(jsonFilePath);
            List<Category> categories = JsonConvert.DeserializeObject<List<Category>>(json);

            while (true)
            {
                Console.WriteLine("\nMagic Land Explorer");
                Console.WriteLine("1. Show filtered destinations");
                Console.WriteLine("2. Show destination with the longest duration");
                Console.WriteLine("3. Sort destinations by name");
                Console.WriteLine("4. Show top 3 longest-duration destinations");
                Console.WriteLine("5. Exit");
                Console.Write("Select an option: ");

                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        FilterDestinations.ShowFilteredDestinations(categories);
                        break;
                    case "2":
                        LongestDuration.filterlongestDestinations(categories);
                        break;
                    case "3":
                        SortByName.ShowSortedByName(categories);
                        break;
                    case "4":
                        Top3Duration.filterTop3Destinations(categories);
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        continue;
                }
            }
        }
    }
}
