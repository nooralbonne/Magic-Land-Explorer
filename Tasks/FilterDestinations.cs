using System;
using System.Collections.Generic;
using System.Linq;

namespace MagicLandExplorer.Tasks
{
    public class FilterDestinations
    {
        public static void ShowFilteredDestinations(List<Category> categories)
        {
            var filteredDestinations = from category in categories
                                       from destination in category.Destinations
                                       where destination.Duration != null && destination.Duration != ""
                                       select destination;

            Console.WriteLine("\nFiltered Destinations:");
            foreach (var destination in filteredDestinations)
            {
                Console.WriteLine($"- {destination.Name} ({destination.Duration})");
            }
        }
    }
}
