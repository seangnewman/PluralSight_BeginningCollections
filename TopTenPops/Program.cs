using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopTenPops
{
    class Program
    {
        static void Main(string[] args)
        {

            string filePath = @"C:\Users\Sean\Source\Repos\PluralSight_BeginningCollections\TopTenPops\Pop by Largest Final.csv";
            CsvReader reader = new CsvReader(filePath);

            //Country[] countries = reader.ReadFirstNCountries(10);
            //List<Country> countries = reader.ReadAllCountries();
            Dictionary<string, Country> countries = reader.ReadAllCountries();

            Console.WriteLine("Which country code do you want to look up? ");
            string userInput = Console.ReadLine();

            bool gotCountry = countries.TryGetValue(userInput, out Country country);

            if (!gotCountry)
            {
                Console.WriteLine($"Sorrry, there is no country code with the value {userInput}");
            }
            else
            {
                Console.WriteLine($"{country.Name} has a population {PopulationFormatter.FormatPopulation(country.Population)}");
            }

            Console.WriteLine($"{countries.Count} countries");
        }
    }
}
