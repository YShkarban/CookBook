using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Core.Model
{
    public enum Complexity {NotAssigned, VeryEasy, Easy, Normal, Hard, VeryHard };

    public enum Rating { NotAssigned, Deplorable, Tasty, Delicious };

    public enum MealType { Breakfast = 1, Lunch, Dinner, Dessert};

    public enum DishType { Soup, Salads, FastFood };

    public enum CookingStyle { Vegan, Vegeterian , Diabetic, Meat};
}
