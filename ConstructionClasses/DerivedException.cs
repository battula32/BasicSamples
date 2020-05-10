using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConstructionClasses
{
    public class DerivedException : ApplicationException
    {
        private string exceptionMessage;

        public DerivedException()
        { 
        }

        public DerivedException(string exceptionMessage)
        {
            this.exceptionMessage = exceptionMessage;
        }

        public override string Message
        {
            get
            {
                //return base.Message;
                return this.exceptionMessage;
            }
        }

        public override string Source
        {
            get
            {
                return base.Source;
            }
            set
            {
                base.Source = value;
            }
        }
    }
}
