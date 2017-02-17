using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    internal class User: IDatabase
    {
        public CookBook CookBookInstance { get; private set; }

        public  User()
        {
            CookBookInstance = new CookBook();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Read()
        {
            throw new NotImplementedException();
        }
    }
}
