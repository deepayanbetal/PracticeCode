using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgramms.EventTrial
{
    public delegate void EventDelegate();
    class EventClass
    {
        public event EventDelegate ProcessComplete;

        public void StartEvent()
        {
            Console.WriteLine("process started");
            OnProcessCompleted();
        }

        protected virtual void OnProcessCompleted()
        {
            ProcessComplete.Invoke();
        }
    }
}
