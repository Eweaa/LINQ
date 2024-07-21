using LINQ;
//Console.WriteLine("Hello, World!");

var products = ListGenerators.ProductList;
var customers = ListGenerators.CustomerList;

#region Restriction Operators
//products.Where(P => P.UnitsInStock == 0);
//foreach (var product in products)
//    Console.WriteLine(product);

//products.Where(P => P.UnitsInStock != 0 && P.UnitPrice > 3);
//foreach (var product in products)
//    Console.WriteLine(product);

//string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
//var res = Arr.Where((d, i) => d.Length < i);
//foreach (var item in res)
//{
//    Console.WriteLine(item);
//}
#endregion

#region Element Operators

//products.FirstOrDefault(P => P.UnitsInStock == 0);
//products.FirstOrDefault(P => P.UnitPrice > 1000);

//int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
//Console.WriteLine(Arr.OrderBy(x => x).SkipWhile(x => x <= 5).Skip(1).FirstOrDefault());


//Arr.Skip(1).FirstOrDefault();
//Arr.OrderBy(x => x).SkipWhile(x => x < 5).Skip(1).FirstOrDefault();
//var newArr = Arr.OrderBy(x => x).SkipWhile(x => x <= 5).ToList();
//foreach (int x in newArr)
//    Console.WriteLine(x);

//Console.WriteLine(Arr.OrderBy(x => x).SkipWhile(x => x < 5).Skip(1).FirstOrDefault()); 
#endregion

#region Set Operators

//var UniqueCategories = products.Select(p => p.Category).Distinct();
//foreach (var category in UniqueCategories)
//    Console.WriteLine(category);

//var UniqueFirstLetter = products.Select(P => P.ProductName[0]).Union(customers.Select(C => C.CompanyName[0]));

//foreach (var product in UniqueFirstLetter)
//    Console.WriteLine(product);

//var CommonFirstLetter = products.Select(P => P.ProductName[0]).Union(customers.Select(C => C.CompanyName[0]));
//foreach (var product in CommonFirstLetter)
//    Console.WriteLine(product);

//var ExceptFirstLetter = products.Select(P => P.ProductName[0]).Except(customers.Select(C => C.CompanyName[0]));
//foreach (var product in ExceptFirstLetter)
//    Console.WriteLine(product);

//var Last3Chars = products.Select(P => P.ProductName.Substring(P.ProductName.Length - 3))
//    .Concat(customers.Select(C => C.CompanyName.Substring(C.CompanyName.Length - 3)));
//foreach (var product in Last3Chars)
//    Console.WriteLine(product); 
#endregion

#region Aggregate Operators

//int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
//var count = Arr.Where(i => i % 2 == 1).ToList().Count;
//Console.WriteLine(count);

//foreach (var i in customers)
//{
//    Console.Write($"{i} ::==> ");
//    Console.ForegroundColor = ConsoleColor.Green;
//    Console.WriteLine(i.Orders.Count());
//    Console.ResetColor();
//}

// 3--  Return a list of categories and how many products each has
//var categories = products.GroupBy(p => p.Category).Select(p => new { Category = p.Key, Count = p.Count() }).ToList();
//foreach (var i in categories)
//{
//    Console.WriteLine(i);
//}

//4--  Get the total of the numbers in an array.
//int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
//Console.WriteLine(Arr.Sum(x => x));


//5--  Get the total number of characters of all words in dictionary_english.txt 
//string[] words = File.ReadAllLines("C:\\Users\\youse\\source\\repos\\LINQ\\LINQ\\dictionary_english.txt");
//Console.WriteLine(words.Sum(w => w.Length));


//6--  Get the total units in stock for each product category
//var categories = products.GroupBy(p => p.Category)
//    .Select(p => new { Category = p.Key, Count = p.Sum(p => p.UnitsInStock) })
//    .ToList();
//foreach (var i in categories)
//{
//    Console.WriteLine(i);
//}



//7--  Get the length of the shortest word in dictionary_english.txt 
//var word = words.OrderBy(w => w.Length).FirstOrDefault();
//Console.WriteLine(word.Length);

//8--  Get the cheapest price among each category's products
//var categories = products.GroupBy(p => p.Category)
//    .Select(p => new { Category = p.Key, Price = p.Min(p => p.UnitPrice) })
//    .ToList();
//foreach (var i in categories)
//{
//    Console.WriteLine(i);
//}

//-- 9 --  Get the products with the cheapest price in each category
//var result = from product in products
//             group product by product.Category into GroupCategory
//             let CheapestProduct = GroupCategory.Min(product => product.UnitPrice)
//             select new
//             {
//                 Category = GroupCategory.Key,
//                 CheapestPrice_Product = from product in GroupCategory
//                                         where product.UnitPrice == CheapestProduct
//                                         select product
//             };
//foreach (var category in result)
//{
//    Console.Write(category.Category);
//    foreach (var product in category.CheapestPrice_Product)
//    {
//        Console.Write("==> " + product);
//    }
//    Console.WriteLine();
//}

//-- 10 -- Get the length of the longest word in dictionary_english.txt

//string[] words = File.ReadAllLines("C:\\Users\\youse\\source\\repos\\LINQ\\LINQ\\dictionary_english.txt");
//var result = words.Max(w => w.Count());
//Console.WriteLine(result);

//-- 11 -- Get the most expensive price among each category's products

//var res = products.GroupBy(p => p.Category)
//    .Select(p => p.Max(p => p.UnitPrice));


//foreach (var item in res)
//    Console.WriteLine(item);

//-- 12 -- Get the products with the most expensive price in each category.

//var res = products.GroupBy(p => p.Category)
//    .Select(p => new { Category = p.Key, MostExpensive = p.Max(p => p.UnitPrice) });

//foreach (var item in res)
//    Console.WriteLine(item);

//-- 13 -- Get the average length of the words in dictionary_english.txt 

//string[] words = File.ReadAllLines("C:\\Users\\youse\\source\\repos\\LINQ\\LINQ\\dictionary_english.txt");
//Console.WriteLine(words.Average(x => x.Length));

//-- 14 -- Get the average price of each category's products.
//var res = products.GroupBy(p => p.Category)
//    .Select(p => new { Category = p.Key, Average = p.Average(p => p.UnitPrice) })
//    .ToList();

//foreach (var item in res)
//    Console.WriteLine(item);


#endregion

#region Ordering Operators

//--1  Sort a list of products by name
//var orderedProds = products.OrderBy(p => p.ProductName).ToList(); 
//foreach (var product in orderedProds)
//{
//    Console.WriteLine(product);
//}

//-- 2 --

//string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
//var test = Arr.OrderBy(x => x);
//foreach (var item in test)
//{
//    Console.WriteLine(item);
//}

//3--  Sort a list of products by units in stock from highest to lowest.
//var orderdProdsUIS = products.OrderByDescending(p => p.UnitsInStock);
//foreach (var product in orderdProdsUIS)
//{
//    Console.WriteLine(product); 
//}

//--4 --Sort a list of digits, first by length of their name, and then alphabetically by the name itself.
//string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
//var ordered = Arr.OrderBy(x => x.Length).ThenBy(x => x);
//foreach (var item in ordered)
//    Console.WriteLine(item);

//-- 5 -- Sort first by word length and then by a case-insensitive sort of the words in an array.
//string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
//var test = Arr.OrderBy(x => x.Length).ThenBy(x => x);
//foreach (var item in test)
//{
//    Console.WriteLine(item);
//}

//-- 6 --  Sort a list of products, first by category, and then by unit price, from highest to lowest.
//products.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice);

//-- 7 -- Sort first by word length and then by a case-insensitive descending sort of the words in an array.
//string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
//var ordered = Arr.OrderBy(x => x.Length).ThenByDescending(x => x);
//foreach (var item in ordered)
//	Console.WriteLine(item);


//-- 8 -- Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.

//string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
//var ordered = Arr.Where(x => x[1] == 'i').Reverse().ToList();
//foreach (var item in ordered)
//    Console.WriteLine(item);


#endregion

#region Partitioning Operators
//-- 1 -- Get the first 3 orders from customers in Washington
//var oc = customers.Where(c => c.City == "Washington").Take(3).ToList();
//foreach (var i in oc)
//    Console.WriteLine(i);

//-- 2 -- Get all but the first 2 orders from customers in Washington.
//var oc = customers.Where(c => c.City == "Washington").Skip(2);
//foreach (var item in oc)
//    Console.WriteLine(item);

//-- 3 -- Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.

//int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

//var nres = numbers.TakeWhile((n, i) => n > i);
//foreach (var item in nres)
//    Console.WriteLine(item);

//-- 4 -- Get the elements of the array starting from the first element divisible by 3.

//int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

//var result = numbers.SkipWhile(num => num % 3 != 0);
//foreach (int num in result)
//    Console.WriteLine(num);

//-- 5 --   Get the elements of the array starting from the first element less than its position.
//int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
//var result = numbers.SkipWhile((num, index) => num > index);
//foreach (var i in result)
//{
//	Console.WriteLine(i);
//}
#endregion

#region Quantifiers

//-- 1 -- Determine if any of the words in dictionary_english.txt contain the substring 'ei'.
//string[] words = File.ReadAllLines("C:\\Users\\youse\\source\\repos\\LINQ\\LINQ\\dictionary_english.txt");
//Console.WriteLine(words.Any(w => w.Contains("ei")));

//-- 2 -- Return a grouped list of products only for categories that have at least one product that is out of stock.
//var categories = products.GroupBy(p => p.Category)
//    .Where(c => c.Any(p => p.UnitsInStock == 0))
//    .Select(p => new { Category = p.Key })
//    .ToList();
//foreach (var i in categories)
//{
//    Console.WriteLine(i);
//}

//foreach (var product in products)
//    Console.WriteLine(product);


//-- 3 -- Return a grouped a list of products only for categories that have all of their products in stock.

//var cat = products.GroupBy(p => p.Category)
//    .Where(c => c.All(p => p.UnitsInStock != 0))
//    .Select(p => new { Category = p.Key })
//    .ToList();

//foreach (var i in cat)
//{
//    Console.WriteLine(i);
//}
#endregion

#region Grouping Operators

//-- 1 -- Use group by to partition a list of numbers by their remainder when divided by 5
//List<int> numbers = [ 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 ];

//var groupedNumbers = numbers.GroupBy(x => x % 5).ToList();

//foreach (var group in groupedNumbers)
//{
//    Console.WriteLine($"Numbers with a remainder of {group.Key} when divided by 5:");
//    foreach (var number in group)
//    {
//        Console.WriteLine(number);
//    }
//    Console.WriteLine();
//}


//-- 2 -- Uses group by to partition a list of words by their first letter
//string[] words = File.ReadAllLines("C:\\Users\\youse\\source\\repos\\LINQ\\LINQ\\dictionary_english.txt");
//var group = words.GroupBy(w => w[0]).ToList();


//foreach (var item1 in group)
//{
//	foreach (var item2 in item1)
//	{
//		Console.WriteLine(item2);
//    }
//}


//-- 3 -- Use Group By with a custom comparer that matches words that are consists of the same Characters Together

//string[] Arr = { "from   ", " salt", " earn ", "  last   ", " near ", " form  " }; 
#endregion
