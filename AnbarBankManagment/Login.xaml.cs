using ServiceLayer.Repository;
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

namespace AnbarBankManagment
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        UserRepository _user;
        public Login()
        {
            InitializeComponent();
            _user = new UserRepository();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Rectangle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Back_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {

        }

        private async void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            if (txtUser.Text!="" && txtpass.Password !="")
            {
                if (await _user.Login(txtUser.Text, txtpass.Password))
                {
                    MainWindow mw = new MainWindow();
                    mw.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("این کاربر موجود نیست");
                }
            }
            else
            {
                MessageBox.Show("نام کاربری و پسورد نباید خالی باشد");
            }
        }

        private void BtnEnseraf_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
