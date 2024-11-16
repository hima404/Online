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
    /// Interaction logic for admin.xaml
    /// </summary>
    public partial class admin : Page
    {
        onlineEntities1 db = new onlineEntities1();
        public admin()
        {
            InitializeComponent();
            dataGridProducts.ItemsSource = db.products.Select(x => new { x.Names , x.price }).ToList();
        }

        private void AddProduct_Click(object sender, RoutedEventArgs e)
        {
            product product = new product();
            product.Names = txtProductName.Text;
            product.price = int.Parse(txtPrice.Text);
            db.products.Add(product);
            db.SaveChanges();
            dataGridProducts.ItemsSource = db.products.Select(x => new { x.Names, x.price }).ToList();


        }
    }
}
