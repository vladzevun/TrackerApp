using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerApp.DBclasses
{
    public class Group
    {
        public Group()
        {

        }

        public Group(string name)
        {
            this.name = name;
        }
        public int id { get; set; }

        public string name { get; set; }
    }
}
