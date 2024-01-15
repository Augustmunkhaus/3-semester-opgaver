using System;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace array_træning_til_eksamen
{
    internal class Program
    {
        
            static void Main(string[] args)
            {
            CountryName countries = new CountryName();

            Console.WriteLine(countries.ContainsCountry("Norway"));
            Console.WriteLine(countries.Count());
            Console.WriteLine(countries.RemoveCountry("Belgium"));
            Console.WriteLine(string.Join(", ", countries.countryArray));
            Console.WriteLine(countries.Add(5,"Grønland"));

        }
            
                /*
                            public void Add(int index, string country)
                                {
                                int Index = 0;
                                foreach(var i in country)
                                {
                                    if (Name != null)
                                    {
                                        Index++;
                                    }
                                    else if (Name == null)

                                    {
                                        Name.Replace(null, Name);
                                    }
                                    else Console.WriteLine("fejl");
                                }
                */
                /*
                public bool ContainsCountry(string country)
                {
                    int index = 0;
                    while (index != null)
                    {
                        if (country.Name.Equals("Norway"))
                        {
                            return true;
                        }

                        index++;
                    }

                    return false;
                }
                */
              
        }

            }

        
        
    


/*
                public void RemoveCountry(string country)
                {
                    foreach (var i in countries)
                    {
                        if(countries.Equals(Name))
                        {
                            countries.Name.Replace(Name, null);
                        }

                    }
                }

                public int Count();
                {
                    int antal = 0;
                       while(antal < countries.Length )
                    {
                        antal++;
                    }
                    return antal;
                }
        }
        
            
                


        static void Main(string[] args)
        {
                Console.WriteLine(Add(index,"USA"));

            }

        }
    }




    

}*/