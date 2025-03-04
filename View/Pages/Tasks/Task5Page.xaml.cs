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
    /// Логика взаимодействия для Task5Page.xaml
    /// </summary>
    public partial class Task5Page : Page
    {
        int[] numbers = new int[9];
        int i = 0, el = 2;
        public Task5Page()
        {
            InitializeComponent();
        }

        private void BtnInput_Click(object sender, RoutedEventArgs e)
        {
            TbEl.Text = $"{el}: ";
            numbers[i] = Convert.ToInt32(Tbidx.Text);

            ++i;
            ++el;
            Tbidx.Text = string.Empty;
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            Task5 task5 = new Task5();

            TbA.Text = "Изначальный массив: [";
            foreach (int i in numbers)
            {
                TbA.Text += $"{i} ";
            }
            TbA.Text += "]\n";

            task5.Swap(numbers);

            TbA.Text += "Текущий массив: [";
            foreach (int i in numbers)
            {
                TbA.Text += $"{i} ";
            }
            TbA.Text += "]";
        }

        private void BtnNextTask_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Task6Page());
        }
    }
}
