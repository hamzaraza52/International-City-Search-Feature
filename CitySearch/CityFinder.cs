using System;
using System.Collections.Generic;
using System.Linq;

namespace CitySearch
{

    public class CityFinder : ICityFinder
{
        string[] testData = {
            "LAGOS",
            "LA PAZ",
            "LA PLATA",
            "LA-EPLATA",
            "LEEDS",
            "BANDUNG",
            "BANGUI",
            "BANGKOK",
            "BANGALORE",
            "ZARIA",
            "ZHUGHAI",
            "ZIBO"
        };

        HashSet<String> data;

        public CityFinder()
        {
            data = new HashSet<String>(testData);
        }

        public ICityResult Search(string searchString)
        {
            ICityResult result = new CityResult();
            int nextLetterIndex = searchString.Length;

            ICollection<string> contains = data.Where(s => s.ToLower().Contains(searchString.ToLower())).ToList();

            result.NextCities = contains;
            result.NextLetters = contains.Select(s => s[nextLetterIndex].ToString()).ToList();

            return result;
        }
    }
}