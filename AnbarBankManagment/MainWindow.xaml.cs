using AnbarBankManagment.Enums;
using DataLayer;
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

namespace AnbarBankManagment
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        AnbarDbContext db = new AnbarDbContext();
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lblpersianday.Content = persiancalender.SelectedDate.PersianDayOfWeek;
            lblday.Content = persiancalender.SelectedDate.Day;

            lblmonth.Content = persiancalender.SelectedDate.MonthAsPersianMonth;

            lblyear.Content = persiancalender.SelectedDate.Year;

            lblmin.Content = DateTime.Now.Minute;

            lblhor.Content = DateTime.Now.Hour;

            System.Windows.Threading.DispatcherTimer timer = new System.Windows.Threading.DispatcherTimer();
            timer.Tick += new EventHandler(sectick);
            timer.Interval = new TimeSpan(0, 0, 0, 0, 600);
            timer.Start();
        }

        private void sectick(object sender, EventArgs e)
        {
            lblmin.Content = DateTime.Now.Minute;

            lblhor.Content = DateTime.Now.Hour;

            if (lblsec.Visibility == System.Windows.Visibility.Hidden)
                lblsec.Visibility = Visibility.Visible;
            else
                lblsec.Visibility = Visibility.Hidden;
        }

        

        private void BtnResiveDevice_Click(object sender, RoutedEventArgs e)
        {
            DeviceList device = new DeviceList();
            device.ShowDialog();
        }

        private void BtnSendDevice_Click(object sender, RoutedEventArgs e)
        {
            DeviceList device = new DeviceList();
            device.ShowDialog();
        }

        private void Btnadddevice_Click(object sender, RoutedEventArgs e)
        {
            AddDevice add = new AddDevice(FormStatus.Add);
            add.ShowDialog();
        }

        private void Btnequipmentnew_Click(object sender, RoutedEventArgs e)
        {
            AddEquipment add = new AddEquipment(FormStatus.Add);
            add.ShowDialog();
        }

        private void Btnresiveequipment_Click(object sender, RoutedEventArgs e)
        {
            ListEquipment list = new ListEquipment();
            list.ShowDialog();
        }

        private void Btnsendequipment_Click(object sender, RoutedEventArgs e)
        {
            ListEquipment list = new ListEquipment();
            list.ShowDialog();
        }

        private void Btnback_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Btnrepository_Click(object sender, RoutedEventArgs e)
        {
            Repository rep = new Repository();
            rep.ShowDialog();
        }
    }
}
