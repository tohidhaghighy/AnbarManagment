﻿using ServiceLayer.Repository;
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
    /// Interaction logic for ListUser.xaml
    /// </summary>
    public partial class ListUser : Window
    {
        UserRepository _user;
        public ListUser()
        {
            _user = new UserRepository();
            InitializeComponent();
        }
        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            userlist.ItemsSource = await _user.GetAll();
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

        private void Btnadduser_MouseDown(object sender, MouseButtonEventArgs e)
        {
            AddUser user = new AddUser();
            user.ShowDialog();
        }
    }
}
