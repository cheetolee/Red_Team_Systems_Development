using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace HotelManagementSystem
{
    /// <summary>
    /// Register.xaml 
    /// </summary>
    public partial class Register : Window
    {
        static string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory;Persist Security Info=True";
        OleDbConnection connection = new OleDbConnection(connectionString);

        public Register()
        {
            InitializeComponent();
        }

        private void register_Click(object sender, RoutedEventArgs e)
        {
            string name = txtname.Text.Trim();
            string digitalsecurity = txtDigitalSecurity.Password.Trim();
            string password = txtPassWord.Password.Trim();
            string CPassWord = txtCPassWord.Password.Trim();
            //register
            string sql = "insert into [user]([name],[digitalSecurity],[password]) values('" 
                + txtname.Text.Trim() + "','" + txtDigitalSecurity.Password.Trim() + "','" + txtPassWord.Password.Trim() + "')";
            //if user has been registered
            string sql2 = "select * from [user] where [name] = '" + name + "'";
            
            string is_manager_sql = "select * from [user]";
            //sql += txtname.Text.Trim() + "','";
            //sql += txtDigitalSecurity.Password.Trim() + "','";
            //sql += txtPassWord.Password.Trim() + "')";

            if (name != "")
            {
                //try
                //{
                    connection.Open();

                    //if user has been existed
                    OleDbCommand sqlcmd2 = new OleDbCommand(sql2, connection);
                    OleDbDataReader reader = sqlcmd2.ExecuteReader();
                    if (reader.Read())
                    {
                        MessageBox.Show("Already registerd. Please log in！");
                    }
                    else
                    {
                        //password length
                        int digitalSecurityLength = digitalsecurity.Length;
                        //if passwords are the same
                        if (password == CPassWord && digitalSecurityLength >= 1 && digitalSecurityLength <= 6)
                        {
                            //passowrd length 6-16 length
                            int length = password.Length;

                            if (length >= 6 && length <= 16)
                            {
                                OleDbCommand sda = new OleDbCommand(is_manager_sql, connection);
                                OleDbDataReader reader1 = sda.ExecuteReader();
                                if (!reader1.Read())
                                {
                                    sql = "insert into [user]([name],[digitalSecurity],[password],[is_manager]) values('"
                                           + txtname.Text.Trim() + "','" + txtDigitalSecurity.Password.Trim() + "','" + txtPassWord.Password.Trim() + "',true)";
                                }
                                OleDbCommand sqlcmd = new OleDbCommand(sql, connection);
                                sqlcmd.ExecuteNonQuery();
                                MessageBox.Show("Registered successfully！");
                                Close();
                            }
                            else
                            {
                                MessageBox.Show("Password must be 6-16 length！");
                            }
                        }
                        else
                        {
                       
                                MessageBox.Show("Passwords are not the same！");
                        }
                    }
                //}
                //catch
                //{
                //    MessageBox.Show("Connect Failed!");
                //}
                //finally
                //{
                //    connection.Close();
                //}
            }
            else
            {
                MessageBox.Show("Please input the username！");
            }
            
        }

        private void txtname_LostFocus(object sender, RoutedEventArgs e)
        {
            string name = txtname.Text.Trim();
            if (name != "")
            {

                string sql2 = "select * from [user] where [name] = '" + name + "'";

                connection.Open();

                OleDbCommand sqlcmd2 = new OleDbCommand(sql2, connection);
                OleDbDataReader reader = sqlcmd2.ExecuteReader();
                if (reader.Read())
                {
                    checkName.Foreground = new SolidColorBrush(Colors.Red);
                    checkName.FontSize = 20;
                    checkName.Content = "×";
                    checkName.ToolTip = "Username already registered！";
                }
                else
                {
                    checkName.Foreground = new SolidColorBrush(Colors.Green);
                    checkName.FontSize = 20;
                    checkName.Content = "√";
                    checkName.ToolTip = "Username available！";
                }

                connection.Close();
            }
            else
            {
                checkName.Foreground = new SolidColorBrush(Colors.Red);
                checkName.FontSize = 20;
                checkName.Content = "×";
                checkName.ToolTip = "The username can not be empty！";
            }
        }

        private void txtCPassWord_PasswordChanged(object sender, RoutedEventArgs e)
        {
            checkPassword.Foreground = new SolidColorBrush(Colors.Red);
            String p1 = txtPassWord.Password;
            String p2 = txtCPassWord.Password;
            if (p1 != p2)
            {
                checkPassword.Content = "Passwords are not the same.";
            }
            else
            {
                checkPassword.Content = "";
            }
        }

        private void txtPassWord_LostFocus(object sender, RoutedEventArgs e)
        {
            string password = txtPassWord.Password.Trim();
            string strRegular = @"^\d{6,16}$";
            Boolean regularTrue = Regex.IsMatch(password, strRegular);
            if (!regularTrue)
            {
                checkPassordLength.Foreground = new SolidColorBrush(Colors.Red);
                checkPassordLength.Content = "Input 6-16 length";
            }
            else
            {
                checkPassordLength.Content = "";
            }

        }


        }
    }

