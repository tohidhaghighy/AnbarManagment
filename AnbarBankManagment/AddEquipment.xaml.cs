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

namespace AnbarBankManagment
{
    /// <summary>
    /// Interaction logic for AddEquipment.xaml
    /// </summary>
    public partial class AddEquipment : Window
    {
        FormStatus _status;
        EquipmentRepository _equipment;
        DeviceTypeRepository _devicetype;
        public AddEquipment(FormStatus status)
        {
            _status = status;
            _equipment = new EquipmentRepository();
            _devicetype = new DeviceTypeRepository();
            
            InitializeComponent();
        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            EquipmentType.ItemsSource =await _devicetype.GetAll();
            EquipmentType.DisplayMemberPath = "Name";
            EquipmentType.SelectedValuePath = "Id";
            EquipmentType.SelectedIndex = 0;
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

        private async void Btnequipmentadd_Click(object sender, RoutedEventArgs e)
        {
            int id =Convert.ToInt32(EquipmentType.SelectedValue);
            if (txtserial.Text!="" && txtamval.Text!="" && txtmodel.Text!="" && txtnameequipment.Text!="")
            {
                if (await _equipment.Add(new Equipment() {
                    AmvalNumber=txtamval.Text,
                    Model=txtmodel.Text,
                    Name=txtnameequipment.Text,
                    Serial=txtserial.Text,
                    DevicetypeId=id,
                }))
                {
                    MessageBox.Show("با موفقیت درج شد");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("همه فیلد ها باید پر شود");
            }
        }
    }
}
