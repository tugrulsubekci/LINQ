using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> heroes = new List<string> { "D. Va", "Lucio", "Mercy", "Soldier 76", "Pharah", "Reinhardt" };

            // Approach 1: without LINQ
            List<string> longLoudHeroes = new List<string>();

            foreach (string hero in heroes)
            {
                if (hero.Length > 6)
                {
                    string formatted = hero.ToUpper();
                    longLoudHeroes.Add(formatted);
                }
            }

            // Approach 2: with LINQ
            var longLoudHeroes2 = from h in heroes
                                  where h.Length > 6
                                  select h.ToUpper();

            // Printing...
            Console.WriteLine("Your long loud heroes are...");

            foreach (string hero in longLoudHeroes2)
            {
                Console.WriteLine(hero);
            }
            Console.WriteLine("----------------------------------------");

            // var
            var shortHeroes = from h in heroes
                              where h.Length < 8
                              select h;

            foreach (var hero in shortHeroes)
            {
                Console.WriteLine(hero);
            }
            Console.WriteLine("----------------------------------------");

            var longHeroes = heroes.Where(n => n.Length > 8);

            Console.WriteLine(longHeroes.Count());
            Console.WriteLine("----------------------------------------");

            // Method and Query Syntax
            // Query syntax
            var queryResult = from x in heroes
                              where x.Contains("a")
                              select $"{x} contains an 'a'";

            // Method syntax
            var methodResult = heroes
              .Where(x => x.Contains("a"))
              .Select(x => $"{x} contains an 'a'");

            // Printing...
            Console.WriteLine("queryResult:");
            foreach (string s in queryResult)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("\nmethodResult:");
            foreach (string s in methodResult)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("----------------------------------------");
            // Basic Query Syntax

            //Write a from - where - select query that selects all of the elements in heroes that contain the character "i".
            //Store the result in a variable named heroesWithI.

            var heroesWithI = from h in heroes
                              where h.Contains("i")
                              select h;

            // Write a from - select query that returns the same array as heroes, but every space is replaced with an underscore(_).
            // Store the result in a variable named underscored.

            var underscored = from h in heroes
                              select h.Replace(" ", "_");

            // Basic Method Syntax: Where
            var heroesWithI2 = heroes.Where(x => x.Contains("i"));

            foreach (string s in heroesWithI2)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("----------------------------------------");

            // Basic Method Syntax: Select
            var heroesWithC = heroes.Where(x => x.Contains("c"));
            var lowerHeroesWithC = heroes.Select(x => x.ToLower());

            var sameResult = heroes
            .Where(x => x.Contains("c"))
            .Select(x => x.ToLower());

            foreach (string s in sameResult)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("----------------------------------------");

            // When To Use Each Syntax

            //Write a method-syntax query that transforms each element in heroes to this format:
            //Introducing...[HERO NAME] !
            var intro = heroes.Select(x => $"Introducing...{x}!");

            //Write a query-syntax query that selects elements containing a space and returns the index of the space in each element.
            //For example, instead of "D. Va", the result should contain 2.
            var intro2 = from h in heroes
                         where h.Contains(" ")
                         select h.IndexOf(" ");

            //Print out all of the elements of both query results to check your work.
            foreach (string s in intro)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("----------------------------------------");

            foreach (int i in intro2)
            {
                Console.WriteLine(i);
            }

            // LINQ with Other Collections

            List<string> heroesList = new List<string> { "D. Va", "Lucio", "Mercy", "Soldier 76", "Pharah", "Reinhardt" };

            var newHeroesList = from h in heroesList
                                where h.Contains(".") || h.Contains("7")
                                select h;

            //to keep console open
            Console.ReadLine();

            
            
        }
    }
}
