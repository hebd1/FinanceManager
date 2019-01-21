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
using System.Data.SqlClient;
using System.Data;


namespace FinanceManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection sqlConnection;

        public MainWindow()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["FinanceManager.Properties.Settings.FinanceDBConnectionString"].ConnectionString;
            sqlConnection = new SqlConnection(connectionString);
            ShowAccounts();

        }

        /*
        * Populates the Account List Box using sqlServer
        */
        private void ShowAccounts()
        {
            try
            {
                string query = "select * from Account";
                // sql data adapter is like an interface used to make tables usable by C# objects
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);

                using (sqlDataAdapter)
                {
                    DataTable accountTable = new DataTable();

                    sqlDataAdapter.Fill(accountTable);

                    AccountList.DisplayMemberPath = "Name"; // content of ListBox from DataTable   
                    AccountList.SelectedValuePath = "Id"; // value that should be delivered, when an item from ListBox is selected
                    AccountList.ItemsSource = accountTable.DefaultView; // reference to the data the listbox should populate/alter
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

        }


        /**
         * Shows the Dates associated with a selected view as recieved from the Account List box
         * 
         **/
        private void ShowAssociatedDates()
        {
            try
            {
                string query = "select a.Date from Date a inner join AccountTransakt act on" +
                    " a.Id = act.DateID where act.AccountID = @AccountID";

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                using (sqlDataAdapter)
                {

                    sqlCommand.Parameters.AddWithValue("@AccountID", AccountList.SelectedValue);

                    DataTable associatedDateTable = new DataTable();

                    sqlDataAdapter.Fill(associatedDateTable);

                    DateList.DisplayMemberPath = "Date";
                    DateList.SelectedValuePath = "Id";
                    DateList.ItemsSource = associatedDateTable.DefaultView;
                }

            }
            catch (Exception e)
            {
                // MessageBox.Show(e.ToString());
            }
        }

        private void AccountList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ShowAssociatedDates();
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
