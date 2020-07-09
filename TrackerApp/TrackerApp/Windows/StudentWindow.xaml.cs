using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using TrackerApp.Windows;
using TrackerApp.DBclasses;

namespace TrackerApp.Windows
{
    /// <summary>
    /// Interaction logic for StudentWindow.xaml
    /// </summary>
    public partial class StudentWindow : Window
    {
        public StudentWindow()
        {
            InitializeComponent();
        }

        private void Accept_Click(object sender, RoutedEventArgs e)
        {
            //check user input
            //group
            if (group.Text == string.Empty)
            {
                MessageBox.Show("Поле имя не должно быть пустым.");
                return;
            }
                
            //name 
            if (name.Text == string.Empty)
            {
                MessageBox.Show("Поле имя не должно быть пустым.");
                return;
            }
            //surname
            if (surname.Text == string.Empty)
            {
                MessageBox.Show("Поле фамилия не должно быть пустым.");
                return;
            }
            
            this.DialogResult = true;
        }

    }
}
