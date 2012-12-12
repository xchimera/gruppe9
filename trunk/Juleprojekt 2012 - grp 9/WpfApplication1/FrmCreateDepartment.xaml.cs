using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Controller;

namespace GUI
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class FrmCreateDepartment : Window
    {
        private SystemController controller;


        public FrmCreateDepartment(SystemController controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {


            if (!controller.CreateDepartment(int.Parse(txtDepartmentNumber.Text), txtDepartmentName.Text, txtStreetName.Text, int.Parse(txtStreetNumber.Text), int.Parse(txtPostalCode.Text)))
            {
                MessageBox.Show("Der skete en fejl, tjek venligst felterne og prøv igen");
            }


        }
    }
}
