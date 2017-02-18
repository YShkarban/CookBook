using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Model;
using Model;

namespace Core
{
    internal interface IRecipeBuilder
    {
        void SetTitle(string title);

        void SetComplexity(Complexity complexity);

        void SetRating(Rating rating);

        void SetMealType(MealType type);

        void SetDishType(DishType dishType);

        void SetCookingStyle(CookingStyle style);

        void SetYield(uint yield);
        
        void SetCookingTime(CookingTime time);

        void SetPreparationTime(CookingTime time);

        void SetIngridientList(List<string> list);

        void SetDescription(string description);

        void SetSource(string source);

        void SetVideoUrl(string videoUrl);

        void AddIngridient(string ingridient);

        void RemoveIngridient(string ingridient);

        Recipe GetResult();
    }
}
