using System;
using System.Linq;

namespace Modul_2_Opgaver
{
    internal class Program
    {
        class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string Phone { get; set; }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Person[] people = new Person[]
            {
                new Person { Name = "Jens Hansen", Age = 45, Phone = "+4512345678" },
                new Person { Name = "Jane Olsen", Age = 22, Phone = "+4543215687" },
                new Person { Name = "Tor Iversen", Age = 35, Phone = "+4587654322" },
                new Person { Name = "Sigurd Nielsen", Age = 31, Phone = "+4512345673" },
                new Person { Name = "Viggo Nielsen", Age = 28, Phone = "+4543217846" },
                new Person { Name = "Rosa Jensen", Age = 23, Phone = "+4543217846" },
            };
            //opgave 1.1
            /* int totalAge = 0;

             for (int i = 0; i < people.Length; i++)
             {
                 totalAge += people[i].Age;
             }
            */



            int totalAge = people.Sum(x => x.Age);
            
            Console.WriteLine("Total Age: " + totalAge);

            //opgave 1.2
            // Tæller hvor mange der hedder "Nielsen"
            /*
            int countNielsen = 0;
            for (int i = 0; i < people.Length; i++)
            {
                if (people[i].Name.Contains("Nielsen"))
                {
                    countNielsen++;
                }
            } */

            int countNielsen = people.Count(x => x.Name.Contains("Nielsen"));

            Console.WriteLine(countNielsen);

            //opgave 1.3
            // Find den ældste person
            /*Person oldestPerson = null;
            for (int i = 0; i < people.Length; i++)
            {
                if (oldestPerson == null || people[i].Age > oldestPerson.Age)
                {
                    oldestPerson = people[i];
                }
            }*/

            int oldestPerson = people.Max(x => x.Age);

            Console.WriteLine(oldestPerson);


            //Opgave 2.1

            var findNumber = people.FirstOrDefault(x => x.Phone == "+4543215687").Name;
            Console.WriteLine(findNumber);

            //opgave 2.2
            var Older30 = people.Where(x => x.Age > 30);
            var Older30func = Older30.Select(x => x.Name);

            Console.WriteLine(string.Join(", ", Older30func));

            //opgave 2.3
            
            var nytarray = people.Select(x => new Person {Name = x.Name, Age = x.Age, Phone = x.Phone.Replace("+45", "" )});

            Console.WriteLine(string.Join(", ", nytarray.Select(x => x.Name + " " + x.Phone)));

            //opgave 2.4

            var younger30 = people.Where(x => x.Age < 30);
            var younger30func = younger30.Select(x => $"{x.Name} { x.Age} {x.Phone}");

            Console.WriteLine(string.Join(", ", younger30func));


            //opgave 3.
            var CreateWordFilterFn = (string[] words) =>
            {
                 
                return (string text) =>
                {
                    
                    var filteredWords = string.Join(" ", text.Split(' ').Where(word => !words.Contains(word)));

                    return filteredWords;
                };

            };

            var CreateWordReplacerFn = (string[] words, string replacementWord) =>
            {
                return (string sentence) =>
            {
                var replacedWords = string.Join(" ", sentence.Split(' ').Select(word => words.Contains(word) ? replacementWord : word));

                return replacedWords;
            };
            };


             var badWords = new string[] { "shit", "fuck", "idiot", "lort" };
             var FilterBadWords = CreateWordReplacerFn(badWords, "kage");
             Console.WriteLine(FilterBadWords("Sikke en gang lort"));
             // Udskriver: "Sikke en gang kage"

            //opgave 4


            }
        }

    }








