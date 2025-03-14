using AssignmentEf04.Classes;
using AssignmentEf04.Context;
using Microsoft.EntityFrameworkCore;

namespace AssignmentEf04
{
    internal class Program
    {

        static void Main(string[] args)
        {
            using (AssignmentDBContext context = new AssignmentDBContext())
            {
                //Car car01 = new Car
                //{
                //    Make = "Toyota",
                //    Model = "Corolla",
                //    NumberOfDoors = 4
                //};

                //Car car02 = new Car
                //{
                //    Make = "Ford",
                //    Model = "F150",
                //    NumberOfDoors = 2
                //};

                //Truck truck01 = new Truck
                //{
                //    Make = "Mercedes",
                //    Model = "C180",
                //    LoadCapacity = 2000
                //};

                //Truck truck02 = new Truck
                //{
                //    Make = "Ford",
                //    Model = "ABC",
                //    LoadCapacity = 3000
                //};


                //    context.Cars.Add(car01);
                //    context.Cars.Add(car02);
                //    context.Trucks.Add(truck01);
                //    context.Trucks.Add(truck02);
                //    context.SaveChanges();

                //foreach (var car in context.Cars)
                //{
                //    Console.WriteLine($"Car: {car.Make}, Model: {car.Model}, NumberOfDoors: {car.NumberOfDoors}");

                //}




            }
           
            using (NORTHWNDContext context = new NORTHWNDContext())
            {
                #region Stored Procedures

                //NORTHWNDContextProcedures contextProcedures = new NORTHWNDContextProcedures(context);

                //var products = contextProcedures.Sp_GetCustomerOrderHistoryAsync("AROUT").Result;

                //foreach (var product in products)
                //    Console.WriteLine($"{product.ProductName}");

                #endregion

                #region Run sQl Query
                //1 -select statement
                //var result = context.Categories.FromSqlRaw($"select * from Categories ").ToList();
                //var Category = "Beverages";

                //var result = context.Categories.FromSqlInterpolated($"Select * from Categories Where CategoryName = {Category}");

                //foreach (var item in result)
                //    Console.WriteLine($"{item.CategoryName} :: {item.Description}");

                //2.Execute Dml Query
                //context.Database.ExecuteSqlInterpolated($"update Products set productName = 'Chai02' where ProductId = {1}");

                #endregion

                #region lazy loading
                //var product = context.Products.Include(x => x.Category).ThenInclude(x => x.Products).FirstOrDefault();

                //context.Entry(product).Reference(x => x.Category).Load();
                //context.Entry(product).Reference(x => x.Order_Details).Load();


                //var categoryName = product.Category.CategoryName;

                #endregion

                #region Remote vs Local
                //context.Products.Load();

                //if (context.Products.Local.Any(x => x.UnitsInStock == 0))
                //    Console.WriteLine("there are out o stock product");
                //else
                //    Console.WriteLine("there are not out o stock product");

                #endregion



            }
        }
    }
}
