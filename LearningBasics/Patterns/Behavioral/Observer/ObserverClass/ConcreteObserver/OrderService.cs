using LearningBasics.Patterns.Behavioral.HelperClass;
using LearningBasics.Patterns.Behavioral.Observer.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics.Patterns.Behavioral.Observer.ObserverClass.ConcreteObserver
{
    public class OrderService : TicketChangeNotifier
    {
        public void CompleteTicketSale(int artistId, int amount)
        {
            Console.WriteLine($"{nameof(OrderService)} is notifying observers");
            Console.WriteLine($"{nameof(OrderService)} is change state");
            Notify(new TicketChange(artistId,amount));
        }
    }
}
