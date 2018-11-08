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
    public partial class Keypad : Form {

        private string _previousValue;
        public string KeypadTextValue { get { return FinalValue.Text; } }

        public Keypad() {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            _previousValue = FinalValue.Text;
        }



        private void EnterButton_Click(object sender, EventArgs e) {
 
            this.Close();
        }

        private void FinalValue_GotFocus(object sender, EventArgs e) {
            _previousValue = FinalValue.Text;
        }

        private void FinalValue_TextChanged(object sender, EventArgs e) {
            if (!String.IsNullOrEmpty(FinalValue.Text) && !Validation.ValidateInfo(InformationType.Numeric, FinalValue.Text)) { FinalValue.Text = _previousValue; }
            _previousValue = FinalValue.Text;

            this.DecimalButton.Enabled = !(this.FinalValue.Text.Contains('.'));


        }

        private void KeypadButton_Click(object sender, EventArgs e) {
            if (sender is Control) {
                Control controlRef = (Control)sender;
                //Tag for object should be set to the keypad value. If keypad button's tag is an integer (non-negative, no decimal places), then we can safely add it to the value displayed at the top of the form
                if (int.TryParse(controlRef.Tag.ToString().Trim(), out var tmp)) {
                    FinalValue.Text = String.Concat(FinalValue.Text, controlRef.Tag.ToString());
                }
            }
        }

        private void DecimalButton_Click(object sender, EventArgs e) {
            if (!FinalValue.Text.Contains('.')) {
                FinalValue.Text = String.Concat(FinalValue.Text, '.');
            }
        }
    }
}
