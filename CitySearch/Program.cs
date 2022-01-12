using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using CitySearch;

[assembly: InternalsVisibleTo("CitySearch.Tests")]
namespace CitySearch
{
    class Program
    {
        static void Main(string[] args)
        {
          String searchTerm = "lee";
		
		CitySearch.CityFinder myFinder = new CitySearch.CityFinder();
		CitySearch.ICityResult myResults = myFinder.Search(searchTerm);

        Debug.WriteLine(" Search Results for: " + searchTerm );
            Debug.WriteLine(" The Next City Results Are: " + myResults.NextCities.Count);

		foreach (string cityName in  myResults.NextCities) {
                Debug.WriteLine(cityName);
		}
            Debug.WriteLine(" The Next Letter Could Be : " + myResults.NextLetters.Count);
        foreach (string letter in  myResults.NextLetters) {
                Debug.WriteLine(letter);
		}
        }
    }
}
