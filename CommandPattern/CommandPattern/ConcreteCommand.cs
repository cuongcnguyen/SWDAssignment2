using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class ConcreteCommand
    {
        public class OpenDoorOrder : IOrder
        {
            private readonly Action _message;
            public OpenDoorOrder(Action me)
            {
                _message = me;
            }

            public void Execute()
            {
                _message.Open();
            }
        }

        public class CloseDoorOrder : IOrder
        {
            private readonly Action _message;
            public CloseDoorOrder(Action me)
            {
                _message = me;
            }

            public void Execute()
            {
                _message.Close();
            }
        }
    }
}
