using System.Collections.Generic;
using System.Collections;

namespace CarDealership.Models
{
  public class Car
  {
    private static List<Car> _instances = new List<Car> {};

    private string _CarName;
    private string _CarModel;
    private string _CarPrice;
    private string _CarMiles;
    private string _CarYear;

    public Car (string carName, string carModel, string carPrice, string carMiles, string carYear)
    {
      _CarName = carName;
      _CarModel = carModel;
      _CarPrice = carPrice;
      _CarMiles = carMiles;
      _CarYear = carYear;

    }
    public string GetDescription()
    {
      return _CarName;
    }
    public void SetDescription(string newcarName)
    {
      _CarName = newcarName;
    }

    public string GetModel()
    {
      return _CarModel;
    }
    public void SetModel(string newcarModel)
    {
      _CarModel = newcarModel;
    }

    public string GetPrice()
    {
      return _CarPrice;
    }
    public void SetPrice(string newcarPrice)
    {
      _CarPrice = newcarPrice;
    }

    public string GetMiles()
    {
      return _CarMiles;
    }
    public void SetMiles(string newcarMiles)
    {
      _CarMiles = newcarMiles;
    }

    public string GetYear()
    {
      return _CarYear;
    }
    public void SetYear(string newcarYear)
    {
      _CarYear = newcarYear;
    }

    public static List<Car> GetAll()
    {
      return _instances;
    }
    public void Save()
    {
      _instances.Add(this);
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
   }
  }



// public class Program
// {
//   public static void Main()
//   {
//     Car porsche = new Car();
//     porsche.MakeModel = "2014 Porsche 911";
//     porsche.Price = 114991;
//     porsche.Miles = 7864;
//     porsche.Type = "Sport";
//
//     Car ford = new Car();
//     ford.MakeModel = "2011 Ford F450";
//     ford.Price = 55995;
//     ford.Miles = 14241;
//     ford.Type = "Truck";
//
//     Car lexus = new Car();
//     lexus.MakeModel = "2013 Lexus RX 350";
//     lexus.Price = 44700;
//     lexus.Miles = 20000;
//     lexus.Type = "Luxury";
//
//     Car mercedes = new Car();
//     mercedes.MakeModel = "Mercedes Benz CLS550";
//     mercedes.Price = 39900;
//     mercedes.Miles = 37979;
//     mercedes.Type = "Luxury";

    // List<Car> Cars = new List<Car>() { porsche, ford, lexus, mercedes };
    //
    // Console.WriteLine("Enter maximum price: ");
    // string stringMaxPrice = Console.ReadLine();
    // string maxPrice = int.Parse(stringMaxPrice);
    //
    //
    // Console.WriteLine("Enter maximum miles: ");
    // string stringMaxMiles = Console.ReadLine();
    // int maxMiles = int.Parse(stringMaxMiles);
    //
    // Console.WriteLine("Choose car type: ");
    // string stringcarType = Console.ReadLine();
    // string carType = (stringcarType);
    // List<Car> CarsMatchingSearch = new List<Car>(0);

//   foreach (Car automobile in Cars)
// {
//   if (automobile.WorthBuying(maxPrice, maxMiles, carType))
//   {
//     CarsMatchingSearch.Add(automobile);
//   }
// }
//     foreach(Car automobile in CarsMatchingSearch)
//     {
//       Console.WriteLine(automobile.MakeModel);
//     }
//   }
// }
