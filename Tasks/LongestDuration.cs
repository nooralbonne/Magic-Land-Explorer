using System;
using System.Collections.Generic;
using System.Linq;

namespace MagicLandExplorer.Tasks
{
    public class LongestDuration
    {
        // Find and display name of the destination with the longest duration among all categories
        public static void ShowLongestDuration(List<Category> filedata)
        {
            var result = (from data in filedata
                          from destination in data.Destinations
                          let duration = int.TryParse(destination.Duration.Split(' ')[0], out int parsedDuration) ? parsedDuration : 0
                          orderby duration descending
                          select destination.Name).FirstOrDefault();

            Console.WriteLine("\n2. Longest Destination Name:");
            Console.WriteLine(result ?? "No valid destination found.");
        }
    }
}
