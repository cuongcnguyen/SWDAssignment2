using System;
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

            //Test both actions
            queueingService.PlaceOrder(odo); // Open Door
            queueingService.PlaceOrder(cdo); // Close Door            
            Console.WriteLine("");

            //wait for user input and implement action
            Console.WriteLine("Press a button (1 to open the door, 2 to close it): ");
            int buttonChose = int.Parse(Console.ReadLine());            
            switch (buttonChose)
            {
                case 1:
                    {
                        queueingService.PlaceOrder(odo);                        
                        break;
                    }
                case 2:
                    {
                        queueingService.PlaceOrder(cdo);
                        break;
                    }
            }            
            Console.ReadLine();
            
        }
    }
}
