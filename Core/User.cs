using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    internal class User
    {
        public CookBook CookBookInstance { get; private set; }

        public  User()
        {
            CookBookInstance = new CookBook();
        }
    }
}
