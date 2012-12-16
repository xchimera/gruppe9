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
    /// Interaction logic for FrmStopPublishSurvey.xaml
    /// </summary>
    public partial class FrmStopPublishSurvey : Window
    {
        public FrmStopPublishSurvey()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Spørgeskemaet er nu stoppet med at blive udgivet til værestedet(erne)");
            Close();
        }
    }
}
