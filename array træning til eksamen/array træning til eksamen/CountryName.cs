using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_træning_til_eksamen
{
    public class CountryName

    {
        

        public string[] countryArray = new string[] { "Norway", "Italy", "Belgium", "Germany", null, null, null, null, null, null };
        public CountryName() { } 
        

        public bool ContainsCountry(string country)
        {
            return countryArray.Contains(country);
            


        }
        public int Count()
        {
            
                return countryArray.Count(x=> x != null);
            
        }
              
        public string RemoveCountry(string country)
        {
             for (int i = 0; i < countryArray.Length; i++)
            {
                if (countryArray[i] == country)
            {
                    countryArray[i] = null;
            }
                
            
            }
            return $"landet: {country} er slettet";
            
        }

        public string Add(int index, string country)
        {
            
            for (int i = 0; i < countryArray.Length; i++)
            {
                if (countryArray[i] == null)
                {
                    index++;
                }

                else if (countryArray[i] == countryArray.Length)
                {
                    countryArray[i] = countryArray[0];
                }
                countryArray[i] = country;

                


            }
        }
    }
} //$"landet:{country} er blevet slettet";
