namespace HungryNinja.FoodClass
{
  class Food
  {
    public string Name;
    public int Calories;
    // Foods can be Spicy and/or Sweet
    public bool IsSpicy;
    public bool IsSweet;
    // add a constructor that takes in all four parameters: Name, Calories, IsSpicy, IsSweet

    public Food (string name, int calories, bool isASpicy, bool isASweet)
    {
      this.Name = name;
      this.Calories = calories;
      this.IsSpicy = isASpicy;
      this.IsSweet = isASweet;
    }
  }

}