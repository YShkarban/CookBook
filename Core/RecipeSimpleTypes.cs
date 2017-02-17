using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    internal enum Complexity {NotAssigned, VeryEasy, Easy, Normal, Hard, VeryHard };

    internal enum Rating { NotAssigned, Deplorable, Tasty, Delicious };

    internal enum MealType { Breakfast = 1, Lunch, Dinner, Dessert};

    internal enum DishType { Soup, Salads, FastFood };

    internal enum CookingStyle { Vegan, Vegeterian , Diabetic, Meat};
}
