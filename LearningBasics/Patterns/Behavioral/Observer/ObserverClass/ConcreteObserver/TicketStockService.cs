using LearningBasics.Patterns.Behavioral.HelperClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics.Patterns.Behavioral.Observer.ObserverClass.ConcreteObserver
{
    public class TicketStockService : ITicketChangeListener
    {
        public void ReceiveTicketChangeNotification(TicketChange ticketChange)
        {
            Console.WriteLine($"{nameof(TicketResellerService)} is notifying  of ticket change: {ticketChange.ArtistId} " +
               $" for amount {ticketChange.Amount}");
        }
    }
}
