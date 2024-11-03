using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics.Patterns.Creational.Singleton
{
    public class ClientCode
    {
        public void Call()
        {
            var instance1 = Logger.Instance;
            var instance2 = Logger.Instance;

            if (instance1 == instance2 && instance2 == Logger.Instance)
            {
                Console.WriteLine("Same");
            }
            instance1.Log($" Message{nameof(instance1)}");
            instance1.Log($" Message{nameof(instance2)}");
            Logger.Instance.Log($" Message{nameof(Logger.Instance)}");
        }
    }
}
