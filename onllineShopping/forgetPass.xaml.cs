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
    /// Interaction logic for forgetPass.xaml
    /// </summary>
    public partial class forgetPass : Page
    {
        onlineEntities1 db = new onlineEntities1();
        public forgetPass()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            user user = new user();
             user = db.users.FirstOrDefault(x => x.Email == emailTxt.Text );
            if (user != null) 
            {
                user.Email = emailTxt.Text;
                user.passwords = passTxt.Password;
                db.users.AddOrUpdate(user);
                db.SaveChanges();
                MessageBox.Show("updated");
            }
            else if (passTxt.Password == txtconpass.Password)
            {
                Login login = new Login();
                NavigationService.Navigate(login);
            }

            if (passTxt.Password != txtconpass.Password)
            {
                MessageBox.Show("password not matching");
            }


        }
    }
}
