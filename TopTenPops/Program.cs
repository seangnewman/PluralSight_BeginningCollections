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

            Country[] countries = reader.ReadFirstNCountries(10);

            foreach (var country in countries)
            {
                //Console.WriteLine($"{country.Population}: {country.Name}");
                Console.WriteLine($"{PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)} : {country.Name}");
            }
        }
    }
}
