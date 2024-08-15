using System.Collections;
using System.Text.RegularExpressions;
using static DemoLinQ02.ListGenerator;
namespace DemoLinQ02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Filteration [Where -oftybe]
            //fluent syntax 
            //var Result = ProductsList.Where(p => p.UnitsInStock == 0);
            //querySyntax
            //Result = from p in ProductsList
            //         where p.UnitsInStock == 0
            //         select p;
            //var Result = ProductsList.Where(p => p.Category == "Meat/Poultry"&&p.UnitsInStock!=0);

            // Result = from p in ProductsList where p.Category == "Meat/Poultry" && p.UnitsInStock>0 
            //          select p;
            // foreach (var Unit in Result)
            //     Console.WriteLine(Unit);

            //indexed Where
            //var Result = ProductsList.Where((p, i) => p.UnitsInStock == 0 && i < 10);
            //var Result = ProductsList.Where((p, i) => p.UnitsInStock> 0 & i <5 );
            //indexed where only valid in fluent syntax
            //cant be written using query syntax [Query Expression]

            //foreach (var Unit in Result)
            //     Console.WriteLine(Unit);
            //ArrayList list = new ArrayList() { "Moha","Miso","Amira",1,5,7,8,9};
            ////list is sequence because implement interface IEnumerable
            //var Result = list.OfType<string>();

            #endregion
            #region Transformation Operatoe [select -selectMany]
            //var Result = ProductsList.Select(p => p.ProductName);
            //var Result = CustomersList.Select(c => c.CustomerName);
            //var Result = ProductsList.Select(p => new{p.ProductName , p.ProductID});
            //var Result = from p in ProductsList
            //             select new { p.ProductID, p.ProductName };
            //var Result = CustomersList.SelectMany(c => c.Orders); // if the property is a List or Array using SelectMany
            //var Result = from C in CustomersList
            //             from O in C.Orders
            //             select O;

            //var Result =  ProductsList.Where(p => p.UnitsInStock > 0).
            //              Select(p => new 
            //              {
            //                  p.ProductID,
            //                  p.ProductName,
            //                  NewPrice=p.UnitPrice-p.UnitPrice*0.1M 
            //              });

            //Indexed Select
            //var Result =ProductsList.Select((p, I) => new { I, p.ProductName });
            //foreach (var item in Result)
            //    Console.WriteLine(item);
            #endregion
            #region Ordering operator - Differed
            //var Result = ProductsList.OrderBy(p => p.UnitPrice); //Asscending
            //var Result = ProductsList.OrderByDescending(p => p.UnitPrice);

            //var Result = from p in ProductsList
            //             orderby p.UnitPrice descending
            //             select p;

            //var Result = ProductsList.Select(p => new { p.ProductName, p.UnitsInStock, p.UnitPrice })
            //                                     .OrderBy(p=>p.UnitsInStock).ThenBy(p=>p.UnitPrice);
            //var Result = from p in ProductsList
            //             orderby p.UnitsInStock,p.UnitPrice descending
            //             select new
            //             { p.ProductName,
            //                 p.UnitsInStock,
            //                 p.UnitPrice 
            //             };
            //var Result = ProductsList.Reverse<Product>();

            //foreach(var item in Result)
            //    Console.WriteLine(item);
            #endregion
            #region Element operator - immediate
            //ProductsList = new List<Product>() { new Product() { ProductName = "One product"} };
            //var Result01 =  ProductsList.First(); //May throw Exception .. sequence contains no elements

            //var Result01 =  ProductsList.Last();// .. sequence contains no elements May be throw Exception
            //var Result01 = ProductsList.FirstOrDefault(); //Return Default value 
            //var Result01 = ProductsList.LastOrDefault(); //Return Default value 
            //var Result01 = ProductsList.First(p=>p.UnitsInStock==0);
            //var Result01 = ProductsList.Last(p => p.UnitsInStock == 0);

            //var Result01 = ProductsList.FirstOrDefault(new Product() { ProductName = "Defalut product" });
            //var Result01 = ProductsList.FirstOrDefault(p=>p.UnitsInStock==0);

            //var Result01 = ProductsList.ElementAt(1); //May Throw Exception 
            //var Result01 = ProductsList.ElementAtOrDefault(1); 
            //var Result01 = ProductsList.Single();//May throw Exception
            //Sequence contains more than one element'
            //sequence contains no element
            //var Result01 = ProductsList.Single(p=>p.UnitsInStock==0);
            //Sequence contains more than one matching element'


            //var result01 = productslist.singleordefault();//'sequence contains more than one element'

            //var Result01 = ProductsList.SingleOrDefault(new Product() { ProductName = "Default"});
            //var Result01 = ProductsList.SingleOrDefault(p=>p.UnitsInStock==0);//More than one Match condition
            //var Result01 = ProductsList.SingleOrDefault(p=>p.UnitsInStock==0,new Product() { ProductName="Default value"});//More than one Match condition
            //ProductsList = new List<Product>() ;
            //var Result01 =  ProductsList.DefaultIfEmpty(new Product() { ProductName= "Default Value if the list is Empty"});
            //foreach (var item in Result01) 
            //    Console.WriteLine(item);
            #endregion
            #region Aggregate operator [immediate Execution]
            // Count -sum -Avg -Min - Max
            //var Result = ProductsList.Count();
            //var Result = ProductsList.Count(p=>p.UnitsInStock==5);
            //var Result = ProductsList.Count;
            //var Result = ProductsList.Sum(p => p.UnitPrice);
            //var Result = ProductsList.Sum(p => p.UnitsInStock);
            //var Result = ProductsList.Average(p => p.UnitPrice);
            //var Result = ProductsList.Max(); // Must be implement ICompareable

            //var Result = ProductsList.Max(p => p.UnitPrice);

            //var Result = ProductsList.Max(new CompareProductBasedonUnitStock());
            //var Result = ProductsList.MaxBy(p => p.UnitPrice);

            //var Result = ProductsList.Min(p => p.UnitPrice);

            //var Result = ProductsList.Min(new CompareProductBasedonUnitStock());
            //var Result = ProductsList.MinBy(p => p.UnitPrice);

            //Aggregate
            // List<string>Names = new List<string>() { "Ahmed", "Omar ", "Ali", "Mohamed"};
            //var Result = Names.Aggregate((str1, str2) => $"{str1} , {str2}");
            // Console.WriteLine(Result);
            #endregion

            #region Casting operator -[immediate Execution] 
            //List<Product>Result =  ProductsList.Where(p => p.UnitsInStock == 0).ToList();
            //Product[]Result = ProductsList.Where(p => p.UnitsInStock == 0).ToArray();
            //Dictionary<long, Product> Result = ProductsList.Where(p => p.UnitsInStock == 0).ToDictionary(p => p.ProductID);
            //Dictionary<long, string> Result = ProductsList.Where(p => p.UnitsInStock == 0)
            //                                                .ToDictionary(p => p.ProductID, p => p.ProductName);
            //HashSet<Product> Result = ProductsList.Where(p => p.UnitsInStock == 0).ToHashSet();


            //ArrayList obj = new ArrayList() { "Omar", "Mohamed", 5, 3, 2.5, "Aya" };
            //var Result = obj.OfType<string>().ToList();
            //foreach(var item in Result)
            //    Console.WriteLine($"{item}"); 
            #endregion
            #region Generation Operators - [Differed Execution]
            //vaild only with fluent syntax only
            //var Result =  Enumerable.Range(0, 100);//0..99
            //  Result = Enumerable.Repeat(2, 100); // Return IEnumerable of 100 element each one =2
            //var Result = Enumerable.Repeat(new Product(), 100); // Return IEnumerable of 100 product

            //var arrayproduct = Enumerable.Empty<Product>().ToArray();
            //Product[] products = new Product[0];
            ////both will Generate an empty array of product 
            //var List = Enumerable.Empty<Product>().ToList();
            //List<Product> list = new List<Product>();
            ////Both of them will generate an Empty List of product 
            ////
            //foreach (var item in Result) 
            //    Console.Write(item + " ");

            #endregion
            #region Set operator [Differed operator] 
            //var seq01 = Enumerable.Range(0, 100);//0..99
            //var seq02 = Enumerable.Range(50, 100); //50..149
            ////var Result = seq01.Union(seq02); // 0..149 -> Remove Duplication
            //var Result = seq01.Concat(seq02); //0..149 + 50..149
            ////Result = Result.Distinct(); // Remove Duplication -> Work as a Comparer
            //Result = seq01.Intersect(seq02);//50..99
            //Result =seq01.Except(seq02);//0..49
            //Console.WriteLine("\n========Seq01===========");
            //foreach (var item in seq01)
            //    Console.Write(item + " ");
            //Console.WriteLine("\n===========Seq02============");
            //foreach (var item in seq02)
            //    Console.Write(item + " ");
            //Console.WriteLine("\n========Uinon===========");

            //foreach (var item in Result)
            //{
            //    Console.Write(item + " ");
            //}
            #endregion
            #region Quantifier Operators -Returns Boolean 
            //Any- All - SequenceEqual - Contains
            //Any()-> Return True if there is at least one element [in the sequence or Match the Condition]
            //var result = ProductsList.Any(p=>p.UnitsInStock==1000);
            //All() -> Return True if ALl Element Match Condition or sequence is Empty
            //var result =  ProductsList.All(p=>p.UnitPrice>0);
            //var seq01 = Enumerable.Range(0, 10);
            ////var seq02 = Enumerable.Range(5, 10);
            ////   var result = seq01.SequenceEqual(seq02);
            //var result = seq01.Contains(1);

            //Console.WriteLine(result);
            #endregion
            #region  Zipping Operator
            // List<string>Words = new List<string>() { "Ten", "twenty","Thirty","Fourty"};
            // List<int> Numbs = new List<int>() { 10, 20, 30, 40 };
            //var result = Words.Zip(Numbs, (w, N) =>$"{N} => {w}");
            // foreach (var item in result)
            // {
            //     Console.WriteLine(item);
            // }
            #endregion
            #region Grouping operator
            //var Result = ProductsList.GroupBy(p => p.Category);
            // Result = from p in ProductsList
            //          group p by p.Category;

            // foreach (var item in Result)
            // {
            //     Console.WriteLine(item.Key);
            //     foreach (var prod in item) 
            //     {
            //         Console.WriteLine(prod);
            //     }
            // }

            //var Result = from p in ProductsList
            //             where p.UnitsInStock > 0
            //             group p by p.Category
            //              into Category
            //              where Category.Count()>10
            //              select new { CategoryName = Category.Key ,    CountofCategory = Category.Count() };
            //var Result = ProductsList.Where(p => p.UnitsInStock > 0)
            //                         .GroupBy(p => p.Category)
            //                         .OrderByDescending(p => p.Count())
            //                         .Where(c => c.Count() > 5)
            //                         .Select(C => new { CategoryName = C.Key, CountofCategory = C.Count() });

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item.Key);
            //    foreach (var prod in item)
            //    {
            //        Console.WriteLine(prod);
            //    }
            //}
            #endregion
            #region Partioning Operator [Take - TakeLast - Skip - SkipLast - TakeWhile - SkipWhile
            //var Result = ProductsList.Where(p=>p.UnitsInStock==0).Take(3); // Take .. first element
            //var Result = ProductsList.Where(p=>p.UnitsInStock==0).TakeLast(3); // Take .. first element
            //var Result = ProductsList.Skip(0).Take(5);
            //var Result = ProductsList.SkipLast(5).Take(5);
            //int[] Numbers = { 9,3,6, 4, 2, 3, 5 };
            //var Result =Numbers.TakeWhile(n => n % 3 == 0);
            // //var Result =Numbers.SkipWhile(n => n % 3 == 0);
            // int[] Numbers = { 9, 3, 6, 4, 2, 3, 5 ,8,7};
            //var Result = Numbers.TakeWhile((N, I) => N > I);

            // foreach (var item in Result)
            // {
            //     Console.WriteLine(item);
            // }
            #endregion
            #region Let - into 
            //Let -- into
            //aeiou AEIOU
            //var Result = Regex.Replace("Mohamed", "[aeiouAEIOU]", string.Empty);
            List<string> strings = new List<string>() { "Moha", "Ali", "Aya", "Miso", "Mido", "Mariam", "Amira", "Hager", "Yara", "Zeinab" };

            //var Result = from N in strings
            //             select Regex.Replace(N, "[aeiouAEIOU]", string.Empty)
            //             into NoVolNames // Restart to Query
            //               where NoVolNames.Length>2
            //               select NoVolNames;
            var Result = from N in strings
                         let NoVolNames = Regex.Replace(N, "[aeiouAEIOU]", string.Empty)
                         // let .. Continue query with Adding New Range Varible
                         where NoVolNames.Length > 2
                         select NoVolNames;
            foreach (var item in Result)
            {
                Console.WriteLine(item);
            } 
            #endregion 
        }
    }
}
