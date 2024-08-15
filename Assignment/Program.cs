using System.Threading;
using static Assignment.ListGenerator;
namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //var Result = ProductsList.Where(p => p.UnitsInStock == 0);
            // foreach (var Unit in Result)
            //     Console.WriteLine(Unit);
            //var Result = from p in ProductsList
            //             where p.UnitsInStock==0 && p.UnitPrice>3.00M
            //             select p;
            // foreach (var Unit in Result)
            //   Console.WriteLine(Unit);
            // string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            // int[] Num = { 1, 2, 3, 4, 5, 6 };
            //var Result = Arr.Zip(Num, (s, N) => $"{s} , {N}");
            // foreach (var Unit in Result)
            //    Console.WriteLine(Unit);
            #endregion
            #region Q2
            //var Result = ProductsList.First(p => p.UnitsInStock == 0);
            // Console.WriteLine(Result);
            //var Result = ProductsList.FirstOrDefault(p => p.UnitPrice >1000,new Product() { ProductName = "Default "});
            //Console.WriteLine(Result);
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result = Arr.TakeWhile(N => N > 5);
            //Console.WriteLine(Result);
            #endregion
            #region Q3
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result = Arr.Count(C=>C%2!=0);
            //Console.WriteLine(Result);
            //var Result = from C in CustomersList
            //             from O in C.Orders
            //             select O;
            //var Result = ProductsList.Where(p=>p.UnitsInStock>0).GroupBy(p => p.Category)
            //                .OrderByDescending(p => p.Count()).
            //                Select(C=> new {categoryName=C.Key , countofno = C.Count()});
            //foreach (var i in Result) { Console.WriteLine(i); }
            //var Result = Arr.Sum();
            //Console.WriteLine(Result);
            //var Result =ProductsList.Count(x => x.UnitsInStock == 0);
            //Console.WriteLine(Result);
            //var result = ProductsList.MinBy(p => p.UnitPrice);
            // Console.WriteLine(result);
            //var result = ProductsList.Average(p => p.UnitPrice);
            //var result = ProductsList.Average(p => p.UnitPrice);

            #endregion
            #region Q4
            //var result =ProductsList.OrderByDescending(p => p.ProductName);
            //var result = ProductsList.OrderByDescending(p => p.ProductName).ThenBy(p => p.ProductName.Length);
            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            
            //foreach (var item in result) { Console.WriteLine(item); }
            #endregion
        }
    }
}
