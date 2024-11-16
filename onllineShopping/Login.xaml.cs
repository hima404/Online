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

namespace onllineShopping
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        onlineEntities1 db = new onlineEntities1();
        public Login()
        {
            InitializeComponent();
        }

        private void loginn(object sender, RoutedEventArgs e)
        {
            ShowProducts show = new ShowProducts();

            
            var email = txtname.Text;
            var pass = txtapassword.Password;
            var s = db.users.FirstOrDefault(x => x.Email == email && x.passwords == pass);
            if (s != null)
            {
                MessageBox.Show("Login sucssfuly");
                NavigationService.Navigate(show);

            }
            else if (txtname.Text == "1" && txtapassword.Password == "1")
            {
                admin admin = new admin();
                NavigationService.Navigate(admin);
            }
            else
            {
                MessageBox.Show("password or email invalid");
            }


         
        }

        private void signup(object sender, RoutedEventArgs e)
        {
           Signup signup = new Signup();
            NavigationService.Navigate(signup);
        }

        private void Forget_Pass(object sender, RoutedEventArgs e)
        {
            forgetPass forgetPass = new forgetPass();
            NavigationService.Navigate(forgetPass);
        }
    }
}
