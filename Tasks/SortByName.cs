using System;
using System.Collections.Generic;
using System.Linq;

namespace MagicLandExplorer.Tasks
{
    public class SortByName
    {
        // Sort destinations alphabetically by their name
        public static void ShowSortedByName(List<Category> filedata)
        {
            var result = from data in filedata
                         from destination in data.Destinations
                         orderby destination.Name
                         select destination.Name;

            Console.WriteLine("\n3. Destinations sorted alphabetically by name:");
            foreach (var name in result)
            {
                Console.WriteLine(name);
            }
        }
    }
}
