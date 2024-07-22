using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicLandExplorer.Tasks
{
    namespace MagicLandExplorer.Tasks
    {
        public class FilterDestinations
        {
            // Find all destinations with a duration less than 100 minutes
            public static void ShowFilteredDestinations(List<Category> filedata)
            {
                var result = from data in filedata
                             from destination in data.Destinations
                             let duration = int.TryParse(destination.Duration.Split(' ')[0], out int parsedDuration) ? parsedDuration : 0
                             where duration < 100
                             select destination.Name;

                Console.WriteLine("\n1. Destinations with duration less than 100 minutes:");
                foreach (var name in result)
                {
                    Console.WriteLine(name);
                }
            }
        }
    }
}