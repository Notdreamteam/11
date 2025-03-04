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
    /// Логика взаимодействия для Task10Page.xaml
    /// </summary>
    public partial class Task10Page : Page
    {
        int[] numbers = new int[17];
        int i = 0, el = 2;
        public Task10Page()
        {
            InitializeComponent();
        }

        private void BtnInput_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Tbidx.Text))
                TbA.Text = "Вы не записали в массив ничего!";
            else
            {
                TbEl.Text = $"{el}: ";
                numbers[i] = Convert.ToInt32(Tbidx.Text);

                ++i;
                ++el;
                Tbidx.Text = string.Empty;
            }
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            Task10 task10 = new Task10();

            TbA.Text = $"{task10.Sum(numbers)}";
        }

        private void BtnNextTask_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Task11Page());
        }
    }
}
