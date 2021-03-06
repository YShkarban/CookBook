﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Model;

namespace Core
{
    public class RecipeBuilder : IRecipeBuilder
    {
        private Recipe _recipe;

        public RecipeBuilder(string title, User user)
        {
            _recipe = new Recipe();
            SetTitle(title);
            SetUser(user);

            //Default options
            SetComplexity(Complexity.NotAssigned);
            SetRating(Rating.NotAssigned);
            SetYield(1);
            SetCookingTime(0);
            SetIngridientList(new List<string>());
            SetDescription("");
            _recipe.RecipeModified();
        }

        public Recipe GetResult()
        {
            return _recipe;
        }

        private void SetUser(User user)
        {
            _recipe.user = user;
            _recipe.RecipeModified();
        }

        public void SetComplexity(Complexity complexity)
        {
            _recipe.complexity = complexity;
            _recipe.RecipeModified();
        }

        public void SetCookingStyle(CookingStyle style)
        {
            _recipe.cookingStyle = style;
            _recipe.RecipeModified();
        }
        
        public void SetDescription(string description)
        {
            if (description == null) throw new ArgumentNullException();
            _recipe.description = description;
            _recipe.RecipeModified();
        }

        public void SetDishType(DishType dishType)
        {
            _recipe.dishType = dishType;
            _recipe.RecipeModified();
        }

        public void SetCookingTime(uint minutes)
        {
            _recipe.cookingTime = minutes;
        }

        public void SetIngridientList(List<string> list)
        {
            if (list == null) throw new ArgumentNullException();
            _recipe.ingredientsList = list;
            _recipe.RecipeModified();
        }

        public void SetMealType(MealType type)
        {
            _recipe.mealType = type;
            _recipe.RecipeModified();
        }

        public void SetRating(Rating rating)
        {
            _recipe.rating = rating;
            _recipe.RecipeModified();
        }

        public void SetSource(string source)
        {
            //TODO: if source wil be of Url, Uri or UriBuilder type we should check for valid URL
            if (source == null) throw new ArgumentNullException();
            if (source == "") throw new ArgumentException();
            _recipe.source = source;
            _recipe.RecipeModified();
        }

        public void SetTitle(string title)
        {
            if (title == null) throw new ArgumentNullException();
            if (title == "") throw new ArgumentException();
            _recipe.title = title;
            _recipe.RecipeModified();
        }

        public void SetVideoUrl(string videoUrl)
        {
            //TODO: if source wil be of Url, Uri or UriBuilder type we should check for valid URL
            if (videoUrl == null) throw new ArgumentNullException();
            if (videoUrl == "") throw new ArgumentException();
            _recipe.videoUrl = videoUrl;
            _recipe.RecipeModified();
        }

        public void SetYield(uint yield)
        {
            //TODO: Should we check for 0????
            _recipe.yield = yield;
            _recipe.RecipeModified();
        }

        public void AddIngridient(string ingridient)
        {
            if (ingridient == null) throw new ArgumentNullException();
            if (ingridient == "") throw new ArgumentException();

            if (_recipe.ingredientsList == null)
            {
                _recipe.ingredientsList = new List<string>();
                _recipe.RecipeModified();
            }

            if (_recipe.ingredientsList.Contains(ingridient))
            {
                return;
            }

            _recipe.ingredientsList.Add(ingridient);
            _recipe.RecipeModified();

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
                _recipe.RecipeModified();
            }
        }
    }
}
