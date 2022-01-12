using System;
using Xunit;
using CitySearch;
using System.Runtime.CompilerServices;
using System.Diagnostics;

namespace CitySearch.Tests
{
    public class SearchTest
    {
        [Fact]
        public void Returns_Correct_city()
        {
            String searchTerm = "Lee";

            var finder = new CitySearch.CityFinder();
            var results = finder.Search(searchTerm);

            Assert.True(results.NextCities.Contains("LEEDS"));

        }
        [Fact]
        public void Returns_No_city_with_incorrect_search()
        {
            String searchTerm = "dammm";
            var finder = new CitySearch.CityFinder();
            var results =  finder.Search(searchTerm);
            Assert.True(results.NextCities.Count == 0);


        }
        [Fact]
        public void Returns_Correct_next_letter()
        {
            String searchTerm = "Lee";
            var finder = new CitySearch.CityFinder();
            var results = finder.Search(searchTerm);

            Assert.True(results.NextLetters.Contains("D"));

        }

    }
}
