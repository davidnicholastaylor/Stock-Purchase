using System;

namespace dictionaries {
    class Program {
        static void Main (string[] args) {

            // Create dictionary named stocks containing strings
            Dictionary<string, string> stocks = new Dictionary<string, string> ();

            // Add key valur pairs to stocks dictionary
            stocks.Add ("CGC", "Canopy Growth");
            stocks.Add ("RDWR", "Radware");
            stocks.Add ("CY", "Cypress Semiconductor");
            stocks.Add ("CRON", "Cronos Group");
            stocks.Add ("SSTI", "ShotSpotter");

        }
    }
}