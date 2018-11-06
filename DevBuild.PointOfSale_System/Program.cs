using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevBuild.PointOfSale_System {
    class Program {
        public enum ProgramState { MainMenu, ItemDisplay, Checkout, OrderFinal }
        
        static void Main(string[] args) {
            Product product1 = new Product("Soup", "A can of fancy-ass condensed soup", ProductCategory.Grocery, "0A22823", 0.79f, 5);

            Product product2 = new Product("Tablecloth", "A large, gingham tablecloth", ProductCategory.Housewares, "0F81992", 3.99f, 6);

            Product product3 = new Product("Candle", "A lovely scented candle", ProductCategory.Housewares, "0X21824", 1.99f, 12);

            Product[] productsToAdd = { product1, product2, product3 };

            foreach (Product p in productsToAdd) {
                if (Inventory.Items.ContainsKey(p.Name)) {
                    Inventory.Items[p.Name].NumberInStock++;
                }
                else {
                    Inventory.Items.Add(p.Name, p);
                }
            }

            Inventory.DisplayItems();

            //Console.SetWindowSize(1, 1);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form posForm = new PointOfSaleMain();
            posForm.Opacity = 0.95f;
            Application.Run(posForm);

            Inventory.Save();
            Application.Exit();
        }
    }
}
