using System.Windows;
using System.Windows.Controls;
using WpfApp15.Core;
using WpfApp15.View.Pages.Tasks;

namespace WpfApp15.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnTasks_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Task1Page());
        }
    }
}
