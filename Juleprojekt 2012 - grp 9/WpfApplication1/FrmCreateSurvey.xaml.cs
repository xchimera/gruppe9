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
    /// Interaction logic for FrmCreateSurvey.xaml
    /// </summary>
    public partial class FrmCreateSurvey : Window
    {
        public FrmCreateSurvey()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Spørgeskema er oprettet, og klar til at blive udgivet!");
            Close();
        }
    }
}
