using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class QueueingService
    {
        private ArrayList ordersQueue = new ArrayList();

        public void placeOrder(IOrder order)
        {
            ordersQueue.Add(order);            
            order.Excecute(ordersQueue[0]);
            order.Excecute(ordersQueue.Remove(0));


        }
    }
}
