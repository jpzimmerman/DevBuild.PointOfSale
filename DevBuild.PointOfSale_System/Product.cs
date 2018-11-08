using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevBuild.PointOfSale_System {

    public enum ProductCategory { Apparel, Housewares, Games, Electronics, Grocery, Toys }

    [Serializable]
    public class Product : ICloneable {
        public string Name { get; set; }
        public string Description { get; set; }
        private ProductCategory Category { get; set; }
        public Bitmap Image { get; set; }
        public string SKU { get; set; }
        public float Price { get; set; }
        private int _numberInStock;

        public Product() {
        }

        public Product(string name, string description, ProductCategory category, string sku, float price, int numInStock) {
            Name = name;
            Description = description;
            SKU = sku;
            Category = category;
            Price = price;
            _numberInStock = numInStock;

        }

        public int NumberInStock {
            get { return _numberInStock; }
            set { _numberInStock = value; if (_numberInStock < 0) { _numberInStock = 0; } }
        }

        public override string ToString() {
            return $"{Name.PadRight(15)} | {_numberInStock} | { Description.PadRight(40)} | {Category.ToString().PadRight(10)} | {Price} | In stock: {_numberInStock}";
        }

        public object Clone() {
            return this.MemberwiseClone();
        }
    }
}
