using System;
using System.Collections.Generic;
using System.Linq;

namespace MagicLandExplorer.Tasks
{
    public class LongestDuration
    {
        public static void filterlongestDestinations(List<Category> filedata)
        {
            var result = (from data in filedata
                          from destination in data.Destinations
                          where destination.Duration != null
                          orderby int.Parse(destination.Duration.Split(' ')[0]) descending
                          select destination.Name).FirstOrDefault();

            Console.WriteLine("\nLongest Destination Name:");
            Console.WriteLine(result);
        }
    }
}
