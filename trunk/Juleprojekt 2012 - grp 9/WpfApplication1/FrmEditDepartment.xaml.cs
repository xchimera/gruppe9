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
    public partial class FrmEditDepartment : Window
    {
        

    public FrmEditDepartment()
        {
            InitializeComponent();
        }

    private void btnEditDepartment_Click(object sender, RoutedEventArgs e)
    {
        MessageBox.Show("Afdelingen er redigeret!");
        Close();
    }
      

       
    }
}
