using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConstructionClasses.Events
{
    public delegate void MyEventHandler(object obj, EventArgs e);
    public delegate void MyEventHandlerExt(int result);

    class EventData
    {
        private int result;
        public event MyEventHandler MyEvent;
        public event MyEventHandlerExt MyOtherEvent;

        public int Result
        {
            get
            {
                return result;
            }

            set
            {
                result = value;
            }
        }

        public void CalCulate(int param1, int param2)
        {
            Result = param1 * param2;
            EventArgs e = new EventArgs();
            if (MyEvent != null)
            {
                MyEvent(this.Result, e);
            }
        }

        public void CalculateExt(int param1, int param2)
        {
            if (MyOtherEvent != null)
            {
                MyOtherEvent(param1 * param2);
            }
        }
    }
}
