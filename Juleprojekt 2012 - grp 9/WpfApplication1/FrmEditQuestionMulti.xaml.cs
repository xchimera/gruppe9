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
    /// Interaction logic for FrmEditQuestionMulti.xaml
    /// </summary>
    public partial class FrmEditQuestionMulti : Window
    {
        public FrmEditQuestionMulti()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Svarene er redigeret sammen med spørgsmålet.");
            Close();
        }
    }
}
