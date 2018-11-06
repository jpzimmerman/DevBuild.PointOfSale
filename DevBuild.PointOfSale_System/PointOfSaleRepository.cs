using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevBuild.PointOfSale_System {
    enum PaymentType { Cash, Check, Credit}

    class PointOfSaleRepository {


        public static double Subtotal { get; set; } = 0.0f;

        public bool ApplyCoupon(List<Product> shoppingCart, CouponInfo coupon) {
            return true;
        }

        public void GetCreditCardInfo() {
            CreditCardInfo tmp = new CreditCardInfo();
        }

        public void GetPaymentInfo(PaymentType paymentType) { }
    }
}
