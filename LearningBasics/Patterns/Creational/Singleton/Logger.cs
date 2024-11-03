using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics.Patterns.Creational.Singleton
{
    public class Logger
    {
        protected Logger()
        { }

        private static readonly Lazy<Logger> lazyLogger = new Lazy<Logger>(new Logger());
        //private static Logger? _instance;

        public static Logger Instance
        {
            get
            {
                return lazyLogger.Value;
                //if (_instance == null)
                //{
                //    _instance = new Logger();
                //}
                //return _instance;
            }
        }
        //SingletonOperation 
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
