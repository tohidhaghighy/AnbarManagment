using DomainLayer;
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
    /// Interaction logic for AddUser.xaml
    /// </summary>
    public partial class AddUser : Window
    {
        UserRepository _user;
        public AddUser()
        {
            _user = new UserRepository();
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Activated(object sender, EventArgs e)
        {

        }



        private void Back_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }


        private void Header_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Btnback_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private async void Btnadduser_Click(object sender, RoutedEventArgs e)
        {
            if (txtname.Text != "" && txtusername.Text != "" && txtpassword.Text != "")
            {
                if (await _user.Add(new User() {
                    Name=txtname.Text,
                    Password=txtpassword.Text,
                    Username=txtusername.Text,
                    UserRoll= Roll.User
                }))
                {
                    MessageBox.Show("با موفقیت ثبت شد");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("همه فیلد ها باید مقدار داشته باشد");
            }
        }
    }
}
