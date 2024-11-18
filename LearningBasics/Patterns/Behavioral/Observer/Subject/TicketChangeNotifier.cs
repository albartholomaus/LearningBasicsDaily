using LearningBasics.Patterns.Behavioral.HelperClass;
using LearningBasics.Patterns.Behavioral.Observer.ObserverClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics.Patterns.Behavioral.Observer.Subject
{
    public abstract class TicketChangeNotifier
    {
        private List<ITicketChangeListener> observers = new();
        public void AddObserver(ITicketChangeListener observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(ITicketChangeListener observer)
        {
            observers.Remove(observer);
        }
        public void Notify(TicketChange ticketChange)
        {
            foreach (var observer in observers)
            {
                observer.ReceiveTicketChangeNotification(ticketChange);
            }
        }
    }
}
