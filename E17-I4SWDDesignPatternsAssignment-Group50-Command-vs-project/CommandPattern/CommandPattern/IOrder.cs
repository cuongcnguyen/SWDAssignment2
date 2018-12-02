using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    //Interface for executing an action
    public interface IOrder
    {
        void Execute();
    }
}
