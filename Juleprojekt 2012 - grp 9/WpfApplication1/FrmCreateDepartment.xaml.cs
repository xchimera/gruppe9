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

//Søren Rasmussen
namespace GUI
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class FrmCreateDepartment : Window
    {
        private SystemController controller;

        public FrmCreateDepartment()
        {
            InitializeComponent();
        }

        public FrmCreateDepartment(SystemController controller)
        {
            InitializeComponent();
            // TODO: Complete member initialization
            this.controller = controller;
        }

        private void btnCreateDepartment_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Afdelingen er oprettet!");
            // opret afdeling i systemet og gem i tekstfil.
            string departmentName = txtDepartmentName.Text;
            string departmentNumber = txtDepartmentNumber.Text;
            string streetName = txtStreetName.Text;
            int streetNumber = Convert.ToInt32(txtStreetNumber.Text);
            int postalCode = Convert.ToInt32(txtPostalCode.Text);
            controller.CreateDepartment(departmentNumber, departmentName, streetName, streetNumber, postalCode);
            Close();
        }




       
    }

}