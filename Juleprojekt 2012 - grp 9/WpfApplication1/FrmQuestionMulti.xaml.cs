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
    /// Interaction logic for FrmQuestionMulti.xaml
    /// </summary>
    public partial class FrmQuestionMulti : Window
    {
        public FrmQuestionMulti()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Svarene er nu gemt sammen med spørgsmålet!");
            Close();
            
        }



     

     
    }
}
