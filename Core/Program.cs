/*using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.Entity.Validation;
using System.Linq;
using Core;
using Core.Model;
using MySql.Data.Entity;

class Program
{
    static void Main(string[] args)
    {
        var context = new DataBaseContext();

        User user = new User();
        
        CookBook cookbook = new CookBook();
        RecipeBuilder builder = new RecipeBuilder("Sanwitch");
        Recipe recipe = builder.GetResult();
        user.CookBook = cookbook;
        cookbook.User = user;

        recipe.CookBook = cookbook;
        
        cookbook.Recipes.Add(recipe);
        context.CookBooks.AddOrUpdate(cookbook);

        try
        {
            context.SaveChanges();
        }
        catch (DbEntityValidationException e)
        {
            
        }
        Console.WriteLine("Finish");
        Console.ReadLine();
    }
}*/