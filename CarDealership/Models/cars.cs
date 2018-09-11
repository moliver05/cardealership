using System.Collections.Generic;
using System.Collections;

namespace CarDealership.Models
{
  public class Item
  {
    private string _carSale;
    private static List<Item> _instances = new List<Item> {};

    public Item (string carSale)
    {
      _carSale = carSale;
    }
    public string GetDescription()
    {
      return _carSale;
    }
    public void SetDescription(string newcarSale)
    {
      _carSale = newcarSale;
    }

    public string GetModel()
    {
      return _carModel;
    }
    public void SetModel(string newcarModel)
    {
      _carModel = newcarModel;
    }

    public int GetPrice()
    {
      return _carPrice;
    }
    public void SetPrice(int newcarPrice)
    {
      _carPrice = newcarPrice;
    }

    public int GetMiles()
    {
      return _carMiles;
    }
    public void SetMiles(string newcarMiles)
    {
      _carMiles = newcarMiles;
    }

    public string GetYear()
    {
      return _carYear;
    }
    public void SetYear(string newcarYear)
    {
      _carYear = newcarYear;
    }

    public static List<Item> GetAll()
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
    // int maxPrice = int.Parse(stringMaxPrice);
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
