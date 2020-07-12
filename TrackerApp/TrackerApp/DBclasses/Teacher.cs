using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerApp.DBclasses
{
    public class Teacher
    {
        public Teacher()
        {

        }

        public Teacher(string name, string surname, string secondName = "")
        {
            this.name = name;
            this.surname = surname;
            this.secondName = secondName;
        }
        public int id { get; set; }

        public string name { get; set; }

        public string surname { get; set; }

        public string secondName { get; set; }
    }
}
