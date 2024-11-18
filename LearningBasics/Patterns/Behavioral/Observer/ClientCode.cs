using LearningBasics.Patterns.Behavioral.Observer.ObserverClass.ConcreteObserver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics.Patterns.Behavioral.Observer
{
    public class ClientCode
    {
        public void Call()
        {
            TicketStockService ticketStockService = new();
            TicketResellerService ticketResellerService = new();
            OrderService orderService = new();

            //add observers 
            orderService.AddObserver(ticketResellerService);
            orderService.AddObserver(ticketStockService);

            //notify
            orderService.CompleteTicketSale(1,2);

            //remove one observer 
            orderService.RemoveObserver(ticketResellerService);

            //notify
            orderService.CompleteTicketSale(2, 4);
        }
    }
}
