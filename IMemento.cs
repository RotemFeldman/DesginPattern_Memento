using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesginPattern_Memento
{
    internal interface IMemento
    {

        string GetState();
        DateTime GetDate();
    }
}
