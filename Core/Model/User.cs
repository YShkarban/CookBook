using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Model
{
    public class User
    {
        public string Username { get; private set; }
        private string Password { get; set; }
        public string Name { get; private set; }
        public string SurName { get; private set; }
        public CookBook CookBookInstance { get; private set; }

        public  User()
        {
            CookBookInstance = new CookBook();
        }
    }
}
