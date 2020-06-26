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
    /// Interaction logic for DeviceTypeList.xaml
    /// </summary>
    public partial class DeviceTypeList : Window
    {
        DeviceTypeRepository _devicetype;
        public DeviceTypeList()
        {
            _devicetype = new DeviceTypeRepository();
            InitializeComponent();
        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            devicetypelist.ItemsSource = await _devicetype.GetAll();
        }


        private void Btnadddevicetype_MouseDown(object sender, MouseButtonEventArgs e)
        {
            AddDeviceType device = new AddDeviceType();
            device.ShowDialog();
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
    }
}
