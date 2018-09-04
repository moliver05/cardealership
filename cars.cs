using System;
using System.Collections.Generic;

class Car
{
  public string MakeModel;
  public int Price;
  public int Miles;
  public string Type;
  public bool WorthBuying(int maxPrice, int maxMiles, string carType)
{
  return Price < (maxPrice + 100);

  }
}


public class Program
{
  public static void Main()
  {
    Car porsche = new Car();
    porsche.MakeModel = "2014 Porsche 911";
    porsche.Price = 114991;
    porsche.Miles = 7864;
    porsche.Type = "Sport";

    Car ford = new Car();
    ford.MakeModel = "2011 Ford F450";
    ford.Price = 55995;
    ford.Miles = 14241;
    ford.Type = "Truck";

    Car lexus = new Car();
    lexus.MakeModel = "2013 Lexus RX 350";
    lexus.Price = 44700;
    lexus.Miles = 20000;
    lexus.Type = "Luxury";

    Car mercedes = new Car();
    mercedes.MakeModel = "Mercedes Benz CLS550";
    mercedes.Price = 39900;
    mercedes.Miles = 37979;
    mercedes.Type = "Luxury";

    List<Car> Cars = new List<Car>() { porsche, ford, lexus, mercedes };

    Console.WriteLine("Enter maximum price: ");
    string stringMaxPrice = Console.ReadLine();
    int maxPrice = int.Parse(stringMaxPrice);


    Console.WriteLine("Enter maximum miles: ");
    string stringMaxMiles = Console.ReadLine();
    int maxMiles = int.Parse(stringMaxMiles);

    Console.WriteLine("Choose car type: ");
    string stringcarType = Console.ReadLine();
    string carType = (stringcarType);
    List<Car> CarsMatchingSearch = new List<Car>(0);

  foreach (Car automobile in Cars)
{
  if (automobile.WorthBuying(maxPrice, maxMiles, carType))
  {
    CarsMatchingSearch.Add(automobile);
  }
}
    foreach(Car automobile in CarsMatchingSearch)
    {
      Console.WriteLine(automobile.MakeModel);
    }
  }
}
