using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;

namespace TrackerApp.DBclasses
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext() : base("DefaultConnection")
        {

        }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Theme> Themes { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}