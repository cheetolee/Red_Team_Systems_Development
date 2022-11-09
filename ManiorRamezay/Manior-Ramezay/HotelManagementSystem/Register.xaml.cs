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
        static string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|;Persist Security Info=True";
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
            //if has been registeted sql
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

                    //if username is existed or not
                    OleDbCommand sqlcmd2 = new OleDbCommand(sql2, connection);
                    OleDbDataReader reader = sqlcmd2.ExecuteReader();
                    if (reader.Read())
                    {
                        MessageBox.Show("Has been registerd, please log in！");
                    }
                    else
                    {
                        //password length
                        int digitalSecurityLength = digitalsecurity.Length;
                        //if password is the same
                        if (password == CPassWord && digitalSecurityLength >= 1 && digitalSecurityLength <= 6)
                        {
                            //if the password is the same
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
                                MessageBox.Show("Registered sucessfully！");
                                Close();
                            }
                            else
                            {
                                MessageBox.Show("Password must be at least 6 length and less than 16！");
                            }
                        }
                        else
                        {
                            if (!(digitalSecurityLength >= 1 && digitalSecurityLength <= 6))
                                MessageBox.Show("Password must be at least 1 length and less than 6 length！");
                            else
                                MessageBox.Show("Password are not the same！");
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
                MessageBox.Show("Please input username！");
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
                    checkName.ToolTip = "The username has been registerd！";
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
                checkName.ToolTip = "Username can not be empty！";
            }
        }

        private void txtCPassWord_PasswordChanged(object sender, RoutedEventArgs e)
        {
            checkPassword.Foreground = new SolidColorBrush(Colors.Red);
            String p1 = txtPassWord.Password;
            String p2 = txtCPassWord.Password;
            if (p1 != p2)
            {
                checkPassword.Content = "Passwords are not the same!";
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

        private void txtDigitalSecurity_LostFocus(object sender, RoutedEventArgs e)
        {
            string digitalSecurity = txtDigitalSecurity.Password.Trim();
            string strRegular = @"^\d{1,6}$";
            Boolean regularTrue = Regex.IsMatch(digitalSecurity, strRegular);
            if (!regularTrue)
            {
                checkPassordLength.Foreground = new SolidColorBrush(Colors.Red);
                checkPassordLength.Content = "Input 1-6 length";
            }
            else
            {
                checkPassordLength.Content = "";
            }
        }
    }
}
