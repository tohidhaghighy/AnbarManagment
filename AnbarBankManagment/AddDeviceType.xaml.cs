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
    /// Interaction logic for AddDeviceType.xaml
    /// </summary>
    public partial class AddDeviceType : Window
    {
        DeviceTypeRepository _devicetype;
        public AddDeviceType()
        {
            _devicetype = new DeviceTypeRepository();
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

        private async void Btnadddevicetype_Click(object sender, RoutedEventArgs e)
        {
            if (txtname.Text != "")
            {
                if (await _devicetype.Add(new DeviceType() {
                    Name=txtname.Text
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
