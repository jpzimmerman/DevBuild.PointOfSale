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
            Product product1 = new Product("He-Man Action Figure", "Mint condition He-Man action figure", ProductCategory.Toys, "0A22823", 249.99f, 5);

            Product product2 = new Product("Rock'em Sock'em Robots", "Classic game where kids haphazardly beat the crap out of each other", ProductCategory.Games, "0F81992", 24.95f, 6);

            Product product3 = new Product("Spirograph", "Teach your kids geometry early!", ProductCategory.Toys, "0X21274", 19.99f, 12);
            Product product4 = new Product("Creepy Crawlers", "You just sang that title, and that's okay.", ProductCategory.Toys, "0X28919", 59.99f, 12);
            Product product5 = new Product("Vintage Tonka truck", "These trucks were bigger than you were as a child", ProductCategory.Toys, "0T99286", 39.95f, 12);
            Product product6 = new Product("Handheld Arcade Baseball", "More fun than it sounds!", ProductCategory.Toys, "0X18319", 9.99f, 12);
            Product product7 = new Product("Hot Wheels Playset collection", "Every playset we could get our hands on.", ProductCategory.Toys, "0T51384", 399.99f, 12);
            Product product8 = new Product("A whole bunch of Yo-Yos", "Not sure what you'll do with this many, but you can start the craze again!", ProductCategory.Toys, "0X18319", 9.99f, 12);
            Product product9 = new Product("At least five Wishing Trolls", "These hang pretty well from backpacks", ProductCategory.Toys, "0K57284", 9.99f, 12);
            Product product10 = new Product("Sorry!", "Still ended friendships, but not as many as Monopoly.", ProductCategory.Games, "0F85932", 14.95f, 12);
            Product product11= new Product("Neon Nintendo Switch", "I got mine for free, but you need one too!", ProductCategory.Games, "0G28985", 229.95f, 12);
            Product product12 = new Product("Stretch Armstrong", "The original!", ProductCategory.Games, "0U18227", 12.95f, 12);


            Product[] productsToAdd = { product1, product2, product3, product4, product5, product6, product7, product8, product9, product10, product11, product12};

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
