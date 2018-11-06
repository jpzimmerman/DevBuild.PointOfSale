using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevBuild.PointOfSale_System {
    class CreditCardInfo {
        private string CardholderName   { get; set; }
        private byte[] CardNumber       = new byte[16];
        private byte[] CVV              = new byte[3];
        private DateTime ExpirationDate = new DateTime();
    }
}
