using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public enum Complexity {NotAssigned, VeryEasy, Easy, Normal, Hard, VeryHard };

    public enum Rating { NotAssigned, Deplorable, Tasty, Delicious };

    public enum MealType { Breakfast = 1, Lunch, Dinner, Desserts};

    public enum DishType { Soup, Salads, FastFood };

    public enum CookingStyle { Vegan, Vegeterian , Diabetic, Meat};
}
