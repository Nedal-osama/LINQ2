namespace LINQ2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Element Operators

            /*     //1-Get the first product out of stock:

                    var firstProductOutOfStock = ListGenerators.ProductList.FirstOrDefault(p => p.UnitsInStock == 0);
                    Console.WriteLine(firstProductOutOfStock);

                 //2-Return the first product whose price is greater than 1000, or null if no match is found:
                 var expensiveProduct = ListGenerators.ProductList.FirstOrDefault(p => p.UnitPrice > 1000);
                 Console.WriteLine(expensiveProduct);

                 //3-Retrieve the second number greater than 5:
                 int[] arry01 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
                 var secondNumberGreaterThanFive = arry01.Where(n => n > 5).Skip(1).FirstOrDefault();
                 Console.WriteLine(secondNumberGreaterThanFive);

                 */
            #endregion

            #region Aggregate Operators
            /*   //1-Uses Count to get the number of odd numbers in the array:
               int[] arry02 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
               var oddNumbersCount = arry02.Count(n => n % 2 != 0);
               Console.WriteLine(oddNumbersCount);

               //2-Return a list of customers and how many orders each has:
               var customerOrdersCount = ListGenerators.CustomerList.Select(c => new {
                   c.CustomerName,
                   OrderCount = c.Orders.Length
               });

               foreach (var customer in customerOrdersCount)
               {
                   Console.WriteLine($"{customer.CustomerName} has {customer.OrderCount} orders");
               }

               //3-Return a list of categories and how many products each has:
               var categoryProductCount = ListGenerators.ProductList .GroupBy(p => p.Category).Select(g => new
                {
                    Category = g.Key,
                    ProductCount = g.Count()
                });

               foreach (var category in categoryProductCount)
               {
                   Console.WriteLine($"{category.Category} has {category.ProductCount} products");
               }


               //4-Get the total of the numbers in an array:
               int[] arry03 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
               var totalSum = arry03.Sum();
               Console.WriteLine(totalSum);

               //5-Get the total number of characters of all words in dictionary_english.txt:
               string[] dictionary = System.IO.File.ReadAllLines("dictionary_english.txt");
               var totalCharacters = dictionary.Sum(word => word.Length);
               Console.WriteLine(totalCharacters);

               //6-Get the length of the shortest word in dictionary_english.txt:
               var shortestWordLength = dictionary.Min(word => word.Length);
               Console.WriteLine(shortestWordLength);

               //7-Get the length of the longest word in dictionary_english.txt:
               var longestWordLength = dictionary.Max(word => word.Length);
               Console.WriteLine(longestWordLength);

               //8-Get the average length of the words in dictionary_english.txt:
               var averageWordLength = dictionary.Average(word => word.Length);
               Console.WriteLine(averageWordLength);

               //9-Get the total units in stock for each product category:
               var totalUnitsInStockPerCategory = ListGenerators.ProductList .GroupBy(p => p.Category).Select(g => new 
               {
                  Category = g.Key,
                  TotalUnitsInStock = g.Sum(p => p.UnitsInStock)
               });

               foreach (var category in totalUnitsInStockPerCategory)
               {
                   Console.WriteLine($"{category.Category} has {category.TotalUnitsInStock} units in stock");
               }

               //10-Get the cheapest price among each category's products:
               var cheapestPricePerCategory = ListGenerators.ProductList.GroupBy(p => p.Category).Select(g => new 
               {
                  Category = g.Key,
                  CheapestPrice = g.Min(p => p.UnitPrice)
               });

               foreach (var category in cheapestPricePerCategory)
               {
                   Console.WriteLine($"The cheapest product in {category.Category} costs {category.CheapestPrice}");
               }

               //11-Get the products with the cheapest price in each category (Use Let):
               var cheapestProductsPerCategory = ListGenerators.ProductList.GroupBy(p => p.Category).Select(g => new
               {
                 Category = g.Key,
                 CheapestPrice = g.Min(p => p.UnitPrice),
                 Products = g.Where(p => p.UnitPrice == g.Min(p2 => p2.UnitPrice))
               });

               foreach (var category in cheapestProductsPerCategory)
               {
                   Console.WriteLine($"The cheapest products in {category.Category} are:");
                   foreach (var product in category.Products)
                   {
                       Console.WriteLine(product);
                   }
               }

               //12-Get the most expensive price among each category's products:
               var mostExpensivePricePerCategory = ListGenerators.ProductList  .GroupBy(p => p.Category).Select(g => new
               {
                  Category = g.Key,
                  MostExpensivePrice = g.Max(p => p.UnitPrice)
               });

               foreach (var category in mostExpensivePricePerCategory)
               {
                   Console.WriteLine($"The most expensive product in {category.Category} costs {category.MostExpensivePrice}");
               }

               //13-Get the products with the most expensive price in each category:
               var mostExpensiveProductsPerCategory = ListGenerators.ProductList.GroupBy(p => p.Category) .Select(g => new
               {
                 Category = g.Key,
                 MostExpensivePrice = g.Max(p => p.UnitPrice),
                 Products = g.Where(p => p.UnitPrice == g.Max(p2 => p2.UnitPrice))
               });

               foreach (var category in mostExpensiveProductsPerCategory)
               {
                   Console.WriteLine($"The most expensive products in {category.Category} are:");
                   foreach (var product in category.Products)
                   {
                       Console.WriteLine(product);
                   }
               }

               //14-Get the average price of each category's products:
               var averagePricePerCategory = ListGenerators.ProductList .GroupBy(p => p.Category).Select(g => new  
               {
                 Category = g.Key,
                 AveragePrice = g.Average(p => p.UnitPrice)
               });

               foreach (var category in averagePricePerCategory)
               {
                   Console.WriteLine($"The average price of products in {category.Category} is {category.AveragePrice}");
               }
            */
            #endregion

            #region Set Operators

            /*   // 1. Find the unique Category names from Product List
               var uniqueCategories = ListGenerators.ProductList.Select(p => p.Category).Distinct();
               Console.WriteLine("Unique Categories:");
               foreach (var category in uniqueCategories)
                   Console.WriteLine(category);

               // 2. Produce a Sequence containing the unique first letter from both product and customer names.
               var uniqueFirstLetters = ListGenerators.ProductList.Select(p => p.ProductName[0])
                   .Union(ListGenerators.CustomerList.Select(c => c.CustomerName[0])).Distinct();
               Console.WriteLine("\nUnique First Letters:");
               foreach (var letter in uniqueFirstLetters)
                   Console.WriteLine(letter);

               // 3. Create one sequence that contains the common first letter from both product and customer names.
               var commonFirstLetters = ListGenerators.ProductList.Select(p => p.ProductName[0])
                   .Intersect(ListGenerators.CustomerList.Select(c => c.CustomerName[0]));
               Console.WriteLine("\nCommon First Letters:");
               foreach (var letter in commonFirstLetters)
                   Console.WriteLine(letter);

               // 4. Create one sequence that contains the first letters of product names that are not also first letters of customer names.
               var productFirstLettersNotInCustomers = ListGenerators.ProductList.Select(p => p.ProductName[0])
                   .Except(ListGenerators.CustomerList.Select(c => c.CustomerName[0]));
               Console.WriteLine("\nProduct First Letters Not In Customers:");
               foreach (var letter in productFirstLettersNotInCustomers)
                   Console.WriteLine(letter);

               // 5. Create one sequence that contains the last Three Characters in each name of all customers and products, including any duplicates
               var lastThreeChars = ListGenerators.ProductList.Select(p => p.ProductName.Length >= 3 ? p.ProductName.Substring(p.ProductName.Length - 3) : p.ProductName)
                   .Concat(ListGenerators.CustomerList.Select(c => c.CustomerName.Length >= 3 ? c.CustomerName.Substring(c.CustomerName.Length - 3) : c.CustomerName));
               Console.WriteLine("\nLast Three Characters:");
               foreach (var chars in lastThreeChars)
                   Console.WriteLine(chars);
            */
            #endregion

            #region Partitioning Operators
            /*    // 1. Get the first 3 orders from customers in Washington
                var first3OrdersInWashington = ListGenerators.CustomerList.Where(c => c.Region == "WA")
                    .SelectMany(c => c.Orders).Take(3);
                Console.WriteLine("\nFirst 3 Orders in Washington:");
                foreach (var order in first3OrdersInWashington)
                    Console.WriteLine(order);

                // 2. Get all but the first 2 orders from customers in Washington.
                var allButFirst2OrdersInWashington = ListGenerators.CustomerList.Where(c => c.Region == "WA")
                    .SelectMany(c => c.Orders).Skip(2);
                Console.WriteLine("\nAll But First 2 Orders in Washington:");
                foreach (var order in allButFirst2OrdersInWashington)
                    Console.WriteLine(order);

                // 3. Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.
                int[] numbers1 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
                var result1 = numbers1.TakeWhile((n, index) => n >= index);
                Console.WriteLine("\nElements until a number is hit that is less than its position:");
                foreach (var num in result1)
                    Console.WriteLine(num);

                // 4. Get the elements of the array starting from the first element divisible by 3.
                int[] numbers2 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
                var result2 = numbers2.SkipWhile(n => n % 3 != 0);
                Console.WriteLine("\nElements starting from the first element divisible by 3:");
                foreach (var num in result2)
                    Console.WriteLine(num);

                // 5. Get the elements of the array starting from the first element less than its position.
                int[] numbers3 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
                var result3 = numbers3.SkipWhile((n, index) => n >= index);
                Console.WriteLine("\nElements starting from the first element less than its position:");
                foreach (var num in result3)
                    Console.WriteLine(num);
            */
            #endregion

            #region Quantifiers

            /*    // 1. Determine if any of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First) contain the substring 'ei'.
                string[] Dictionary = System.IO.File.ReadAllLines("dictionary_english.txt");
                bool containsEI = Dictionary.Any(word => word.Contains("ei"));
                Console.WriteLine($"\nAny words contain 'ei': {containsEI}");

                // 2. Return a grouped list of products only for categories that have at least one product that is out of stock.
                var categoriesWithOutOfStockProducts = ListGenerators.ProductList
                    .Where(p => p.UnitsInStock == 0)
                    .GroupBy(p => p.Category)
                    .Select(g => new { Category = g.Key, Products = g.ToList() });
                Console.WriteLine("\nCategories with at least one out of stock product:");
                foreach (var category in categoriesWithOutOfStockProducts)
                {
                    Console.WriteLine($"Category: {category.Category}");
                    foreach (var product in category.Products)
                        Console.WriteLine($"  {product}");
                }

                // 3. Return a grouped list of products only for categories that have all of their products in stock.
                var categoriesWithAllProductsInStock = ListGenerators.ProductList
                   .GroupBy(p => p.Category)
                   .Where(g => g.All(p => p.UnitsInStock > 0))
                   .Select(g => new { Category = g.Key, Products = g.ToList() });
                Console.WriteLine("\nCategories with all products in stock:");
                foreach (var category in categoriesWithAllProductsInStock)
                {
                    Console.WriteLine($"Category: {category.Category}");
                    foreach (var product in category.Products)
                        Console.WriteLine($"  {product}");
                }
            */
            #endregion

            #region Grouping Operators
            //1
            List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            var groupedNumbers = numbers.GroupBy(n => n % 5);

            foreach (var group in groupedNumbers)
            {
                Console.WriteLine($"Numbers with a remainder of {group.Key} when divided by 5:");
                foreach (var number in group)
                {
                    Console.WriteLine(number);
                }
                Console.WriteLine();
            }

            //2

         /*   string[] words = File.ReadAllLines("dictionary_english.txt");
            var Words = words.GroupBy(word => word[0]);

            
            foreach (var group in Words)
            {
                Console.WriteLine($"Words that start with '{group.Key}':");
                foreach (var word in group)
                {
                    Console.WriteLine(word);
                }
                Console.WriteLine(); 
            }*/

            //3
            string[] arry05 = { "from", "salt", "earn", "last", "near", "form" };

            var groupedWords = arry05
                .GroupBy(word => String.Concat(word.OrderBy(c => c)))
                .Select(group => new { Key = group.Key, Words = group.ToList() });

            foreach (var group in groupedWords)
            {
                Console.WriteLine($"Words with characters sorted as '{group.Key}':");
                foreach (var word in group.Words)
                {
                    Console.WriteLine(word);
                }
                Console.WriteLine("-------------");
            }
            #endregion
        }
    }
}
