using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictSnippets
{
    class Program
    {
        static void Main(string[] args)
        {
            Country norway = new Country("Norway", "NOR", "Europe", 5_282_223);
            Country finland = new Country("Finland", "FIN", "Europe", 5_511_303);

            var countries = new Dictionary<string, Country>
            {
                { norway.Code, norway },
                { finland.Code, finland }
            };

            bool exists = countries.TryGetValue("MUS", out Country country);
            if (exists)
            {
                Console.WriteLine(country.Name);
            }
            else
            {
                Console.WriteLine("There is no country with the code MUS");
            }

            //Console.WriteLine(countries["MUS"].Name);   // Throws exception

            ////Country selectedCountry = countries["NOR"];
            ////Console.WriteLine(selectedCountry.Name);

            //foreach (var country in countries.Values)
            //{
            //    Console.WriteLine(country.Name);
            //}

            //foreach (var keys in countries.Keys)
            //{
            //    Console.WriteLine(countries[keys].Name);
            //}

            //List<Country> countriesList = new List<Country>();
            //countriesList.Add(norway);
            //countriesList.Add(norway);

            //foreach (var country in countriesList)
            //{
            //    Console.WriteLine(country.Name);
            //}

        }
    }
}
