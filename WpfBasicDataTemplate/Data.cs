﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WpfBasicDataTemplate
{
    public class Data
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string phoneNumber;

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        private string city;

        public string City
        {
            get { return city; }
            set { city = value; }
        }
    }
}
