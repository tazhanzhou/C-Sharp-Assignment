using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Assignment
{
    class Person
    {
        private string name { get; set; }
        private string password { get; set; }

        public string this[int index]
        {
            get
            {
                if (index == 0) return name;
                else if (index == 1) return password;
                else return null;
            }
            set
            {
                if (index == 0) name = value;
                else if (index == 1) password = value;
            }
        }
    }
}
