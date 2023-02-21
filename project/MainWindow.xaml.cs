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

namespace project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Login log = new Login();
        public User user = new User(0,"default",123,false);
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnNum_Click(object sender, RoutedEventArgs e) //Checks What Number Was Selected And Inputs To TextBlock
        {
            Button btn = sender as Button;
            int inputNum = int.Parse(btn.Content.ToString());
            TbNumIn.Text = TbNumIn.Text + $"{inputNum}";
        }

        private void btnClear_Click(object sender, RoutedEventArgs e) //Clears TextBlock
        {
            TbNumIn.Text = string.Empty;
        }

        private void btnSignOff_Click(object sender, RoutedEventArgs e) //Sign Off Account - Will Change It To Check User Id Once User Class Set Up
        {
            int userInput = 0;
            int userId = user.Id;
            string idIncorrect = "Inncorrect Id Entered Please Try Again";
            if (TbNumIn.Text != string.Empty)
            {
                userInput = int.Parse(TbNumIn.Text.ToString());
                if (userId == userInput)
                {
                    log.Show();
                    Close();
                }
                    
                else
                {
                    MessageBox.Show(idIncorrect);
                    TbNumIn.Text = string.Empty;
                }
                    
            }
            else
            {
                MessageBox.Show(idIncorrect);
                TbNumIn.Text = string.Empty;
            }
        }
    }
}
