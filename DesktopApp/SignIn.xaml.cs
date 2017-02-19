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

namespace DesktopApp
{
    /// <summary>
    /// Interaction logic for SignIn.xaml
    /// </summary>
    public partial class SignIn : Page
    {
        public SignIn()
        {
            InitializeComponent();

            this.PreviewKeyDown += new KeyEventHandler(LoginEnter);
            textBoxLogin.Focus();
        }

        private void LoginEnter(object sender, KeyEventArgs e)
        {
            labelError.Visibility = System.Windows.Visibility.Hidden;
        }

        private void buttonSignUp_Click(object sender, RoutedEventArgs e)
        {
            SignUp singUp = new SignUp();
            this.NavigationService.Navigate(singUp);
        }

        private void SignInButton_Click(object sender, RoutedEventArgs e)
        {
            if (this.passwordBox.Password == "123" && this.textBoxLogin.Text == "xyz")
            {
                MainWindow MainWindow = new MainWindow();
                Window.GetWindow(this).Close();
                MainWindow.Show();
            }
            else
            {
                labelError.Visibility = System.Windows.Visibility.Visible;

                labelError.Content = "Wrong password or login";
            }
        }
    }

    
}
