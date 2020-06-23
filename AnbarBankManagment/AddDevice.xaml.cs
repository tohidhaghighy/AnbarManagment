using AnbarBankManagment.Enums;
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
using Utilities.Calender;

namespace AnbarBankManagment
{
    /// <summary>
    /// Interaction logic for AddDevice.xaml
    /// </summary>
    public partial class AddDevice : Window
    {
        FormStatus _status;
        DeviceRepository _device;
        public AddDevice(FormStatus status)
        {
            _status = status;
            _device = new DeviceRepository();
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

        }

        private async void Btnadddevice_Click(object sender, RoutedEventArgs e)
        {
            if (txtamval.Text!="" && txtmodel.Text!="" && txtserial.Text!="")
            {
                if (await _device.Add(new Device() {
                    AmvalNumber=txtamval.Text,
                    Model=txtmodel.Text,
                    Serial=txtserial.Text
                }))
                {
                    MessageBox.Show("با موفقیت درج شد ");
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
