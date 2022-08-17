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

using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace NetStockValueConvAssignment16Aug
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        NorthwindEntities northwindEntities = new NorthwindEntities();

        public MainWindow()
        {
            InitializeComponent();
            
            
        }
        

        private void myProduct_Loaded(object sender, RoutedEventArgs e)
        {
            myProduct.DataContext= northwindEntities.Products.ToList();
        }
    }
}
