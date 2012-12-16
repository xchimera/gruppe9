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
    /// Interaction logic for FrmCreateQuestion.xaml
    /// </summary>
    public partial class FrmCreateQuestion : Window
    {
        public FrmCreateQuestion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (comboBox1.Text.ToString()=="Et Svar" || comboBox1.Text.ToString()=="Flere Svar")
            {
                var newWindow = new FrmQuestionMulti();
                newWindow.Show();
                Close();
            }
            else if (comboBox1.Text.ToString() == "Tekst Felt")
            {

                MessageBox.Show("Spørgsmålet er oprettet med svarmulighed som tekstfelt.");
                Close();
            }
            else
            {
                MessageBox.Show("Du har glemt at vælge en måde at besvare spørgsmålet på.");
            }
        }
    }
}
