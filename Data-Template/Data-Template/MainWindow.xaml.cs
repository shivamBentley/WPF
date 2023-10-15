using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

namespace Data_Template
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Person obj { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            Console.WriteLine("This before initialiation ", this);

            obj = new Person(); 

            obj.Name = "Virat Kohli";

            Console.WriteLine("This After initialiation ", this);
            this.DataContext = this;
        }

        public class Person
        {
            public string Name { get; set; }

            //public override string ToString()
            //{
            //    return Name.ToString();
            //}
        }
    }
}
