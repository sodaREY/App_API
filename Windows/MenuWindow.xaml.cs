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

namespace App_API.Windows
{
    /// <summary>
    /// Логика взаимодействия для MenuWindow.xaml
    /// </summary>
    public partial class MenuWindow : Window
    {
        public MenuWindow()
        {
            InitializeComponent();
        }

        private void OneGuyBtn_Click(object sender, RoutedEventArgs e)
        {
            PersonalWindow personal = new PersonalWindow();
            personal.Show();
            Hide();
        }

        private void GroupGuysBtn_Click(object sender, RoutedEventArgs e)
        {
            GroupWindow group = new GroupWindow();
            group.Show();
            Hide();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
