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
    /// Interaction logic for ListEquipment.xaml
    /// </summary>
    public partial class ListEquipment : Window
    {
        public ListEquipment()
        {
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

    }
}
