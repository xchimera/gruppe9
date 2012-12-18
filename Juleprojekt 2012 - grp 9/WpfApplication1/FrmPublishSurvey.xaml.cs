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
using System.Collections;
using Interface;

//Søren Rasmussen
namespace GUI
{
    /// <summary>
    /// Interaction logic for FrmPublishSurvey.xaml
    /// </summary>
    public partial class FrmPublishSurvey : Window
    {

        private SystemController controller;
      

        public FrmPublishSurvey(SystemController controller)
        {
            // TODO: Complete member initialization
            
            InitializeComponent();
            this.controller = controller;
            ShowDepartments();
            
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Spørgeskemaet er udgivet og frigivet til værestedet");
            Close();
        }
        public void ShowDepartments()
        {
            // metode til at hente interfaces af samtlige afdelinger
            IEnumerator afdelingsIterator = controller.GetDepartmentList();
            afdelingsIterator.Reset();
            IAfdeling iAfdeling;

            while (afdelingsIterator.MoveNext())
            {
                iAfdeling = (IAfdeling)afdelingsIterator.Current;

                CbbChooseDepartment.Items.Add(iAfdeling.DepartmentName);
            }
        }

       
    }
}
