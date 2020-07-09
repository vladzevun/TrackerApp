using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerApp.DBclasses
{
    class Lesson
    {
        public Lesson()
        {

        }

        public Lesson(int teacherID, int bookID, int themeID, int taskID)
        {
            this.teacherID = teacherID;
            this.bookID = bookID;
            this.themeID = themeID;
            this.taskID = taskID;
        }
        public int id { get; set; }

        public int groupID { get; set; }

        public int teacherID { get; set; }

        public string date { get; set; }

        public int bookID { get; set; }

        public int themeID { get; set; }

        public int taskID { get; set; }
    }
}
