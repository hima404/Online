using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
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
    /// Interaction logic for ShowProducts.xaml
    /// </summary>
    public partial class ShowProducts : Page
    {
        onlineEntities1 db = new onlineEntities1();

        public ShowProducts()
        {
            InitializeComponent();
            dgrid.ItemsSource = db.products.Select(x => new { x.productId,x.Names, x.price }).ToList();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            order order = new order();

            // Parse the product ID from input
            var id = int.Parse(txtprduectid.Text);

            var product = db.products.Select(p => new { p.productId, p.Names, p.price })  .FirstOrDefault();

            if (product == null)
            {
                MessageBox.Show("المنتج غير موجود.");
                return;
            }

            order.products_ID = product.productId; 
            order.productName = product.Names; 


            db.orders.Add(order);
            db.SaveChanges();


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            cart cart1 = new cart();

            NavigationService.Navigate(cart1);
        }
    }
}
