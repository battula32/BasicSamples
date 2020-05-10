using System;
using System.Collections.Generic;
using System.Text;

namespace InstalledSoftwaresFromNetworkSystems
{
    public class Software : IEquatable<Software>
    {
        private string name;

        public string  Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.name = value;
            }
        }

        public string Publisher { get; set; }

        public bool Equals(Software other)
        {
            if (other == null)
            {
                return false;
            }

            return other.name.Equals(this.name);
        }
    }
}
