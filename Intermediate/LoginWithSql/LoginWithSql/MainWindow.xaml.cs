using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
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

namespace LoginWithSql
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
        public MainWindow()
        {
            InitializeComponent();
        }

        private void registerBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Window1 wind = new Window1();
            wind.Closed += ShowMain;
            wind.ShowDialog();

            
        }

        public void ShowMain(object sender, EventArgs e)
        {
            this.Show();

        }

        private void loginBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string password = passBox.Password;
                string username = loginBox.Text;
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT count(*) FROM accounts WHERE Username =@username AND Password =@password", conn);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                object result = cmd.ExecuteScalar();
                if (Convert.ToInt32(result) != 0)
                {
                    MessageBox.Show("Login Successful: welcome: " + username + "!");
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password.");
                }
 
            }
            catch (Exception err)
            {
                MessageBox.Show("Error: " + err.InnerException);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
