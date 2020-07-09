using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerApp.DBclasses
{
    class Task
    {
        public Task()
        {

        }

        public Task(string text)
        {
            this.text = text;
        }
        public int id { get; set; }

        public string text { get; set; }
    }
}
