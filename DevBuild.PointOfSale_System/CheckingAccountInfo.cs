using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevBuild.PointOfSale_System {
    class CheckingAccountInfo : PaymentInfo {
        public byte[] RoutingNumber { get; set; } = new byte[9];
        public byte[] AccountNumber { get; set; } = new byte[9];

        public CheckingAccountInfo() { }

        public CheckingAccountInfo(double tenderedAmount) : base(tenderedAmount) { }
    }
}
