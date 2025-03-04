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
    /// Логика взаимодействия для Task9Page.xaml
    /// </summary>
    public partial class Task9Page : Page
    {
        public Task9Page()
        {
            InitializeComponent();
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            int[] arr = { 32, 534, 1, 432, 65, 787, 432, 6544, 7865, 12, 86, 32, 76, 3, 11 };

            Task9 task9 = new Task9();

            int[] newArr = task9.NewArray(arr);

            TbA.Text = "[";
            foreach (int i in newArr)
            {
                TbA.Text += $"{i} ";
            }
            TbA.Text += "]";
        }

        private void BtnNextTask_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Task10Page());
        }
    }
}
