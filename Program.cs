using LINQ.DataSources;
using LINQ.Models;
using static LINQ.DataSources.Source;
namespace LINQ02
{
    internal class Program
    {
        static void Main()
        {
            #region Ques01
            //var result = ProductList.OrderByDescending(P => P.UnitPrice).Take(3);

            //foreach (var item in result)
            //{
            //	Console.WriteLine($"{item.ProductName} - {item.UnitPrice}");
            //}
            #endregion


            #region Ques02
            //var result = ProductList.Skip(5).Take(5);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.ProductName);
            //}
            #endregion


            #region Ques03
            //var result = ProductList.OrderBy(P => P.UnitPrice).TakeWhile(P => P.UnitPrice < 25);

            //foreach (var item in result)
            //{
            //	Console.WriteLine($"{item.ProductName} - {item.UnitPrice}");
            //}
            #endregion


            #region Ques04
            //var result = ProductList.Where(P => P.Category == "Seafood").All(P => P.UnitsInStock > 0);

            //Console.WriteLine(result);
            #endregion


            #region Ques05
            //int[] ids = { 3, 9, 13, 18 };

            //var result = ids.Contains(9);

            //Console.WriteLine(result);
            #endregion


            #region Ques06
            //var result = ProductList.GroupBy(P => P.Category);

            //foreach (var item in result)
            //{
            //	Console.WriteLine($"{item.Key} - {item.Count()}");
            //}
            #endregion


            #region Ques07
            //var result = ProductList.GroupBy(P => P.Category)
            //						.Select(G => new { Category = G.Key, Names = G.Select(P => P.ProductName) });

            //foreach (var item in result)
            //{
            //	Console.WriteLine(item.Category);

            //	foreach (var name in item.Names)
            //	{
            //		Console.WriteLine($"   {name}");
            //	}
            //}
            #endregion


            #region Ques08
            //var result = ProductList.GroupBy(P => P.Category)
            //						.Where(G => G.Count() > 3)
            //						.Select(G => G.Key);

            //foreach (var item in result)
            //{
            //	Console.WriteLine(item);
            //}
            #endregion


            #region Ques09
            //var result = from C in CustomerList
            //             group C by C.Country into G
            //             select new
            //             {
            //                 Country = G.Key,
            //                 Count = G.Count(),
            //                 TotalOrderValue = G.Sum(C => C.Orders.Sum(O => O.Total))
            //             };

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion


            #region Ques10
            //var result = ProductList.Sum(P => P.UnitsInStock);

            //Console.WriteLine(result);
            #endregion


            #region Ques11
            //var MinPrice = ProductList.Min(P => P.UnitPrice);
            //var MaxPrice = ProductList.Max(P => P.UnitPrice);

            //Console.WriteLine($"Cheapest: {MinPrice}");
            //Console.WriteLine($"Most Expensive: {MaxPrice}");
            #endregion


            #region Ques12
            //var result = ProductList.Select(P => P.Category).Distinct();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion


            #region Ques13
            //int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
            //int[] setB = { 3, 6, 9, 12, 15, 13 };

            //var result = setA.Except(setB);

            //foreach (var item in result)
            //{
            //	Console.WriteLine(item);
            //}
            #endregion


            #region Ques14
            //string[] list1 = { "Germany", "France", "UK", "Spain" };
            //string[] list2 = { "france", "SPAIN", "Italy" };

            //var result = list1.Except(list2, StringComparer.OrdinalIgnoreCase);

            //foreach (var item in result)
            //{
            //	Console.WriteLine(item);
            //}
            #endregion


            #region Ques15
            //var Dict = ProductList.ToDictionary(P => P.ProductID);

            //var result = Dict[18];

            //Console.WriteLine(result);
            #endregion


            #region Ques16
            //var result = ProductList.First(P => P.UnitPrice > 50);

            //Console.WriteLine(result);
            #endregion


            #region Ques17
            //var result = ProductList.FirstOrDefault(P => P.UnitPrice > 500);

            //Console.WriteLine(result?.ToString() ?? "null");
            #endregion


            #region Ques18
            //var result = Enumerable.Range(1, 10).Select(I => $"7 x {I} = {7 * I}");

            //foreach (var item in result)
            //{
            //	Console.WriteLine(item);
            //}
            #endregion


            #region Ques19
            //var result = Enumerable.Range(1, 30).Where(N => N % 2 == 0);

            //foreach (var item in result)
            //{
            //	Console.WriteLine(item);
            //}
            #endregion


            #region Ques20
            //var result = ProductList.Take(3).Select(P => P.ProductName)
            //						.Concat(CustomerList.Take(3).Select(C => C.CustomerName));

            //foreach (var item in result)
            //{
            //	Console.WriteLine(item);
            //}
            #endregion


            #region Ques21
            //var result = ProductList.Zip(CustomerList, (P, C) => $"{P.ProductName} sold to {C.CustomerName}");

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
        }
    }
}