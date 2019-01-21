// Eli Hebdon

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
using System.Configuration;

namespace FinanceManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["FinanceManager.Properties.Settings.FinanceDBConnectionString"].ConnectionString;
        }

        private void AccountList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Add_Account_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Delete_Account_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DateList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Add_Date_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Remove_Date_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TransactionList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Add_Transaction_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Delete_Transaction_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
