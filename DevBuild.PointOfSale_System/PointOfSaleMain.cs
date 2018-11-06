using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevBuild.PointOfSale_System {
    public partial class PointOfSaleMain : Form {
        public PointOfSaleMain() {
            InitializeComponent();
            SoupQtyTextBox.Text = "0";
            SubtotalTextBox.Text = PointOfSaleRepository.Subtotal.ToString("#,###.00");
        }

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

        private void QtyUp_Click(object sender, EventArgs e) {
            int i;
            int textBoxQty = 0;
            if (sender is Control) {
                Control controlRef = sender as Control;
                if (Inventory.Items[controlRef.Tag.ToString()].NumberInStock > 0) {
                    //SoupQtyTextBox.Text = (++textBoxQty).ToString();
                    Inventory.SellItems(controlRef.Tag.ToString());

                    for (i = 0; i < listBox1.Items.Count; i++) {
                        if (listBox1.Items[i] is Product && (listBox1.Items[i] as Product).Name == controlRef.Tag.ToString()) {
                            (listBox1.Items[i] as Product).NumberInStock++;
                            listBox1.BeginUpdate();
                            //listBox1.Invalidate(listBox1.GetItemRectangle(i));
                            listBox1.Items[i] = listBox1.Items[i];
                            listBox1.Update();
                            listBox1.EndUpdate();
                            SubtotalTextBox.Text = CheckoutCart.CalculateSubtotal().ToString("#,###.00");
                            return;
                        }
                    }

                    Product listProduct = (Product)Inventory.Items[controlRef.Tag.ToString()].Clone();
                    listProduct.NumberInStock = 1;
                    listBox1.Items.Add(listProduct);
                    SubtotalTextBox.Text = CheckoutCart.CalculateSubtotal().ToString("#,###.00");
                }
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
                    SoupQtyUp.Enabled = true;
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

                        listBox1.BeginUpdate();
                        listBox1.Update();
                        listBox1.EndUpdate();
                        SubtotalTextBox.Text = CheckoutCart.CalculateSubtotal().ToString("#,###.00");
                        return;
                    }
                    SubtotalTextBox.Text = CheckoutCart.CalculateSubtotal().ToString("#,###.00");
                }
            }
        }

        private void PointOfSaleMain_Load(object sender, EventArgs e) {
        }
    }
}
