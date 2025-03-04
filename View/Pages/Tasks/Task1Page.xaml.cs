using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
    /// Логика взаимодействия для Task1Page.xaml
    /// </summary>
    public partial class Task1Page : Page
    {
        int[] numbers = new int[14];
        int i = 0, el = 2;
        public Task1Page()
        {
            InitializeComponent();
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            Task1 task1 = new Task1();

            TbA.Text = $"{task1.Count(numbers)}";
        }

        private void BtnNextTask_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Task2Page());
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
