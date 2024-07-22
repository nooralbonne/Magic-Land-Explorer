using System;
using System.Collections.Generic;
using System.Linq;

namespace MagicLandExplorer.Tasks
{
    public class Top3Duration
    {
        // Find the top three longest-duration destinations and show their names and durations
        public static void ShowTop3Duration(List<Category> filedata)
        {
            var result = (from data in filedata
                          from destination in data.Destinations
                          let duration = int.TryParse(destination.Duration.Split(' ')[0], out int parsedDuration) ? parsedDuration : 0
                          orderby duration descending
                          select new { destination.Name, Duration = duration }).Take(3);

            Console.WriteLine("\n4. Top 3 longest-duration destinations:");
            foreach (var dest in result)
            {
                Console.WriteLine($"{dest.Name} - {dest.Duration} minutes");
            }
        }
    }
}
