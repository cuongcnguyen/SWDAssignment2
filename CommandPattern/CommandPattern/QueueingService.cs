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
        private readonly ArrayList _ordersQueue = new ArrayList();

        public void PlaceOrder(IOrder order)
        {
            _ordersQueue.Add(order);
            order.Execute();
            _ordersQueue.Remove(_ordersQueue[0]);
        }
    }
}
