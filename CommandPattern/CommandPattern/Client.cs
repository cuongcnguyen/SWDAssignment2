﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CommandPattern.ConcreteCommand;

namespace CommandPattern
{
    public class Client
    {
        public static void Main(string[] args)
        {           
            Action message = new Action();
            OpenDoorOrder odo = new OpenDoorOrder(message);
            CloseDoorOrder cdo = new CloseDoorOrder(message);
            QueueingService queueingService = new QueueingService();

            queueingService.PlaceOrder(odo); // Open Door
            queueingService.PlaceOrder(cdo); // Close Door

            Console.ReadLine();
        }
    }
}
