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
    /// Логика взаимодействия для Task20Page.xaml
    /// </summary>
    public partial class Task20Page : Page
    {
        int[] numbers = new int[16];
        int i = 0, el = 2;
        public Task20Page()
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
            Task20 task20 = new Task20();

            TbA.Text = "Исходный массив: [";
            foreach (int i in numbers)
            {
                TbA.Text += $"{i} ";
            }
            TbA.Text += "]\n";

            var result = task20.Replacement(numbers);

            TbA.Text += "Измененный массив: [";
            foreach (int i in numbers)
            {
                TbA.Text += $"{i} ";
            }
            TbA.Text += "]\n";

            TbA.Text += $"Замен произведено: {result.replacement}";
        }

        private void BtnNextTask_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Task21Page());
        }
    }
}
