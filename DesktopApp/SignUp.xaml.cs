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
    /// Interaction logic for SignUp.xaml
    /// </summary>
    public partial class SignUp : Page
    {
        public SignUp()
        {
            InitializeComponent();
            this.PreviewKeyDown += new KeyEventHandler(LoginEnter);
        }

        private void LoginEnter(object sender, KeyEventArgs e)
        {
            labelError.Visibility = System.Windows.Visibility.Hidden;
        }

        private void buttonSignUp_Click(object sender, RoutedEventArgs e)
        {
            SignIn signIn = new SignIn();
            this.NavigationService.Navigate(signIn);
        }

        private void SignUpButton_Click(object sender, RoutedEventArgs e)
        {
            if (this.passwordBox.Password == "123" && this.textBoxLogin.Text == "xyz" && this.textBoxEmail.Text == "y.shk@gmail.com" && this.ConfirmPasswordBox.Password == this.passwordBox.Password)
            {
                Console.WriteLine(passwordBox.Password + textBoxLogin.Text + textBoxEmail.Text + ConfirmPasswordBox.Password);
                MainWindow MainWindow = new MainWindow();
                Window.GetWindow(this).Close();
                MainWindow.Show();
            }
            else
            {
                labelError.Visibility = System.Windows.Visibility.Visible;

                labelError.Content = "Not all fields are filled or password is not confirmed";
            }
        }
    }
}
