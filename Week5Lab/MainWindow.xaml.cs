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

namespace Week5Lab
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

        private void AddToOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            {
                if (HamburgerBtn.IsChecked == true)
                {
                    listBox.Items.Add ("Hamburger");
                }
                else if (CheeseburgerBtn.IsChecked == true)
                {
                    listBox.Items.Add("Cheeseburger");

                }

                else if (ChickenBtn.IsChecked == true)
                {
                    listBox.Items.Add("Chicken Fingers");

                }

                else if (PizzaBtn.IsChecked == true)
                {
                    listBox.Items.Add("Pizza");

                }

                else if (MedFryBtn.IsChecked == true)
                {
                    listBox.Items.Add("Medium Fries");
                }

                else if (LargeFryBtn.IsChecked == true)
                {
                    listBox.Items.Add("Large Fries");
                }
            }
        }

        private void resetBtn_Click(object sender, RoutedEventArgs e)
        {
            listBox.Items.Clear();
        }

        private void Checkoutbtn_Click(object sender, RoutedEventArgs e)
        {

            listBox.Visibility = Visibility.Visible;
            TotalLabel.Visibility = Visibility.Visible;
            groupBox.Visibility = Visibility.Hidden;
            resetBtn.Visibility = Visibility.Hidden;
            AddToOrderBtn.Visibility = Visibility.Hidden;
            CheckoutBtn.Visibility = Visibility.Hidden;
        }
    }
}
