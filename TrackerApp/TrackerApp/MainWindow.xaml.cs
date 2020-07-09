using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TrackerApp.DBclasses;
using TrackerApp.Windows;

namespace TrackerApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ApplicationContext db;

        public MainWindow()
        {
            InitializeComponent();

            db = new ApplicationContext();
        }

        private void Add_Student_Click(object sender, RoutedEventArgs e)
        {
            StudentWindow studentWindow = new StudentWindow();

            if (studentWindow.ShowDialog() == true)
            {
                //check if group exists
                int groupID = -1;
                foreach (var item in db.Groups)
                {
                    if (item.name == studentWindow.group.Text)
                    {
                        groupID = item.id;
                        break;
                    }
                }
                
                if (groupID == -1)
                {
                    MessageBox.Show($"В базе нет группы {studentWindow.group.Text}") ;
                    return;
                }
                else
                {
                    db.Students.Add(new Student(groupID,studentWindow.name.Text, studentWindow.surname.Text, studentWindow.secondName.Text));
                    db.SaveChanges();
                }
                MessageBox.Show($"Студент {studentWindow.surname.Text} {studentWindow.name.Text} из группы {studentWindow.group.Text} был добавлен");
            }
            else
            {
                
            }
        }

        private void Add_Group_Click(object sender, RoutedEventArgs e)
        {
            GroupAddWindow groupAddWindow = new GroupAddWindow();

            if (groupAddWindow.ShowDialog() == true)
            {
                Group group = new Group(groupAddWindow.name.Text);

                db.Groups.Add(group);

                db.SaveChanges();

                MessageBox.Show($"Группа {groupAddWindow.name.Text} была добавлена");
            }
            else
            {
                
            }
        }

        private void Add_Book_Click(object sender, RoutedEventArgs e)
        {
            BookAddWindow bookAddWindow = new BookAddWindow();

            if (bookAddWindow.ShowDialog() == true)
            {
                Book book = new Book(bookAddWindow.name.Text, bookAddWindow.link.Text);

                db.Books.Add(book);

                db.SaveChanges();

                MessageBox.Show($"Книга {bookAddWindow.name.Text}({bookAddWindow.link.Text}) была добавлена");
            }
            else
            {

            }
        }

        private void Add_Lesson_Click(object sender, RoutedEventArgs e)
        {
            LessonAddWindow lessonWindow = new LessonAddWindow();

            if (lessonWindow.ShowDialog() == true)
            {
                int teacherID = -1;
                int groupID = -1;
                int bookID = -1;
                int themeID = -1;
                int taskID = -1;

                //check if teacher exists   
                foreach (var item in db.Teachers)
                {
                    if ($"{item.name} {item.surname} {item.secondName}" == lessonWindow.teacherName.Text)
                    {
                        teacherID = item.id;
                        break;
                    }
                }
                if (teacherID == -1)
                {
                    MessageBox.Show($"В базе нет преподователя {lessonWindow.teacherName.Text}");
                    return;
                }

                //check if group exists   
                foreach (var item in db.Groups)
                {
                    if (item.name == lessonWindow.groupName.Text)
                    {
                        groupID = item.id;
                        break;
                    }
                }

                if (groupID == -1)
                {
                    MessageBox.Show($"В базе нет группы {lessonWindow.groupName.Text}");
                    return;
                }

                //check if book exists
                if (lessonWindow.bookName.Text != string.Empty)
                {
                    foreach (var item in db.Books)
                    {
                        if (item.name == lessonWindow.bookName.Text)
                        {
                            bookID = item.id;
                            break;
                        }
                    }
                    if (bookID == -1)
                    {
                        MessageBox.Show($"В базе нет книги {lessonWindow.bookName.Text}");
                        return;
                    }
                }

                //check if theme exists
                if (lessonWindow.theme.Text != string.Empty)
                {
                    foreach (var item in db.Themes)
                    {
                        if (item.name == lessonWindow.theme.Text)
                        {
                            themeID = item.id;
                            break;
                        }
                    }
                    if (themeID == -1)
                    {
                        MessageBox.Show($"В базе нет темы {lessonWindow.theme.Text}");
                        return;
                    }
                }

                //check if task exists
                if (lessonWindow.task.Text != string.Empty)
                {
                    foreach (var item in db.Tasks)
                    {
                        if (item.text == lessonWindow.task.Text)
                        {
                            taskID = item.id;
                            break;
                        }
                    }
                    if (taskID == -1)
                    {
                        MessageBox.Show($"В базе нет задания {lessonWindow.task.Text}");
                        return;
                    }
                }


                db.Lessons.Add(new Lesson(teacherID, bookID, themeID, taskID));
                db.SaveChanges();
                
                MessageBox.Show($"Занятие было добавлено");
            }
            else
            {

            }
        }

        private void Add_Teacher_Click(object sender, RoutedEventArgs e)
        {
            TeacherAddWindow teacherWindow = new TeacherAddWindow();

            if (teacherWindow.ShowDialog() == true)
            {
                db.Teachers.Add(new Teacher(teacherWindow.name.Text, teacherWindow.surname.Text, teacherWindow.secondName.Text));
                db.SaveChanges();
                
                MessageBox.Show($"Преподаватель {teacherWindow.surname.Text} {teacherWindow.name.Text} был добавлен");
            }
            else
            {

            }
        }

        private void Add_Task_Click(object sender, RoutedEventArgs e)
        {
            TaskAddWindow taskWindow = new TaskAddWindow();

            if (taskWindow.ShowDialog() == true)
            {
                DBclasses.Task task = new DBclasses.Task(taskWindow.text.Text);

                db.Tasks.Add(task);

                db.SaveChanges();

                MessageBox.Show($"Задание было добавлена");
            }
            else
            {

            }
        }

        private void Add_Theme_Click(object sender, RoutedEventArgs e)
        {
            ThemeAddWindow themeWindow = new ThemeAddWindow();

            if (themeWindow.ShowDialog() == true)
            {
                Theme theme = new Theme(themeWindow.name.Text);

                db.Themes.Add(theme);

                db.SaveChanges();

                MessageBox.Show($"Тема было добавлена");
            }
            else
            {

            }
        }
    }
}
