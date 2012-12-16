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

namespace GUI
{
    /// <summary>
    /// Interaction logic for FrmLoggedIn.xaml
    /// </summary>
    public partial class FrmLoggedIn : Window
    {
        public FrmLoggedIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BtnDeptCreate_Click(object sender, RoutedEventArgs e)
        {
            var newWindow = new FrmCreateDepartment();
            newWindow.Show();
        }

        private void BtnDeptEdit_Click(object sender, RoutedEventArgs e)
        {
            var newWindow = new FrmEditDepartment();
            newWindow.Show();
        }

        private void BtnDeptDelete_Click(object sender, RoutedEventArgs e)
        {
            var newWindow = new FrmDeleteDepartment();
            newWindow.Show();
        }

    }
}
