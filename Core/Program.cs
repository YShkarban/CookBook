using System;
using System.Data.Entity.Validation;
using System.Reflection;
using Core;
using Core.Model;
using log4net;
using log4net.Config;

class Program
{
    private readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
    static void Main(string[] args)
    {
        //Loger initializer
        XmlConfigurator.Configure();

        //this field is not nessesarry
        ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        log.Info("Core started");

        
        var context = new DataBaseContext();
        User user = new User("test", "test");
        
        RecipeBuilder builder = new RecipeBuilder("Sanwitch", user);
        Recipe recipe = builder.GetResult();

        try
        {
            user.Recipes.Add(recipe);
            context.Users.Add(user);
            context.SaveChanges();
        }
        catch (DbEntityValidationException e)
        {
            log.Error(e.Message);
        }
        catch (Exception e)
        {
            log.Error(e.Message);
        }
    }
}