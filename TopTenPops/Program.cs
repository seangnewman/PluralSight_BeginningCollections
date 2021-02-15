﻿using System;
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
            List<Country> countries = reader.ReadAllCountries();
            #region ReadAllCountries() lookup using Dictionary
            //Dictionary<string, Country> countries = reader.ReadAllCountries();

            //Console.WriteLine("Which country code do you want to look up? ");
            //string userInput = Console.ReadLine();

            //bool gotCountry = countries.TryGetValue(userInput, out Country country);

            //if (!gotCountry)
            //{
            //    Console.WriteLine($"Sorrry, there is no country code with the value {userInput}");
            //}
            //else
            //{
            //    Console.WriteLine($"{country.Name} has a population {PopulationFormatter.FormatPopulation(country.Population)}");
            //}
            #endregion
            #region foreach (var country in countries)
            //foreach (var country in countries)
            //{
            //    Console.WriteLine($"{PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)}: {country.Name}");
            //}
            #endregion

            #region loop termination conditions
            //for (int i = 0; i < countries.Count; i++)
            //{
            //    Country country = countries[i];
            //    Console.WriteLine($"{PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)}: {country.Name}");
            //}
            #endregion

            #region iterating only some items
            //Console.WriteLine("Enter number of countries to display > ");
            //bool inputIsInt = int.TryParse(Console.ReadLine(), out int userInput);

            //if( !inputIsInt || userInput <= 0)
            //{
            //    Console.WriteLine("You must type in a positive integer.  Exiting");
            //    return;
            //}

            //int maxToDisplay = Math.Min(userInput, countries.Count);

            //for (int i = 0; i < maxToDisplay; i++)
            //{
            //    Country country = countries[i];
            //    Console.WriteLine($"{PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)}: {country.Name}");
            //}

            #endregion

            #region Batching an iteration
            //Console.WriteLine("Enter number of countries to display > ");
            //bool inputIsInt = int.TryParse(Console.ReadLine(), out int userInput);

            //if (!inputIsInt || userInput <= 0)
            //{
            //    Console.WriteLine("You must type in a positive integer.  Exiting");
            //    return;
            //}

            //int maxToDisplay = userInput;

            //for (int i = 0; i < countries.Count; i++)
            //{
            //    if (i > 0 && (i % maxToDisplay == 0))
            //    {
            //        Console.WriteLine("Hit return to continue, anything else to quit :");
            //        if (Console.ReadLine() != "")
            //        {
            //            break;
            //        }
            //    }
            //    Country country = countries[i];
            //    Console.WriteLine($"{PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)}: {country.Name}");
            //}

            #endregion

            #region Displaying the Order when Enumerating
            //Console.WriteLine("Enter number of countries to display > ");
            //bool inputIsInt = int.TryParse(Console.ReadLine(), out int userInput);

            //if (!inputIsInt || userInput <= 0)
            //{
            //    Console.WriteLine("You must type in a positive integer.  Exiting");
            //    return;
            //}

            //int maxToDisplay = userInput;

            //for (int i = 0; i < countries.Count; i++)
            //{
            //    if (i > 0 && (i % maxToDisplay == 0))
            //    {
            //        Console.WriteLine("Hit return to continue, anything else to quit :");
            //        if (Console.ReadLine() != "")
            //        {
            //            break;
            //        }
            //    }
            //    Country country = countries[i];
            //    Console.WriteLine($"{i + 1} : {PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)}: {country.Name}");
            //}

            #endregion

            #region Enumerating Backwards
            //Console.WriteLine("Enter number of countries to display > ");
            //bool inputIsInt = int.TryParse(Console.ReadLine(), out int userInput);

            //if (!inputIsInt || userInput <= 0)
            //{
            //    Console.WriteLine("You must type in a positive integer.  Exiting");
            //    return;
            //}

            //int maxToDisplay = userInput;

            //for (int i = countries.Count - 1; i >= 0 ; i--)
            //{
            //    int displayIndex = countries.Count - 1 - i;
            //    if (displayIndex > 0 && (displayIndex % maxToDisplay == 0))
            //    {


            //        Console.WriteLine("Hit return to continue, anything else to quit :");
            //        if (Console.ReadLine() != "")
            //        {
            //            break;
            //        }
            //    }
            //    Country country = countries[i];
            //    Console.WriteLine($"{displayIndex + 1} : {PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)}: {country.Name}");
            //}
            #endregion

            #region Systematically Removing Elements and keeping the index in sync

            reader.RemoveCommaCountries(countries);

            Console.WriteLine("Enter number of countries to display > ");
            bool inputIsInt = int.TryParse(Console.ReadLine(), out int userInput);

            if (!inputIsInt || userInput <= 0)
            {
                Console.WriteLine("You must type in a positive integer.  Exiting");
                return;
            }

            int maxToDisplay = userInput;

            for (int i = 0; i < countries.Count; i++)
            {
                if (i > 0 && (i % maxToDisplay == 0))
                {
                    Console.WriteLine("Hit return to continue, anything else to quit :");
                    if (Console.ReadLine() != "")
                    {
                        break;
                    }
                }
                Country country = countries[i];
                Console.WriteLine($"{i + 1} : {PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)}: {country.Name}");
            }
            #endregion
            #region Removing elements with RemoveAll
            #endregion
            // Console.WriteLine($"{countries.Count} countries");
        }
    }
}
