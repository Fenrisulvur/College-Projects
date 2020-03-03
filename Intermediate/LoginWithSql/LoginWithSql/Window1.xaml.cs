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
using System.Windows.Shapes;

namespace LoginWithSql
{
    public partial class Window1 : Window
    {
        MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
        public Window1()
        {
            InitializeComponent();
        }
        public bool checkForUserExists(string username)
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT count(*) FROM accounts WHERE Username =@username", conn);
                cmd.Parameters.AddWithValue("@username", username);
                object result = cmd.ExecuteScalar();
                if (Convert.ToInt32(result) != 0)
                {
                    return true;
                }
                else
                {
                    return false;
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

            return false;
        }
        private void registerBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!checkForUserExists(regLoginBox.Text))
            {
                try
                {
                    string password = regPassBox.Text;
                    string username = regLoginBox.Text;
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO accounts (Username,Password) VALUES(@username,@password);", conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    object result = cmd.ExecuteScalar();
                    MessageBox.Show("Registration Successful: welcome: " + username + "!");
                }
                catch (Exception err)
                {
                    MessageBox.Show("Error: " + err.InnerException);
                }
                finally
                {
                    conn.Close();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Username already taken.");
            }
        }
    }
}
