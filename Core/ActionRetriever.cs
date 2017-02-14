using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public static class ActionRetriever
    {

        public static object SendAction(string action, string targetObject, string id,  object args, object sender)
        {
            IAction actionToExecute;
            object result = null;

            switch (targetObject)
            {
                case "User":
                    actionToExecute = new IActionUser();
                    break;
                case "Recipe":
                    actionToExecute = new IActionRecipe();
                    break;
                case "CookBook":
                    actionToExecute = new IActionCookBook();
                    break;
                default:
                    throw new ArgumentException();
            }

            switch (action)
            {
                case "Get":
                    result = actionToExecute.Get();
                    break;
                case "Remove":
                    result = actionToExecute.Remove();
                    break;
                case "Add":
                case "Create":
                    result = actionToExecute.Create();
                    break;
                case "Update":
                    result = actionToExecute.Update();
                    break;
                default:
                    throw new ArgumentException();
            }

            return result;
        }
    }
}
