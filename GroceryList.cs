using System;

class GroceryList
{
  static void Main()
  {
    string[] myGroceryList = {"eggs", "milk", "bread", "bananas", "creal", "rice", "yogurt"};

    Console.WriteLine("My grocery list");

    // foreach (string groceryItem in myGroceryList)
    for (int index = 0; index < myGroceryList.Length; index++)
    {
      // Console.WriteLine(groceryItem);
      Comsole.WriteLine(myGroceryList[index]);
    }

  }
}