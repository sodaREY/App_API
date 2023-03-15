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
    /// Логика взаимодействия для GroupWindow.xaml
    /// </summary>
    public partial class GroupWindow : Window
    {
        public GroupWindow()
        {
            InitializeComponent();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void AddFormBtn_Click(object sender, RoutedEventArgs e)
        {
            //HttpClient httpClient = new HttpClient();

            //await httpClient.PostAsync($"http://localhost:49393/api/users&login={Login.Text)&password={Password.Text}",
            //    new StreamContent(""));
        }
    }
}
