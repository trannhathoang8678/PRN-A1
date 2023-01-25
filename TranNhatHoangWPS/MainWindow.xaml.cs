using BusinessObject;
using Repository;
using System;
using System.Windows;
using System.Windows.Input;


namespace TranNhatHoangWPS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string STAFF_ROLE = "Staff";
        private const string CUSTOMER_ROLE = "Customer";
        private String role = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please enter your email and password");
                return;
            }
            if (role.Equals(STAFF_ROLE))
            {
                var staff = checkStaffAccount();
                if (staff == null)
                {
                    MessageBox.Show("Wrong username or password");
                    return;
                }
                if (staff.Role == 1)
                {
                    AdminWindow adminWindow = new AdminWindow();
                    Close();
                    adminWindow.Show();
                }
                else
                {
                    MessageBox.Show("Welcome staff");
                }
            }
            if (role.Equals(CUSTOMER_ROLE))
            {
                var customer = checkCustomerAccount();
                if(customer == null)
                {
                    MessageBox.Show("Wrong username or password");
                }    
                else
                {
                    MessageBox.Show(string.Format("Welcome customer {0}",customer.CustomerName));
                }    
            }
        }

        private StaffAccount checkStaffAccount()
        {
            StaffRepository staffRepository = new StaffRepository();
            return staffRepository.Login(txtEmail.Text, txtPassword.Text);
        }
        private Customer checkCustomerAccount()
        {
            CustomerRepository customerRepository = new CustomerRepository();
            return customerRepository.Login(txtEmail.Text, txtPassword.Text);
        }
        private void StaffPicture_MouseDown(object sender, MouseEventArgs e)
        {
            role = "Staff";
            StaffTickImage.Visibility = Visibility.Visible;
            CustomerTickImage.Visibility = Visibility.Hidden;
        }

        private void CustomerPicture_MouseDown(object sender, MouseEventArgs e)
        {
            role = "Customer";
            StaffTickImage.Visibility = Visibility.Hidden;
            CustomerTickImage.Visibility = Visibility.Visible;
        }
    }
}
