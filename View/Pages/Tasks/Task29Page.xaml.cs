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
using WpfApp15.Core.TaskClass;

namespace WpfApp15.View.Pages.Tasks
{
    /// <summary>
    /// Логика взаимодействия для Task29Page.xaml
    /// </summary>
    public partial class Task29Page : Page
    {
        public Task29Page()
        {
            InitializeComponent();
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            double[] Finally = { 5.5, 6.5, 4.1, 3.8, 77.5, 98.2, 35.4, 6.6, 78.9, 123.5, 78.4, 56.1, 9.9, 8.4, 12.3, 65.4, 96.3, 123.4 };

            Task29 task29 = new Task29();

            TbA.Text = $"{task29.Quotient(Finally)}";
        }

        private void BtnNextTask_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }
    }
}
