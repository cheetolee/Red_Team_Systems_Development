using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.IO;
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

namespace HotelManagementSystem
{

    public partial class Login : Window
    {

        private SQLiteConnection sqlCon = null;

        public Login()
        {
            InitializeComponent();
            string dbPath = "Data Source = " + Environment.CurrentDirectory + "/ManoirRamezayDB.db";
            sqlCon = new SQLiteConnection(dbPath);
            sqlCon.Open();
            string sql = "CREATE TABLE IF NOT EXISTS User(Username varchar, Password varchar, is_Admin varchar);";
            SQLiteCommand cmdCreateUserTable = new SQLiteCommand(sql, sqlCon);
            cmdCreateUserTable.ExecuteNonQuery();
            cmdCreateUserTable.CommandText = "INSERT INTO User VALUES('pat', '123', 'true');";
            cmdCreateUserTable.ExecuteNonQuery();
            cmdCreateUserTable.CommandText = "INSERT INTO User VALUES('julian', '123', 'true');";
            cmdCreateUserTable.ExecuteNonQuery();
            sqlCon.Close();
        }

       

        //login button
        private void login_Click(object sender, RoutedEventArgs e)
        {
            string name = txtMemberName.Text.Trim();
            string password = txtPassWord.Password.Trim();

            if (name != "" && password != "")
            {
                string dbPath = "Data Source = " + Environment.CurrentDirectory + "/ManoirRamezayDB.db";
                sqlCon = new SQLiteConnection(dbPath);
                sqlCon.Open();
                string sql = "SELECT COUNT (*) FROM USER WHERE USERNAME = " + name + " AND WHERE PASSWORD = " + password;
                SQLiteCommand checkUserNameAn = new SQLiteCommand(sql, sqlCon);
            }
            else if (name == "")
            {
                MessageBox.Show("Input username！");
            }
            else
            {
                MessageBox.Show("Input password！");
            }
        }
        //mouse enter event
        private void Mouse_Enter(object sender, RoutedEventArgs e)
        {
            if (sender == register)
            {
                register.Foreground = Brushes.Blue;
            }
            else if (sender == findpwd)
            {
                findpwd.Foreground = Brushes.Blue;
            }
            else if (sender == login)
            {
                login.Foreground = Brushes.Blue;
            }
        }
        //mouse leave event
        private void Mouse_Leave(object sender, RoutedEventArgs e)
        {
            register.Foreground = Brushes.Black;
            findpwd.Foreground = Brushes.Black;
            login.Foreground = Brushes.Black;
        }

        private void Label_Click(object sender, RoutedEventArgs e)
        {
            if (sender == register)
            {
                Register reg = new Register();
                reg.ShowDialog();
            }
        }
    }
}
