

using LINQ.Models;
using LINQ.DataSources;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region question1

            //var products = Source.ProductList;

            //var result = products.Where(p => p.Category == "Seafood")
            //                     .Select(p => new { p.ProductName, p.UnitPrice });

            //foreach (var pro in result)
            //{
            //    Console.WriteLine(pro);
            //}

            #endregion


            #region question2

            //var products = Source.ProductList;

            //var result = products.Select(p => p.ProductName);

            //foreach (var pro in result)
            //{
            //    Console.WriteLine(pro);
            //}

            #endregion


            #region question3

            //var products = Source.ProductList;

            //var result = products.OrderBy(p => p.UnitPrice).Select(p => new { p.ProductName, p.UnitPrice });

            //foreach (var pro in result)
            //{
            //    Console.WriteLine(pro);
            //}

            #endregion


            #region question4

            //var products = Source.ProductList;

            //var result = products.Where(p => p.UnitPrice >= 10 && p.UnitPrice <= 30);

            //foreach (var pro in result)
            //{
            //    Console.WriteLine(pro);
            //}

            #endregion


            #region question5

            //var products = Source.ProductList;

            //var result = products.Where(p => p.UnitsInStock > 0 && p.Category == "Spices & Condiments");

            //foreach (var pro in result)
            //{
            //    Console.WriteLine(pro);
            //}

            #endregion


            #region question6

            //var products = Source.ProductList;

            //var result = products.Select(p => new
            //{
            //    Name = p.ProductName,
            //    Price = p.UnitPrice,
            //    StockStatus = p.UnitsInStock > 0 ? "Available" : "Out of Stock"
            //});

            //foreach (var pro in result)
            //{
            //    Console.WriteLine(pro);
            //}

            #endregion


            #region question7

            //var products = Source.ProductList;

            //var result = products.Select((p, index) => new
            //{
            //    Position = index + 1,
            //    p.ProductName
            //});

            //foreach (var pro in result)
            //{
            //    Console.WriteLine($"{pro.Position}: {pro.ProductName}");
            //}

            #endregion


            #region question8

            //var products = Source.ProductList;

            //var result = products.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice);

            //foreach (var pro in result)
            //{
            //    Console.WriteLine(pro);
            //}

            #endregion


            #region question9

            //var products = Source.ProductList;

            //var result = products.Where(p => p.Category == "Beverages")
            //                     .OrderByDescending(p => p.UnitsInStock)
            //                     .Select(p => new
            //                     {
            //                         p.ProductName,
            //                         p.UnitsInStock
            //                     });

            //foreach (var pro in result)
            //{
            //    Console.WriteLine(pro);
            //}

            #endregion


            #region question10

            //var customers = Source.CustomerList;

            //var result =
            // from c in customers
            // from o in c.Orders
            // where o.OrderDate.Year >= 1997
            // select new
            // {
            //     c.CustomerID,
            //     o.OrderDate
            // };

            //foreach (var o in result) {
            //    Console.WriteLine(o);
            //}


            #endregion


            #region question11

            //var products = Source.ProductList;

            //var result = products.Select((p, index) => new
            //{
            //    Position = index + 1,
            //    p.ProductName
            //});

            //foreach (var pro in result)
            //{
            //    Console.WriteLine($"{pro.Position}: {pro.ProductName}");
            //}

            #endregion


            #region question12

            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var result = Arr.OrderBy(word => word.Length)
            //                .ThenBy(word => word, StringComparer.OrdinalIgnoreCase);

            //foreach (var word in result)
            //{
            //    Console.WriteLine(word);
            //}

            #endregion


            #region question13

            //string[] Arr = { "Mike", "Alice", "Bird", "Tiger", "Fish", "Apple" };

            //var result = Arr.Where(word => word.Length > 1 && word[1] == 'i')
            //                .Reverse();

            //foreach (var word in result)
            //{
            //    Console.WriteLine(word);
            //}

            #endregion


        }

    }
}
