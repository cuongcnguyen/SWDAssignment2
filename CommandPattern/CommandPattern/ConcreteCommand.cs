using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class ConcreteCommand
    {
        public class OpenDoorOrder : IOrder
        {
            private Action message;
            public OpenDoorOrder(Action me)
            {
                message = me;
            }

            //public void Excecute(IOrder order)
            //{
            //    throw new NotImplementedException();
            //}

            public void Execute()
            {
                message.Open();
                
            }
        }

        public class CloseDoorOrder : IOrder
        {
            private Action message;
            public CloseDoorOrder(Action me)
            {
                message = me;
            }

            public void Excecute(IOrder order)
            {
                throw new NotImplementedException();
            }

            public void Execute()
            {
                message.Close();
                
            }
        }
    }
}
