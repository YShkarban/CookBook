using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class RecipeManager
    {
        public Recipe recipe { get; set; }

        public RecipeManager(Recipe recipe)
        {
            this.recipe = recipe;
        }
    }
}
