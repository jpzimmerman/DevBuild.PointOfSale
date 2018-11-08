using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevBuild.PointOfSale_System {
    class CreditCardInfo : PaymentInfo {
        public byte[] CVV { get; set; } = new byte[3];
        public DateTime ExpirationDate { get; set; } = new DateTime();

        public byte[] CardNumber { get; set; } = new byte[16];

        public override bool PaymentInfoComplete() {
            return true;
        }



    }
}
