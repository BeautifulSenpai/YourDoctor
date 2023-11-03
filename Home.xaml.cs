using YourDoctor.Pages;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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
using System.Windows.Shapes;

namespace YourDoctor
{
    /// <summary>
    /// Логика взаимодействия для Delivery.xaml
    /// </summary>
    public partial class Home : Window
    {
        private List<string> userRoles;
        public Home(List<string> roles)
        {
            InitializeComponent();
            userRoles = roles;
            if (userRoles.Contains("Фармацевт"))
            {
                rdCustomers.Visibility = Visibility.Collapsed;
                rdOrders.Visibility = Visibility.Collapsed;
                rdOrderItems.Visibility = Visibility.Collapsed;
                rdSuppliers.Visibility = Visibility.Collapsed;
                rdSupply.Visibility = Visibility.Collapsed;
                rdReviews.Visibility = Visibility.Collapsed;
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnRestore_Click(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Normal)
                WindowState = WindowState.Maximized;
            else
                WindowState = WindowState.Normal;
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void rdProducts_Click(object sender, RoutedEventArgs e)
        {
            frameContent.Navigate(new Pages.Products(userRoles));
        }

        private void rdCustomers_Click(object sender, RoutedEventArgs e)
        {
            frameContent.Navigate(new Customers(userRoles));
        }

        private void rdOrders_Click(object sender, RoutedEventArgs e)
        {
            frameContent.Navigate(new Orders(userRoles));
        }

        private void rdOrderItems_Click(object sender, RoutedEventArgs e)
        {
            frameContent.Navigate(new OrderItems(userRoles));
        }

        private void rdSuppliers_Click(object sender, RoutedEventArgs e)
        {
            frameContent.Navigate(new Suppliers(userRoles));
        }

        private void rdSupply_Click(object sender, RoutedEventArgs e)
        {
            frameContent.Navigate(new Supply(userRoles));
        }

        private void rdPrescriptionMedications_Click(object sender, RoutedEventArgs e)
        {
            frameContent.Navigate(new PrescriptionMedications(userRoles));
        }

        private void rdReviews_Click(object sender, RoutedEventArgs e)
        {
            frameContent.Navigate(new Reviews(userRoles));
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void btnLogout_Click(object sender, MouseButtonEventArgs e)
        {
            Login w1 = new Login();
            this.Close();
            w1.Show();
        }
    }
}
