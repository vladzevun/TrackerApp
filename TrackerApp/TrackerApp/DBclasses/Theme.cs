using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerApp.DBclasses
{
    class Theme
    {
        public Theme()
        {

        }

        public Theme(string name)
        {
            this.name = name;
        }
        public int id { get; set; }

        public string name { get; set; }
    }
}
