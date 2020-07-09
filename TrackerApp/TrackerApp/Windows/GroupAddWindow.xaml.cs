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
using System.Windows.Shapes;

namespace TrackerApp.Windows
{
    /// <summary>
    /// Interaction logic for GroupAddWindow.xaml
    /// </summary>
    public partial class GroupAddWindow : Window
    {
        public GroupAddWindow()
        {
            InitializeComponent();
        }

        private void Accept_Click(object sender, RoutedEventArgs e)
        {
            //check user input
            //group
            if (name.Text == string.Empty)
            {
                MessageBox.Show("Поле группа не должно быть пустым.");
                return;
            }

            this.DialogResult = true;
        }
    }
}
