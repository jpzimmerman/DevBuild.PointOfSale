using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevBuild.PointOfSale_System {
    class CheckoutCart {
        public static List<Product> CartItems { get; set; } = new List<Product>();

        public static double CalculateSubtotal() {
            double subtotal = 0.0f;

            foreach (Product p in CartItems) {
                subtotal += p.Price * p.NumberInStock;
            }

            return subtotal;
        }
    }
}
