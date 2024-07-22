using System;
using System.Collections.Generic;
using System.Linq;

namespace MagicLandExplorer.Tasks
{
    public class Top3Duration
    {
        public static void filterTop3Destinations(List<Category> filedata)
        {
            var top3 = (from data in filedata
                        from destination in data.Destinations
                        where destination.Duration != null
                        orderby int.Parse(destination.Duration.Split(' ')[0]) descending
                        select destination).Take(3);

            Console.WriteLine("\nTop 3 Longest Duration Destinations:");
            foreach (var destination in top3)
            {
                Console.WriteLine($"{destination.Name} - {destination.Duration}");
            }
        }
    }
}
