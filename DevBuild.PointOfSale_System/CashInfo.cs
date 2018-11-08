using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevBuild.PointOfSale_System {
    public class CashInfo : PaymentInfo {
        public CashInfo(double tenderedAmount) : base(tenderedAmount) { }

        public override bool PaymentInfoComplete() {
            return (ChangeAmount >= 0);
        }
    }
}
