using System;
using System.Collections.Generic;


namespace dictionaries {
    class Program {
        static void Main (string[] args) {

            // Create dictionary named stocks containing strings
            Dictionary<string, string> stocks = new Dictionary<string, string> ();

            // Add key value pairs to stocks dictionary
            stocks.Add ("CGC", "Canopy Growth");
            stocks.Add ("RDWR", "Radware");
            stocks.Add ("CY", "Cypress Semiconductor");
            stocks.Add ("CRON", "Cronos Group");
            stocks.Add ("SSTI", "ShotSpotter");

            // Find value of dictionary pairs
            string CGC = stocks["CGC"];
            string RDWR = stocks["RDWR"];
            string CY = stocks["CY"];
            string CRON = stocks["CRON"];
            string SSTI = stocks["SSTI"];

            // List to hold stock purchases
            List<Dictionary<string, double>> purchases = new List<Dictionary<string, double>> ();

            // Add stock purchases
            purchases.Add (new Dictionary<string, double> () { { "CGC", 141.93 } });
            purchases.Add (new Dictionary<string, double> () { { "RDWR", 47.54 } });
            purchases.Add (new Dictionary<string, double> () { { "CY", 13.73 } });
            purchases.Add (new Dictionary<string, double> () { { "CY", 68.65 } });
            purchases.Add (new Dictionary<string, double> () { { "CRON", 9.72 } });
            purchases.Add (new Dictionary<string, double> () { { "SSTI", 47.64 } });
            purchases.Add (new Dictionary<string, double> () { { "SSTI", 95.28 } });

            // Create dictionary for all stocks
            Dictionary<string, double> stockReport = new Dictionary<string, double> ();

            // Iterate purchased stock amounts through a dictionary
            foreach (Dictionary<string, double> purchase in purchases) {
                {
                    // Iterate key value pairs of dictionary
                    foreach (KeyValuePair<string, double> stock in purchase) {
                        
                        // Create a string for the company name to reference the key of the stocks dictionary
                        string companyName = stocks[stock.Key];
                        
                        // Create conditional checking if stockReport contains companyName as its key
                        if(stockReport.ContainsKey(companyName)) {
                            // If true, add the value of each stock to each companyName key
                            stockReport[companyName] += stock.Value;
                        } else {
                            // If false, make companyName equal to the value of each stock
                            stockReport[companyName] = stock.Value;
                        }

                    }
                }
            }
            // Loop through key value pairs of stockReport
            foreach (KeyValuePair<string, double> item in stockReport) {
                // Output string containing key and values of stock report to the console.
                Console.WriteLine ($"The position in {item.Key} is worth {item.Value}");
            }
        }
    }
}