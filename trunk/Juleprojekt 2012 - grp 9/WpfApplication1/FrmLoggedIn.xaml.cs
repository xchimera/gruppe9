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

//Søren Rasmussen
namespace GUI
{
    /// <summary>
    /// Interaction logic for FrmLoggedIn.xaml
    /// </summary>
    public partial class FrmLoggedIn : Window
    {
        private Controller.SystemController controller;

      

        public FrmLoggedIn(Controller.SystemController controller)
        {

            InitializeComponent();
            this.controller = controller;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BtnDeptCreate_Click(object sender, RoutedEventArgs e)
        {
            var newWindow = new FrmCreateDepartment(controller);
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

        private void BtnUserCreate_Click(object sender, RoutedEventArgs e)
        {
            var newWindow = new FrmCreateUser();
            newWindow.Show();
        }

        private void BtnUserEdit_Click(object sender, RoutedEventArgs e)
        {
            var newWindow = new FrmEditUser();
            newWindow.Show();
        }

        private void BtnUserDelete_Click(object sender, RoutedEventArgs e)
        {
            var newWindow = new FrmDeleteUser();
            newWindow.Show();
        }

        private void BtnSpgCreate_Click(object sender, RoutedEventArgs e)
        {

            var newWindow = new FrmCreateQuestion();
            newWindow.Show();
        }

        private void BtnSpgEdit_Click(object sender, RoutedEventArgs e)
        {
            var newWindow = new FrmEditQuestion();
            newWindow.Show();
        }

        private void BtnSpgDelete_Click(object sender, RoutedEventArgs e)
        {
            var newWindow = new FrmDeleteQuestion();
            newWindow.Show();
        }

        private void BtnSurveyPublish_Click(object sender, RoutedEventArgs e)
        {
            var newWindow = new FrmPublishSurvey(controller);
            newWindow.Show();
        }

        private void BtnSurveyStopPublish_Click(object sender, RoutedEventArgs e)
        {
            var newWindow = new FrmStopPublishSurvey();
            newWindow.Show();
        }

        private void BtnSurveyCreate_Click(object sender, RoutedEventArgs e)
        {
            var newWindow = new FrmCreateSurvey();
            newWindow.Show();
        }

        private void BtnSurveyEdit_Click(object sender, RoutedEventArgs e)
        {
            var newWindow = new FrmEditSurvey();
            newWindow.Show();
        }

        private void BtnSurveyDelete_Click(object sender, RoutedEventArgs e)
        {
            var newWindow = new FrmDeleteSurvey();
            newWindow.Show();
        }

        private void BtnClientDelete_Click(object sender, RoutedEventArgs e)
        {
            var newWindow = new FrmDeleteClient();
            newWindow.Show();
        }

    }
}
