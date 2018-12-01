using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class Action
    {
        public void Open()
        {
            System.Console.WriteLine("Door opened!");
        }
        public void Close()
        {
            System.Console.WriteLine("Door closed!");
        }
    }
}
