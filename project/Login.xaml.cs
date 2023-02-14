using DocumentFormat.OpenXml.Spreadsheet;
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
using System.Windows.Shapes;

namespace project
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Login : Window
    {
        List<User> users = GetUsers();

        private static List<User> GetUsers()
        {
            List<User> users = new List<User>();
            User u1 = new User(1, "John", 123, true);
            User u2 = new User(2, "JMary", 123, false);
            users.Add(u1);
            users.Add(u2);
            return users;
           
        }

        public Login()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int inputId = int.Parse(tbxID.Text);
            int inputPw = int.Parse(pwbPW.Password);
            string errorMessage = "Sorry Incorrect Id / Pin Entered";
            //foreach (var user in users)
            //{
            //    if(inputId == user.Id)
            //    {
            //        if(inputPw == user.Password)
            //        {
            //            MainWindow main = new MainWindow();
            //            main.Show();
            //            Close();
            //        }
            //        else
            //        {
            //            MessageBox.Show(errorMessage);
            //            tbxID.Text = String.Empty;
            //            pwbPW.Password = null;
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show(errorMessage);
            //        tbxID.Text = String.Empty;
            //        pwbPW.Password = null;
            //    }
            //    break;
            //}
            var checklogin = from user in users
                              where inputId == user.Id && inputPw == user.Password
                              select user;
            User u = checklogin.FirstOrDefault();
            if (u != null)
            {
                MainWindow main = new MainWindow();
                main.Show();
                Close();
            }
            else
            {
                MessageBox.Show(errorMessage);
                tbxID.Text = String.Empty;
                pwbPW.Password = null;
            }
        }
    }
}
