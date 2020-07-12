using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerApp.DBclasses
{
    public class DBOperator
    {
        ApplicationContext db;

        public DBOperator(ApplicationContext db)
        {
            this.db = db;
        }

        public bool addBook(string name, string link)
        {
            if (this.getBookID(name) == -1)
            {
                db.Books.Add(new Book(name, link));
                db.SaveChanges();
                return true;
            }
            return false;
        }
         
        public bool deleteBook(string name)
        {
            int bookID = this.getBookID(name);
            if (bookID != -1)
            {
                db.Books.Remove(new Book { id = bookID });
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public int getBookID(string name)
        {
            foreach (var item in db.Books)
            {
                if (item.name == name)
                {
                    return item.id;
                }
            }
            return -1;
        }

        public bool bookExists(string name)
        {
            if (this.getBookID(name) == -1)
                return false;
            return true;
        }
        

    }
}
