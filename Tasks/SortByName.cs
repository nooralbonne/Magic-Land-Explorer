using System;
using System.Collections.Generic;
using System.Linq;

namespace MagicLandExplorer.Tasks
{
    public class SortByName
    {
        public static void ShowSortedByName(List<Category> categories)
        {
            var sortedDestinations = from category in categories
                                     from destination in category.Destinations
                                     orderby destination.Name
                                     select destination;

            Console.WriteLine("\nDestinations Sorted by Name:");
            foreach (var destination in sortedDestinations)
            {
                Console.WriteLine($"- {destination.Name}");
            }
        }
    }
}
