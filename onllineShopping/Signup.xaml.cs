using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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

namespace onllineShopping
{
    /// <summary>
    /// Interaction logic for Signup.xaml
    /// </summary>
    public partial class Signup : Page
    {
        onlineEntities1 db = new onlineEntities1();
        public Signup()
        {
            InitializeComponent();
        }

        private void sign_up(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(nameTxt.Text) || string.IsNullOrEmpty(emailTxt.Text) || string.IsNullOrEmpty(passTxt.Password) || string.IsNullOrEmpty(txtconfirmpass.Password))
            {
                MessageBox.Show("Require Field!");
            }
            else if(passTxt.Password != txtconfirmpass.Password)
            {
                MessageBox.Show("Password not match");
            }
            else
            {
                user use = new user();
                use.Names = nameTxt.Text;
                use.Email = emailTxt.Text;
                use.passwords = passTxt.Password;
                db.users.AddOrUpdate(use);
                db.SaveChanges();
                Login login = new Login();
                NavigationService.Navigate(login);
            }
        }
    }
}
