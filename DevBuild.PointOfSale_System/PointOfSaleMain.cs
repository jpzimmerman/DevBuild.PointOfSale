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
            soupButton.Click += SoupQtyUp_Click;            //else soupQty.Text = "0";
            
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

        private void SoupQtyUp_Click(object sender, EventArgs e) {
            int i;
            if (int.TryParse(SoupQtyTextBox.Text.Trim(), out i) && Inventory.Items[soupButton.Tag.ToString()].NumberInStock > 0) {
                SoupQtyTextBox.Text = (++i).ToString();
                Inventory.SellItems(soupButton.Tag.ToString());

                foreach (object c in listBox1.Items) {
                    if (c is Product && (c as Product).Name == "Soup") {
                        (c as Product).NumberInStock++;
                        listBox1.BeginUpdate();
                        listBox1.Invalidate(listBox1.GetItemRectangle(2));
                        listBox1.Items[2] = listBox1.Items[2];
                        //listBox1.Refresh();
                        listBox1.Update();
                        listBox1.EndUpdate();
                        SubtotalTextBox.Text = CheckoutCart.CalculateSubtotal().ToString("#,###.00");
                        return;
                    }
                }

                Product listProduct = (Product)Inventory.Items["Soup"].Clone();
                listProduct.NumberInStock = 1;
                listBox1.Items.Add(listProduct);
                SubtotalTextBox.Text = CheckoutCart.CalculateSubtotal().ToString("#,###.00");
            }
            if (Inventory.Items[soupButton.Tag.ToString()].NumberInStock == 0) {
                SoupQtyUp.Enabled = false;
            }
        }

        private void SoupQtyDown_Click(object sender, EventArgs e) {
            int i;
            if (int.TryParse(SoupQtyTextBox.Text.Trim(), out i) && i > 0) {
                SoupQtyTextBox.Text = (--i).ToString();
                Inventory.ReturnItems(soupButton.Tag.ToString());
            }
            if (Inventory.Items[soupButton.Tag.ToString()].NumberInStock == 1) {
                SoupQtyUp.Enabled = true;
            }
            foreach (object c in listBox1.Items) {
                if (c is Product && (c as Product).Name == "Soup") {
                    (c as Product).NumberInStock--;
                    listBox1.Invalidate(listBox1.GetItemRectangle(2));
                    listBox1.Items[2] = listBox1.Items[2];
                    if ((c as Product).NumberInStock == 0) {
                        listBox1.Items.RemoveAt(2);
                    }
                    
                    listBox1.BeginUpdate();
                    

                    //listBox1.Refresh();
                    listBox1.Update();
                    listBox1.EndUpdate();
                    SubtotalTextBox.Text = CheckoutCart.CalculateSubtotal().ToString("#,###.00");
                    return;
                }
                SubtotalTextBox.Text = CheckoutCart.CalculateSubtotal().ToString("#,###.00");
            }
        }

        private void PointOfSaleMain_Load(object sender, EventArgs e) {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {

        }
    }
}
