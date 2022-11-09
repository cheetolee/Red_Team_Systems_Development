using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
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
    /// <summary>
    /// Login.xaml 
    /// </summary>
    public partial class Login : Window
    {
        static string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|;Persist Security Info=True";
        OleDbConnection connection = new OleDbConnection(connectionString);

        public Login()
        {
            InitializeComponent();
            //intialize list
            fill_List();
        }

        private void fill_List()
        {
            string sql = "select [name] from [user] where [is_first] = false";
            OleDbDataAdapter da = new OleDbDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            da.Fill(ds, "Name");

            txtMemberName.DisplayMemberPath = ds.Tables["Name"].Columns["name"].ToString();
            txtMemberName.ItemsSource = ds.Tables["Name"].DefaultView;
            txtMemberName.SelectedIndex = 0;
        }

        //log in button
        private void login_Click(object sender, RoutedEventArgs e)
        {
            string name = txtMemberName.Text.Trim();
            string password = txtPassWord.Password.Trim();
            string sql = "select * from [user] where [name] = '" + name + "' and [password] = '" + password + "'";

            string sql2 = "select is_manager from [user] where [name] = '" + name + "'";

            string sql3 = "update [user] set [is_first] = false where [is_first] = true and [name]='" + name + "'";

            if (name != "" && password != "")
            {
                try
                {
                    connection.Open();

                    //update user table
                    OleDbCommand sqlcmd3 = new OleDbCommand(sql3, connection);
                    sqlcmd3.ExecuteNonQuery();


                    OleDbCommand sqlcmd = new OleDbCommand(sql, connection);
                    OleDbDataReader reader = sqlcmd.ExecuteReader();
                    if (reader.Read())
                    {

                        OleDbCommand sqlcmd2 = new OleDbCommand(sql2, connection);
                        OleDbDataReader dr = sqlcmd2.ExecuteReader();

                        MainWindow main = new MainWindow();
                        main.Show();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("The password doesn't match the username, please input the right password！");
                    }
                    reader.Close();

                }
                catch
                {
                    MessageBox.Show("Connect Failed!");
                }
                finally
                {
                    connection.Close();
                }
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
        //control log in
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