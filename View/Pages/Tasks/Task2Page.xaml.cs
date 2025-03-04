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
    /// Логика взаимодействия для Task2Page.xaml
    /// </summary>
    public partial class Task2Page : Page
    {
        int[] numbers = new int[12];
        int i = 0, el = 2;
        public Task2Page()
        {
            InitializeComponent();
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            Task2 task2 = new Task2();

            int[] newArr = task2.NewArray(numbers);

            TbA.Text = "[";
            foreach (int i in newArr)
            {
                TbA.Text += $"{i} ";
            }
            TbA.Text += "]";
        }

        private void BtnNextTask_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Task3Page());
        }

        private void BtnInput_Click(object sender, RoutedEventArgs e)
        {
            TbEl.Text = $"{el}: ";
            numbers[i] = Convert.ToInt32(Tbidx.Text);

            ++i;
            ++el;
            Tbidx.Text = string.Empty;
        }
    }
}
