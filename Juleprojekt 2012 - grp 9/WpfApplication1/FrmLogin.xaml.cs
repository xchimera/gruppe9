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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Controller;

//Søren Rasmussen
namespace GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //husk at sende controlleren med til nye vinduer
        SystemController controller;

        public MainWindow()
        {
            InitializeComponent();

            try
            {
                controller = SystemController.HentData();
            }
            catch (Exception)
            {
                MessageBox.Show("Ingen data indlæst!");
                controller = new SystemController();
                return;

            }
        }

    
        private void button1_Click_1(object sender, RoutedEventArgs e)
        {
            var newWindow = new FrmLoggedIn(controller);
            newWindow.Show();
        }
    }
}
