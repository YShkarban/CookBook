using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DesktopApp
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    /// to do messege when not apply pass or login(textfieldchange;errorhide)
    public partial class LoginWindow : Window
    {
        

        public LoginWindow()
        {
           
            InitializeComponent();

        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void passwordBox_KeyDown(object sender, KeyEventArgs e)
        {     
        }

        private void ButtonSubmit_Click(object sender, RoutedEventArgs e)
        {
            if (this.passwordBox.Password == "123" && this.textBoxLogin.Text == "xyz")
            {
                //Do the stuff; 
            }
            else
            { 
                //Show error
            }     
        }
    }
}
