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
using WpfApp15.Core;
using WpfApp15.Core.TaskClass;

namespace WpfApp15.View.Pages.Tasks
{
    /// <summary>
    /// Логика взаимодействия для Task21Page.xaml
    /// </summary>
    public partial class Task21Page : Page
    {
        public Task21Page()
        {
            InitializeComponent();
        }

        private void BtnInput_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            double[] arr = { 3.5, 2.1, 3.3, 4.1, 54.3, 0.5, 5.6, 8.7, 9.9, 44.6, 5.4, 68.2 };

            Task21 task21 = new Task21();

            task21.NewArr(arr);

            TbA.Text = "[";
            foreach (int i in arr)
            {
                TbA.Text += $"{i} ";
            }
            TbA.Text += "]";
        }

        private void BtnNextTask_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Task22Page());
        }
    }
}
