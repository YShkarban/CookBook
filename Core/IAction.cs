using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    interface IAction
    {
        object Create();
        object Remove();
        object Get();
        object Update();
    }
}
