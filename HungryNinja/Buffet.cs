using System;
using System.Collections.Generic;
using HungryNinja.FoodClass;

namespace HungryNinja.BuffetClass
{
  class Buffet
  {
    public List<Food> Menu;

    //constructor
    public Buffet ()
    {
      Menu = new List<Food> ()
      {
        new Food ("Pizza", 300, false, false),
        new Food ("Cheeseburger", 500, false, false),
        new Food ("Burrito", 700, true, false),
        new Food ("Orange Chicken", 400, true, true),
        new Food ("Cesar Salad", 200, false, false),
        new Food ("Korean Fried Chicken", 500, true, false),
        new Food ("Black Forest Cake", 300, false, true)
      };
    }

    public Food Serve (List<Food> Menu)
    {
      Random rand = new Random ();
      int randNum = rand.Next (0, Menu.Count);

      return Menu[randNum];
    }
  }

}