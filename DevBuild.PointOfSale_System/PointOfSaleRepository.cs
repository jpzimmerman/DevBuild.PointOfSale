using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevBuild.PointOfSale_System {
    public enum PaymentType { Cash, Check, Credit}

    public class PointOfSaleRepository {
        private const double LOCAL_SALES_TAX_RATE = 0.0600f;

        public static double Total {
            get { return CheckoutCart.CalculateSubtotal() * (1.00f + LOCAL_SALES_TAX_RATE); }
        }
        public static double SalesTaxAmount {
            get { return CheckoutCart.CalculateSubtotal() * LOCAL_SALES_TAX_RATE; }
        }

        public static bool ApplyCoupon(List<Product> shoppingCart, CouponInfo coupon) {
            return true;
        }

        public void GetCreditCardInfo() {
            CreditCardInfo tmp = new CreditCardInfo();
        }

        public void GetPaymentInfo(PaymentType paymentType) { }
    }
}
