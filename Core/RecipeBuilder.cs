using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class RecipeBuilder : IRecipeBuilder
    {
        private Recipe _recipe;

        public RecipeBuilder(string title)
        {
            _recipe = new Recipe();
            SetTitle(title);

            //Default options
            SetComplexity(Complexity.NotAssigned);
            SetRating(Rating.NotAssigned);
            SetYield(1);
            SetCookingTime(new CookingTime());
            SetPreparationTime(new CookingTime());
            SetIngridientList(new List<string>());
            SetDescription("");
        }

        public Recipe GetResult()
        {
            return _recipe;
        }

        public void SetComplexity(Complexity complexity)
        {
            _recipe.complexity = complexity;
        }

        public void SetCookingStyle(CookingStyle style)
        {
            _recipe.cookingStyle = style;
        }

        public void SetCookingTime(CookingTime time)
        {
            if (time == null) throw new ArgumentNullException();

            _recipe.cookingTime = time;
            if (_recipe.preparationTime == null)
            {
                _recipe.totalTime = time;
            }
            else
            {
                _recipe.totalTime = _recipe.cookingTime + _recipe.preparationTime;
            }
        }

        public void SetDescription(string description)
        {
            if (description == null) throw new ArgumentNullException();
            _recipe.description = description;
        }

        public void SetDishType(DishType dishType)
        {
            _recipe.dishType = dishType;
        }

        public void SetIngridientList(List<string> list)
        {
            if (list == null) throw new ArgumentNullException();
            _recipe.ingredientsList = list;
        }

        public void SetMealType(MealType type)
        {
            _recipe.mealType = type;
        }

        public void SetPreparationTime(CookingTime time)
        {
            if (time == null) throw new ArgumentNullException();

            _recipe.preparationTime = time;
            if (_recipe.cookingTime == null)
            {
                _recipe.totalTime = time;
            }
            else
            {
                _recipe.totalTime = _recipe.cookingTime + _recipe.preparationTime;
            }
        }

        public void SetRating(Rating rating)
        {
            _recipe.rating = rating;
        }

        public void SetSource(string source)
        {
            //TODO: if source wil be of Url, Uri or UriBuilder type we should check for valid URL
            if (source == null) throw new ArgumentNullException();
            if (source == "") throw new ArgumentException();
            _recipe.source = source;
        }

        public void SetTitle(string title)
        {
            if (title == null) throw new ArgumentNullException();
            if (title == "") throw new ArgumentException();
            _recipe.title = title;
        }

        public void SetVideoUrl(string videoUrl)
        {
            //TODO: if source wil be of Url, Uri or UriBuilder type we should check for valid URL
            if (videoUrl == null) throw new ArgumentNullException();
            if (videoUrl == "") throw new ArgumentException();
            _recipe.videoUrl = videoUrl;
        }

        public void SetYield(uint yield)
        {
            //TODO: Should we check for 0????
            _recipe.yield = yield;
        }

        public void AddIngridient(string ingridient)
        {
            if (ingridient == null) throw new ArgumentNullException();
            if (ingridient == "") throw new ArgumentException();

            if (_recipe.ingredientsList == null)
            {
                _recipe.ingredientsList = new List<string>();
            }

            if (_recipe.ingredientsList.Contains(ingridient))
            {
                return;
            }

            _recipe.ingredientsList.Add(ingridient);

        }

        public void RemoveIngridient(string ingridient)
        {
            if (ingridient == null) throw new ArgumentNullException();
            if (ingridient == "") throw new ArgumentException();

            if(_recipe.ingredientsList == null)
            {
                return;
            }

            if (_recipe.ingredientsList.Contains(ingridient))
            {
                _recipe.ingredientsList.Remove(ingridient);
            }
        }
    }
}
