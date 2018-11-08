using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevBuild.PointOfSale_System {
    public sealed class Inventory {
        public static Dictionary<string, Product> Items { get; set; } = new Dictionary<string, Product>();

        static Inventory() {
            Load();
        }

        private Inventory() {
        }

        public static void Load() {
            if (File.Exists("items.dat"))
                {
                using (FileStream stream = File.Open("items.dat", FileMode.Open)) {
                    BinaryFormatter formatter = new BinaryFormatter();
                    var data = formatter.Deserialize(stream);
                    Items = (Dictionary<string, Product>)data;
                    stream.Close();
                }
            }
        }

        public static void Save() {
            using (FileStream stream = File.Open("items.dat", FileMode.OpenOrCreate)) {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, Items);
                stream.Close();
            }
        }

        public static void DisplayItems() {
            foreach (KeyValuePair<string, Product> c in Inventory.Items) {
                Console.WriteLine(c.Value);
            }
        }

        public static void SellItems(string boughtItem) {
            //string boughtItem = "Soup";
            if (Items.ContainsKey(boughtItem) && Items[boughtItem].NumberInStock > 0) {
                Product p = CheckoutCart.CartItems.Find(x => x.Name == boughtItem);
                if (p != null) {
                    p.NumberInStock++;
                }
                else {
                    Product cartEntry = (Product)Items[boughtItem].Clone();
                    cartEntry.NumberInStock = 1;
                    CheckoutCart.CartItems.Add(cartEntry);
                }
                Items[boughtItem].NumberInStock--;
                Console.WriteLine($"{boughtItem} bought");
                DisplayItems();
            }
        }
        public static void ReturnItems(string returnItem) {
            if (Items.ContainsKey(returnItem)) {
                if (Items.ContainsKey(returnItem) && Items[returnItem].NumberInStock > 0) {
                    Product p = CheckoutCart.CartItems.Find(x => x.Name == returnItem);
                    if (p != null) {
                        p.NumberInStock--;
                        if (p.NumberInStock == 0) {
                            CheckoutCart.CartItems.Remove(p);
                        }
                    }
                }
                Items[returnItem].NumberInStock++;
                Console.WriteLine($"{returnItem} returned to stock");
                DisplayItems();
            }
        }

    }
}
