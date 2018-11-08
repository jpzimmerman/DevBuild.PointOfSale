using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevBuild.Utilities;

namespace DevBuild.PointOfSale_System {
    public partial class PaymentForm : Form {
        CashInfo testCashInfo = new CashInfo(0.00);
        CreditCardInfo testCreditInfo = new CreditCardInfo();
        CheckingAccountInfo testCheckingInfo = new CheckingAccountInfo();

        List<GroupBox> paymentGroupboxes = new List<GroupBox>();


        private string _previousCreditCardValueStr;
        private string _previousCVVString;

        public PaymentForm() {
            InitializeComponent();
            InitializeGrandTotal();
            this.StartPosition = FormStartPosition.CenterParent;
            this.CashAmountField.Click += StartKeypad;
            _previousCreditCardValueStr = CreditCardNumberField.Text;
            _previousCVVString = CreditCardCVVField.Text;

            paymentGroupboxes.Add(GroupboxCash);
            paymentGroupboxes.Add(GroupboxCheck);
            paymentGroupboxes.Add(GroupboxCredit);
            paymentGroupboxes.Add(GroupboxGiftCard);

            foreach (GroupBox g in paymentGroupboxes) {
                g.Visible = false;
            }
        }

        private void SelectPaymentMethodGroupbox(object sender, EventArgs e) {
            if (sender is Control) {
                Control controlRef = (Control)sender;
                foreach (GroupBox g in paymentGroupboxes) {
                    g.Visible = (g.Tag.ToString() == controlRef.Tag.ToString());
                }
            }
        }

        public void InitializeGrandTotal() {
            GrandTotalValue.Text = PointOfSaleRepository.Total.ToString("C");
        }

        private void StartKeypad(object sender, EventArgs e) {
            Form keypadForm = new Keypad();
            keypadForm.FormClosing += delegate {
                if (!String.IsNullOrEmpty((keypadForm as Keypad).KeypadTextValue)) {
                    this.CashAmountField.Text = (keypadForm as Keypad).KeypadTextValue;
                }
            };
            keypadForm.Show();
        }

        private void GoBackButton_Click(object sender, EventArgs e) {
            Application.OpenForms[0].Show();
            this.Close();
        }


        private void CashChangeField_Click(object sender, EventArgs e) {

        }

        private void CurrencyButton_Click(object sender, EventArgs e) {
            double testValue = 0.0;
            double tenderedValue = 0;
            if (sender is Control) {
                Control controlRef = (Control)sender;
                if (double.TryParse(CashAmountField.Text.ToString().Substring(CashAmountField.Text.ToString().Contains('$') ? 1 : 0), out testValue)) {
                    testCashInfo.TenderedAmount = testValue;
                }

                if (double.TryParse(controlRef.Tag.ToString(), out tenderedValue))
                    {
                    testCashInfo.TenderedAmount += tenderedValue;
                    CashAmountField.Text = testCashInfo.TenderedAmount.ToString("C");
                }
            }
        }

        private void CashAmountField_TextChanged(object sender, EventArgs e) {

            if (double.TryParse((sender as Control).Text.ToString().Substring(CashAmountField.Text.ToString().Contains('$') ? 1 : 0), out double x)) {
                testCashInfo.TenderedAmount = x;
                testCashInfo.BalanceAmount = PointOfSaleRepository.Total - testCashInfo.TenderedAmount;
                double testChange = PointOfSaleRepository.Total - testCashInfo.TenderedAmount;
                testCashInfo.ChangeAmount = testChange < 0.0 ? Math.Abs(testChange) : 0.0;
                CashBalanceField.Text = testCashInfo.BalanceAmount.ToString("C");
                if (testCashInfo.BalanceAmount <= 0) {
                    CashChangeField.Text = testCashInfo.ChangeAmount.ToString("C");
                }

            }
        }

        private void GroupboxCredit_Enter(object sender, EventArgs e) {

        }

        private void CreditCardNumberField_GotFocus(object sender, EventArgs e) {
            _previousCreditCardValueStr = CreditCardNumberField.Text;
        }

        private void CreditCardNumberField_TextChanged(object sender, EventArgs e) {
            if (String.IsNullOrEmpty(CreditCardNumberField.Text) || Validation.ValidateInfo(InformationType.NumericStrict, CreditCardNumberField.Text)) {
                for (int i = 0; i < CreditCardNumberField.Text.Length; i++) {
                    testCreditInfo.CardNumber[i] = (byte)CreditCardNumberField.Text[i];
                }
                _previousCreditCardValueStr = CreditCardNumberField.Text;
            }
            else { CreditCardNumberField.Text = _previousCreditCardValueStr;
                CreditCardNumberField.SelectionStart = CreditCardNumberField.Text.Length;
            }
        }

        private void CreditCardConfirmButton_Click(object sender, EventArgs e) {

        }

        private void CreditCardCVVField_GotFocus(object sender, EventArgs e) {
            _previousCVVString = CreditCardCVVField.Text;
        }

        private void CreditCardCVVField_TextChanged(object sender, EventArgs e) {

        }

        private void NumericField_GotFocus(object sender, EventArgs e) {

        }

        private void NumericField_TextChanged(object sender, EventArgs e) {

        }
    }
}
