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
    /// Interaction logic for cart.xaml
    /// </summary>
    public partial class cart : Page
    {
        onlineEntities1 db = new onlineEntities1();

      

        public cart()
        {
            var o = db.orders.Select(x => new { x.orderID, x.productName, });
            product p = new product();
            order order = new order();
            InitializeComponent();
            dgrid.ItemsSource = o.ToList(); 
            
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var oo = db.orders.Select(x => new { x.orderID, x.productName, });
            var o = db.orders;
            db.orders.RemoveRange(o);
            db.SaveChanges();
            dgrid.ItemsSource = oo.ToList();

        }
    }
}
