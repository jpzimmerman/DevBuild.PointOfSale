using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevBuild.PointOfSale_System {
    public partial class PointOfSaleMain : Form {
        public PointOfSaleMain() {
            InitializeComponent();
            SoupQtyTextBox.Text = "0";
            UpdateTotals();
            //paymentForm.Shown += delegate { paymentForm.InitializeGrandTotal(); };
        }

        //private PaymentForm paymentForm = new PaymentForm();

        private void SoupQtyTextBox_TextChanged(object sender, EventArgs e) {
            int numOutput;
            SoupQtyUp.Enabled = !(Inventory.Items["Soup"].NumberInStock == 0);
            if (int.TryParse(SoupQtyTextBox.Text, out numOutput)) {
                if (Inventory.Items["Soup"].NumberInStock == 0) {
                    SoupQtyTextBox.Text = SoupQtyTextBox.Text;
                }
            }
            else { SoupQtyTextBox.Text = "0"; }
            SubtotalTextBox.Text = CheckoutCart.CalculateSubtotal().ToString("#,###.00");
        }

        private void UpdateTotals() {
            SubtotalTextBox.Text = CheckoutCart.CalculateSubtotal().ToString("C");
            TaxTextBox.Text = PointOfSaleRepository.SalesTaxAmount.ToString("C");
            TotalTextBox.Text = PointOfSaleRepository.Total.ToString("C");
        }

        private void CheckoutButton_Click(object sender, EventArgs e) {
            this.Hide();
            new PaymentForm().Show();
        }

        private void UpdateListboxItems() {
            listBox1.BeginUpdate();
            listBox1.Update();
            listBox1.EndUpdate();
        }


        private void QtyUp_Click(object sender, EventArgs e) {
            int i;
            if (sender is Control) {
                Control controlRef = sender as Control;
                bool itemFound = false;

                if (Inventory.Items[controlRef.Tag.ToString()].NumberInStock > 0) {
                    //SoupQtyTextBox.Text = (++textBoxQty).ToString()
                    Inventory.SellItems(controlRef.Tag.ToString());

                    for (i = 0; i < listBox1.Items.Count; i++) {
                        if (listBox1.Items[i] is Product && (listBox1.Items[i] as Product).Name == controlRef.Tag.ToString()) {
                            itemFound = true;
                            (listBox1.Items[i] as Product).NumberInStock++;
                            //listBox1.Invalidate(listBox1.GetItemRectangle(i));
                            listBox1.Items[i] = listBox1.Items[i];
                            break;
                        }
                    }
                    //if we've reached the end of the listbox items and didn't find one of the items we just bought, 
                    //let's add a new listbox entry for the item
                    if (!itemFound) {
                        Product listProduct = (Product)Inventory.Items[controlRef.Tag.ToString()].Clone();
                        listProduct.NumberInStock = 1;
                        listBox1.Items.Add(listProduct);
                    }
                    UpdateListboxItems();
                }
                UpdateTotals();

                if (Inventory.Items[controlRef.Tag.ToString()].NumberInStock == 0) {
                    controlRef.Enabled = false;
                }
            }
        }

        private void QtyDown_Click(object sender, EventArgs e) {
            int i;
            if (sender is Control) {
                Control controlRef = sender as Control;
                if (int.TryParse(SoupQtyTextBox.Text.Trim(), out i) && i > 0) {
                    SoupQtyTextBox.Text = (--i).ToString();
                }
                if (Inventory.Items[controlRef.Tag.ToString()].NumberInStock == 1) {
                    controlRef.Enabled = true;
                }
                Inventory.ReturnItems(controlRef.Tag.ToString());
                for (int j = 0; j < listBox1.Items.Count; j++) {
                    if (listBox1.Items[j] is Product && (listBox1.Items[j] as Product).Name == controlRef.Tag.ToString()) {
                        (listBox1.Items[j] as Product).NumberInStock--;
                        //listBox1.Invalidate(listBox1.GetItemRectangle(j));
                        listBox1.Items[j] = listBox1.Items[j];
                        if ((listBox1.Items[j] as Product).NumberInStock == 0) {
                            listBox1.Items.RemoveAt(j);
                        }
                        UpdateListboxItems();
                        SubtotalTextBox.Text = CheckoutCart.CalculateSubtotal().ToString("C");
                        TaxTextBox.Text = PointOfSaleRepository.SalesTaxAmount.ToString("C");
                        break;
                    }
                }
            }
            UpdateTotals();
            UpdateListboxItems();
        }

        private void PointOfSaleMain_Load(object sender, EventArgs e) {
        }
    }
}
