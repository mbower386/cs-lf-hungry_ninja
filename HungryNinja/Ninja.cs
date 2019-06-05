using System;
using System.Collections.Generic;
using HungryNinja.FoodClass;

namespace HungryNinja.NinjaClass
{
  class Ninja
  {
    private int calorieIntake;
    public List<Food> FoodHistory;

    public bool isFull
    {
      get
      {
        if (calorieIntake > 1200)
        {
          return true;
        }
        else
        {
          return false;
        }

      }
    }

    // add a constructor
    public Ninja (int calIntake, List<Food> foodHist)
    {
      this.calorieIntake = calIntake;
      this.FoodHistory = foodHist;
    }

    // add a public "getter" property called "IsFull"

    // build out the Eat method
    public void Eat (Food item)
    {
      if (this.isFull == false)
      {
        this.calorieIntake += item.Calories;
        this.FoodHistory.Add (item);
        Console.WriteLine ("The ninja just ate " + item.Name + ".");

        if (item.IsSpicy)
        {
          Console.WriteLine ("This food is spicy!");
        }
        else
        {
          Console.WriteLine ("This food is not spicy!");
        }
        if (item.IsSweet)
        {
          Console.WriteLine ("This food is sweet!");
        }
        else
        {
          Console.WriteLine ("This food is not sweet!");
        }
      }
      else
      {
        Console.WriteLine ("The ninja is full!  Can't eat any more!");
      }
    }
  }

}