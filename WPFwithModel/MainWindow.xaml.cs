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
using WPFwithModel.Models;
using WPFwithModel.ViewModel;

namespace WPFwithModel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IMachine coffeeMaker;
        public MainWindow()
        {
            InitializeComponent();
            coffeeMaker = new CoffeeMaker("Super Ultra Coffee maker");
            this.DataContext = new CoffeeMakerViewModel(coffeeMaker);
        }


        private void btnAddBeans_Click(object sender, RoutedEventArgs e)
        {
            coffeeMaker.TaskTwo();           
        }

        private void btnBrew_Click(object sender, RoutedEventArgs e)
        {
            coffeeMaker.Task();        
        }
    }
}
