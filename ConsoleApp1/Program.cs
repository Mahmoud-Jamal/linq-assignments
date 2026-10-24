

using LINQ.Models;
using LINQ.DataSources;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var products = Source.ProductList;
            var customers = Source.CustomerList;


            #region question1

            //var result = products.OrderByDescending(p => p.UnitPrice).Take(3);

            //foreach (var pro in result)
            //{
            //    Console.WriteLine(pro);
            //}

            #endregion


            #region question2

            //var result = products.Skip(5).Take(5);

            //foreach (var pro in result)
            //{
            //    Console.WriteLine(pro);
            //}

            #endregion


            #region question3

            //var result = products.OrderBy(p => p.UnitPrice)
            //                     .TakeWhile(p => p.UnitPrice < 25);

            //foreach (var pro in result)
            //{
            //    Console.WriteLine(pro);
            //}

            #endregion


            #region question4

            //var result = products.Where(p => p.Category == "Seafood")
            //                     .All(p => p.UnitsInStock > 0);

            //Console.WriteLine(result);

            #endregion


            #region question5

            //int[] ids = { 3, 9, 13, 18 };

            //var result = ids.Contains(9);

            //Console.WriteLine(result);

            #endregion


            #region question6

            //var result = products.GroupBy(p => p.Category)
            //                     .Select(g => new
            //                     {
            //                         Category = g.Key,
            //                         Count = g.Count()
            //                     });

            //foreach (var group in result)
            //{
            //    Console.WriteLine(group);
            //}

            #endregion


            #region question7

            //var result = products.GroupBy(p => p.Category)
            //                     .Select(g => new
            //                     {
            //                         Category = g.Key,
            //                         ProductNames = g.Select(p => p.ProductName)
            //                     });

            //foreach (var group in result)
            //{
            //    Console.WriteLine(group.Category);

            //    foreach (var name in group.ProductNames)
            //    {
            //        Console.WriteLine(name);
            //    }
            //}

            #endregion


            #region question8

            //var result = products.GroupBy(p => p.Category)
            //                     .Where(g => g.Count() > 3)
            //                     .Select(g => g.Key);

            //foreach (var category in result)
            //{
            //    Console.WriteLine(category);
            //}

            #endregion


            #region question9

            //var result = from customer in customers
            //             group customer by customer.Country into countryGroup
            //             select new
            //             {
            //                 Country = countryGroup.Key,
            //                 Count = countryGroup.Count(),
            //                 TotalOrderValue = countryGroup.Sum(c =>
            //                     c.Orders.Sum(o => o.OrderDetails.Sum(od =>
            //                         od.UnitPrice * od.Quantity)))
            //             };

            //foreach (var country in result)
            //{
            //    Console.WriteLine(country);
            //}

            #endregion


            #region question10

            //var result = products.Sum(p => p.UnitsInStock);

            //Console.WriteLine(result);

            #endregion


            #region question11

            //var cheapest = products.Min(p => p.UnitPrice);
            //var mostExpensive = products.Max(p => p.UnitPrice);

            //Console.WriteLine($"Cheapest Price: {cheapest}");
            //Console.WriteLine($"Most Expensive Price: {mostExpensive}");

            #endregion


            #region question12

            //var result = products.Select(p => p.Category)
            //                     .Distinct();

            //foreach (var category in result)
            //{
            //    Console.WriteLine(category);
            //}

            #endregion


            #region question13

            //int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
            //int[] setB = { 3, 6, 9, 12, 15, 13 };

            //var result = setA.Except(setB);

            //foreach (var id in result)
            //{
            //    Console.WriteLine(id);
            //}

            #endregion


            #region question14

            //string[] list1 = { "Germany", "France", "UK", "Spain" };
            //string[] list2 = { "france", "SPAIN", "Italy" };

            //var result = list1.Except(list2, StringComparer.OrdinalIgnoreCase);

            //foreach (var country in result)
            //{
            //    Console.WriteLine(country);
            //}

            #endregion


            #region question15

            //var productDictionary = products.ToDictionary(p => p.ProductID);

            //if (productDictionary.TryGetValue(18, out var product))
            //{
            //    Console.WriteLine(product);
            //}

            #endregion


            #region question16

            //var result = products.First(p => p.UnitPrice > 50);

            //Console.WriteLine(result);

            #endregion


            #region question17

            //var result = products.FirstOrDefault(p => p.UnitPrice > 500);

            //Console.WriteLine(result);

            #endregion


            #region question18

            //var result = Enumerable.Range(1, 10)
            //                       .Select(i => 7 * i);

            //foreach (var number in result)
            //{
            //    Console.WriteLine(number);
            //}

            #endregion


            #region question19

            //var result = Enumerable.Range(1, 30)
            //                       .Where(n => n % 2 == 0);

            //foreach (var number in result)
            //{
            //    Console.WriteLine(number);
            //}

            #endregion


            #region question20

            //var productNames = products.Take(3).Select(p => p.ProductName);
            //var companyNames = customers.Take(3).Select(c => c.CompanyName);

            //var result = productNames.Concat(companyNames);

            //foreach (var name in result)
            //{
            //    Console.WriteLine(name);
            //}

            #endregion


            #region question21

            //var result = products.Take(customers.Count())
            //                     .Zip(customers,
            //                          (p, c) => $"{p.ProductName} sold to {c.CompanyName}");

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion


        }

    }
}
