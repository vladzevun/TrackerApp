using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerApp.DBclasses
{
    public class Book
    {
        public Book()
        {

        }

        public Book(string name, string link)
        {
            this.name = name;
            this.link = link;
        }
        public int id { get; set; }

        public string name { get; set; }

        public string link { get; set; }
    }
}
