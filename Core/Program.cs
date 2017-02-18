using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.Entity.Validation;
using System.Linq;
using System.Reflection;
using Core;
using Core.Model;
using log4net;
using log4net.Config;
using MySql.Data.Entity;

class Program
{
    private readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
    static void Main(string[] args)
    {
        //Loger initializer
        XmlConfigurator.Configure();

        ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        log.Info("Core started");

        /*
        var context = new DataBaseContext();

        User user = new User("test", "test");
        
        CookBook cookbook = new CookBook(user);
        RecipeBuilder builder = new RecipeBuilder("Sanwitch", cookbook);
        Recipe recipe = builder.GetResult();
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
            log.Error(e.Message);
        }*/
    }
}