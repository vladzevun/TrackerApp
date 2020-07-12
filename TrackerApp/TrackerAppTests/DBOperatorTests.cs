using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrackerApp.DBclasses;


namespace TrackerAppTests
{
    [TestClass]
    public class DBOperatorTests
    {
        [TestMethod]
        public void addingBookTest()
        {
            ApplicationContext db = new ApplicationContext();
            DBOperator dBOperator = new DBOperator(db);
            string newBookName = "someBookName";
            string newBookLink = "someBookLink";

            if (dBOperator.addBook(newBookName, newBookLink))
            {
                bool wasAdded = false;
                foreach (var item in db.Books)
                {
                    if (item.name == newBookName)
                    {
                        wasAdded = true;
                        break;
                    }
                }
                Assert.IsTrue(wasAdded, "Book was not added");
            } 
            else
            {
                bool bookExists = false;
                foreach (var item in db.Books)
                {
                    if (item.name == newBookName)
                    {
                        bookExists = true;
                        break;
                    }
                }
                Assert.IsTrue(bookExists, "Book was not added");
            }
        }
        [TestMethod]
        public void deletingBook()
        {
            ApplicationContext db = new ApplicationContext();
            DBOperator dBOperator = new DBOperator(db);
            string bookName = "bookName";
            //string bookLink = "someBookLink";


            if (dBOperator.deleteBook(bookName))
            {
                bool wasDeleted = true;
                foreach (var item in db.Books)
                {
                    if (item.name == bookName)
                    {
                        wasDeleted = false;
                        break;
                    }
                }
                Assert.IsTrue(wasDeleted, "Book was not deleted");
            }
            else
            {
                bool bookExists = false;
                foreach (var item in db.Books)
                {
                    if (item.name == bookName)
                    {
                        bookExists = true;
                        break;
                    }
                }
                Assert.IsTrue(!bookExists, "Book was not deleted");
            }
        }
        [TestMethod]
        public void checkIfBookExists()
        {
            ApplicationContext db = new ApplicationContext();
            DBOperator dBOperator = new DBOperator(db);
            string bookName = "bookName";

            bool operatorResult = dBOperator.bookExists(bookName);
            bool realResult = false;

            foreach (var item in db.Books)
            {
                if (item.name == bookName)
                {
                    realResult = true;
                    break;
                }
            }

            Assert.AreEqual(operatorResult, realResult);
        }
    }
}
