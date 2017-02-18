using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using Core;
using Core.Model;
using MySql.Data.Entity;
/*
class Program
{
    static void Main(string[] args)
    {
        var context = new DataBaseContext();

        var user = new User {Name = "zinger2", SurName = "lol", Username = "asd"};
        var cookbook = new CookBook {User = user};
        user.CookBook = cookbook;
        context.Users.AddOrUpdate(user);
        Recipe recipe = new RecipeBuilder("Sanwitch").GetResult();
        
        cookbook.Recipes.Add(recipe);
        context.CookBooks.AddOrUpdate(cookbook);


        context.SaveChanges();
        Console.WriteLine("Finish");
        Console.ReadLine();
        
    }
}*/