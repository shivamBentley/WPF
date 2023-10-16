using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Routed_Events
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void InnButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("I the inner button");
        }

        private void btnClickMe_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("I the outer button");
        }

        private void outerEllipse_MouseDown(object sender, MouseButtonEventArgs e)
        {
            // MessageBox.Show("I am the Green Ellipse");           
            this.Title = "Green Ellipse changed the Title";

        }

        private void btnClickMe_PreviewMouseMove(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Mouse move by outer button");
        }

        private void InnButton_PreviewMouseMove(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Mouse move by inner button");
        }
    }
}
