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
    /// Логика взаимодействия для Task6Page.xaml
    /// </summary>
    public partial class Task6Page : Page
    {
        int[] numbers = new int[20];
        int i = 0, el = 2;
        public Task6Page()
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
            Task6 task6 = new Task6();

            TbA.Text = task6.Define(numbers);
        }

        private void BtnNextTask_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Task7Page());
        }
    }
}
