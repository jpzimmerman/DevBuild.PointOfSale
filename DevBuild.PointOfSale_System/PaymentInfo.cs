using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevBuild.PointOfSale_System {
    public abstract class PaymentInfo {

        private double _tenderedAmount;
        private double _balanceAmount;
        private double _changeAmount;

        public double TenderedAmount {
            get { return _tenderedAmount; }
            set { _tenderedAmount = value;
                if ( _tenderedAmount < 0) {
                    _tenderedAmount = 0;
                }
            }
        }
        public double BalanceAmount {
            get { return _balanceAmount; }
            set {
                _balanceAmount = value;
                if (_balanceAmount < 0) { _balanceAmount = 0.00f; }
            }
        } 
        public double ChangeAmount { get; set; }

        public PaymentInfo() { }

        public PaymentInfo(double tenderedAmt) => _tenderedAmount = tenderedAmt;


    }
}
