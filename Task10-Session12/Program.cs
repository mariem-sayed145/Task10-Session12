using Day_01_G03;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static Day_01_G03.ListGenerator;
using static System.Net.WebRequestMethods;


namespace Task10_Session12
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Restriction Operators 
            //// 1- Find all products that are out of stock.

            //// fluent syntax

            //Console.WriteLine("Out of Stock Products:(fluent syntax)\n");

            //var outOfStockProducts = ProductsList.Where(p => p.UnitsInStock == 0);
            //foreach (var product in outOfStockProducts)
            //{
            //    Console.WriteLine($"Product: {product.ProductName}, UnitsInStock: {product.UnitsInStock}");
            //}

            //Console.WriteLine("\n Out of Stock Products:(query syntax)\n");
            ////query syntax
            //var outOfStockProductsQuery = from p in ProductsList
            //                              where p.UnitsInStock == 0
            //                              select p;

            //foreach (var product in outOfStockProductsQuery)
            //{
            //    Console.WriteLine($"Product: {product.ProductName}, UnitsInStock: {product.UnitsInStock}");
            //}


            //// 2- Find all products that are in stock and cost more than 3.00 per unit.

            //// fluent syntax
            //Console.WriteLine("Out of Stock Products:(fluent syntax)\n");

            //var inStockProducts = ProductsList.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3.00m);

            //foreach (var product in inStockProducts)
            //{
            //    Console.WriteLine($"Product: {product.ProductName}, UnitsInStock: {product.UnitsInStock}, UnitPrice: {product.UnitPrice}");
            //}

            //// query syntax

            //Console.WriteLine("\n In Stock Products:(query syntax)\n");

            //var inStockProductsQuery = from p in ProductsList
            //                           where p.UnitsInStock > 0 && p.UnitPrice > 3.00m
            //                           select p; 

            //foreach (var product in inStockProductsQuery)
            //{
            //    Console.WriteLine($"Product: {product.ProductName}, UnitsInStock: {product.UnitsInStock}, UnitPrice: {product.UnitPrice}");
            //}

            //// 3- Returns digits whose name is shorter than their value. String [] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

            //String[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var shortDigits = Arr.Where((digit, index) => digit.Length < index);

            //Console.WriteLine("\n Digits whose name is shorter than their value:\n");

            //foreach (var digit in shortDigits)
            //{
            //    Console.WriteLine(digit);
            //}

            #endregion

            #region Element Operators
            //// 1- Get first Product out of Stock
            //var result = ProductsList.FirstOrDefault(p => p.UnitsInStock == 0);

            //Console.WriteLine(result);

            //// 2- Return the first product whose Price > 1000, unless there is no match, in which case null is returned. 

            //var result2 = ProductsList.FirstOrDefault(p => p.UnitPrice > 1000);

            //Console.WriteLine(result2);

            //// 3- Retrieve the second number greater than 5

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 }; 

            //var secondNumberGreaterThan5 = Arr.Where(n => n > 5).Skip(1).FirstOrDefault();

            //Console.WriteLine(secondNumberGreaterThan5);
            #endregion

            #region Aggregate Operators 

            //// 1- Uses Count to get the number of odd numbers in the array
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var oddCount = Arr.Count(n => n % 2 != 0);
            //Console.WriteLine($"Number of odd numbers: {oddCount}");

            //// 2- Return a list of customers and how many orders each has. 

            //// fluent syntax 

            //var result = CustomersList.Select(c => new { c.CustomerName, OrderCount = c.Orders.Count() });
            //foreach (var customer in result)
            //{
            //    Console.WriteLine($"Customer: {customer.CustomerName}, Order Count: {customer.OrderCount}");
            //}

            //// query syntax

            //Console.WriteLine("\nQuery Syntax:\n");

            //var result2 = from c in CustomersList
            //              select new { c.CustomerName, OrderCount = c.Orders.Count() };

            //foreach (var customer in result2)
            //{
            //    Console.WriteLine($"Customer: {customer.CustomerName}, Order Count: {customer.OrderCount}");
            //}

            //// 3- Return a list of categories and how many products each has 

            //// fluent syntax
            //var categoryProductCount = ProductsList.GroupBy(p => p.Category)
            //                                      .Select(g => new { Category = g.Key, ProductCount = g.Count() });
            //foreach (var category in categoryProductCount)
            //{
            //    Console.WriteLine($"Category: {category.Category}, Product Count: {category.ProductCount}");
            //}

            //// query syntax

            //Console.WriteLine("\nQuery Syntax:\n");

            //var categoryProduct = from p in ProductsList
            //                           group p by p.Category into g
            //                           select new { Category = g.Key, ProductCount = g.Count() };

            //foreach (var category in categoryProduct)
            //{
            //    Console.WriteLine($"Category: {category.Category}, Product Count: {category.ProductCount}");
            //}

            //// 4- Get the total of the numbers in an array.
            //int[] Arr2 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var total = Arr2.Sum();
            //Console.WriteLine($"Total of numbers in the array: {total}");

            //// 5- Get the total number of characters of all words in dictionary_english.txt (Read
            ////dictionary_english.txt into Array of String First).

            //string[] words = File.ReadAllLines("dictionary_english.txt");
            //var totalchar = words.Sum(w => w.Length);
            //Console.WriteLine($"Total number of characters in the dictionary: {totalchar}");

            //// 6- Get the length of the shortest word in dictionary_english.txt (Read dictionary_english.txt
            ////into Array of String First).
            //var shortestWordLength = words.Min(w => w.Length);
            //Console.WriteLine($"Length of the shortest word in the dictionary: {shortestWordLength}");

            //// 7- Get the length of the longest word in dictionary_english.txt (Read dictionary_english.txt
            ////into Array of String First).
            //var longestWordLength = words.Max(w => w.Length);
            //Console.WriteLine($"Length of the longest word in the dictionary: {longestWordLength}");

            //// 8- Get the average length of the words in dictionary_english.txt (Read dictionary_english.txt
            ////into Array of String First).
            //var averageWordLength = words.Average(w => w.Length);
            //Console.WriteLine($"Average length of the words in the dictionary: {averageWordLength}");
            #endregion

            #region Ordering Operators
            //// 1- Sort a list of products by name
            //var result = ProductsList.OrderBy(p => p.ProductName);
            //foreach (var product in result)
            //{
            //    Console.WriteLine($"Product: {product.ProductName}");
            //}

            //// 2- Uses a custom comparer to do a case-insensitive sort of the words in an array.
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var sortedWords = Arr.OrderBy(w => w, StringComparer.OrdinalIgnoreCase);
            //foreach (var word in sortedWords)
            //{
            //    Console.WriteLine(word);
            //}

            //// 3- Sort a list of products by units in stock from highest to lowest. 
            //var sortedProducts = ProductsList.OrderByDescending(p => p.UnitsInStock);

            //foreach (var product in sortedProducts)
            //{
            //    Console.WriteLine($"Product: {product.ProductName}, UnitsInStock: {product.UnitsInStock}");
            //}

            //// 4- Sort a list of digits, fi rst by length of their name, and then alphabetically by the name itself.
            //String[] arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

            //var sortedDigits = arr.OrderBy(d => d.Length).ThenBy(d => d);
            //foreach (var digit in sortedDigits)
            //{
            //    Console.WriteLine(digit);
            //}

            //// 5- Sort fi rst by-word length and then by a case-insensitive sort of the words in an array. (case-insensitive missed)
            //String[] Arr3 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var result3 = Arr3.OrderBy(w => w.Length).ThenBy(w => w, StringComparer.OrdinalIgnoreCase);

            //foreach (var word in result3)
            //{
            //    Console.WriteLine(word);
            //}

            //// 6- Sort a list of products, first by category, and then by unit price, from highest to lowest.
            //var sortedProductsByCategoryAndPrice = ProductsList.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice);
            //foreach (var product in sortedProductsByCategoryAndPrice)
            //{
            //    Console.WriteLine($"Product: {product.ProductName}, Category: {product.Category}, UnitPrice: {product.UnitPrice}");
            //}

            //// 7- Sort first by-word length and then by a case-insensitive descending sort of the words in an array.
            //String[] Arr4 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var result4 = Arr4.OrderBy(w => w.Length).ThenByDescending(w => w, StringComparer.OrdinalIgnoreCase);

            //foreach (var word in result4)
            //{
            //    Console.WriteLine(word);
            //}

            //// 8- Create a list of all digits in the array whose second letter is 'i' that is reversed from the
            ////order in the original array.

            //String[] Arr5 = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

            //var result5 = Arr5.Where(d => d[1] == 'i').Reverse();

            //foreach (var digit in result5)
            //{
            //    Console.WriteLine(digit);
            //}

            #endregion

            #region Transformation Operators
            // 1- Return a sequence of just the names of a list of products.
            
            var productNamesQuery = from p in ProductsList
                                    select p.ProductName;

            foreach (var productName in productNamesQuery)
            {
                Console.WriteLine(productName);

            }

            // 2- Produce a sequence of the uppercase and lowercase versions of each word in the original
            //array(Anonymous Types).
            String[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            
            var wordVariants = from w in words
                                select new { Upper = w.ToUpper(), Lower = w.ToLower() };

            foreach (var variant in wordVariants)
            {
                Console.WriteLine($"Upper: {variant.Upper}, Lower: {variant.Lower}");
            }

            // 3- Produce a sequence containing some properties of Products, including UnitPrice which is
            //renamed to Price in the resulting type.
            var productInfo = from p in ProductsList
                              select new { p.ProductName, Price = p.UnitPrice };
            foreach (var info in productInfo)
            {
                Console.WriteLine($"Product: {info.ProductName}, Price: {info.Price}");
            }

            // 4- Determine if the value of int in an array match their position in the array.
            int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var positionMatches = Arr.Select((value, index) => new { Value = value, Index = index, Match = value == index });

            foreach (var match in positionMatches)
            {
                Console.WriteLine($"Value: {match.Value}, Index: {match.Index}, Match: {match.Match}");
            }


            

            
            #endregion
        }
    }
}
