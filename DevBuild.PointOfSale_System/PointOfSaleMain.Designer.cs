namespace DevBuild.PointOfSale_System {
    partial class PointOfSaleMain {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.quantityLabel = new System.Windows.Forms.Label();
            this.SoupQtyUp = new System.Windows.Forms.Button();
            this.SoupQtyDown = new System.Windows.Forms.Button();
            this.SoupQtyTextBox = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SubtotalTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TableclothQtyUp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableclothButton = new System.Windows.Forms.Button();
            this.soupButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLabel.Location = new System.Drawing.Point(267, 118);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(85, 40);
            this.quantityLabel.TabIndex = 1;
            this.quantityLabel.Text = "Quantity\r\n                   ";
            this.quantityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SoupQtyUp
            // 
            this.SoupQtyUp.Location = new System.Drawing.Point(271, 92);
            this.SoupQtyUp.Name = "SoupQtyUp";
            this.SoupQtyUp.Size = new System.Drawing.Size(75, 23);
            this.SoupQtyUp.TabIndex = 2;
            this.SoupQtyUp.Text = "More";
            this.SoupQtyUp.UseVisualStyleBackColor = true;
            this.SoupQtyUp.Click += new System.EventHandler(this.SoupQtyUp_Click);
            // 
            // SoupQtyDown
            // 
            this.SoupQtyDown.Location = new System.Drawing.Point(271, 141);
            this.SoupQtyDown.Name = "SoupQtyDown";
            this.SoupQtyDown.Size = new System.Drawing.Size(75, 23);
            this.SoupQtyDown.TabIndex = 3;
            this.SoupQtyDown.Text = "Less";
            this.SoupQtyDown.UseVisualStyleBackColor = true;
            this.SoupQtyDown.Click += new System.EventHandler(this.SoupQtyDown_Click);
            // 
            // SoupQtyTextBox
            // 
            this.SoupQtyTextBox.Location = new System.Drawing.Point(343, 118);
            this.SoupQtyTextBox.MaxLength = 4;
            this.SoupQtyTextBox.Name = "SoupQtyTextBox";
            this.SoupQtyTextBox.Size = new System.Drawing.Size(39, 20);
            this.SoupQtyTextBox.TabIndex = 4;
            this.SoupQtyTextBox.TextChanged += new System.EventHandler(this.SoupQtyTextBox_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "asdf",
            "as"});
            this.listBox1.Location = new System.Drawing.Point(510, 41);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(278, 303);
            this.listBox1.TabIndex = 5;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // SubtotalTextBox
            // 
            this.SubtotalTextBox.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.SubtotalTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.SubtotalTextBox.Location = new System.Drawing.Point(701, 351);
            this.SubtotalTextBox.MaxLength = 24;
            this.SubtotalTextBox.Name = "SubtotalTextBox";
            this.SubtotalTextBox.ReadOnly = true;
            this.SubtotalTextBox.Size = new System.Drawing.Size(87, 20);
            this.SubtotalTextBox.TabIndex = 6;
            this.SubtotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(343, 354);
            this.textBox1.MaxLength = 4;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(39, 20);
            this.textBox1.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(271, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Less";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // TableclothQtyUp
            // 
            this.TableclothQtyUp.Location = new System.Drawing.Point(271, 328);
            this.TableclothQtyUp.Name = "TableclothQtyUp";
            this.TableclothQtyUp.Size = new System.Drawing.Size(75, 23);
            this.TableclothQtyUp.TabIndex = 9;
            this.TableclothQtyUp.Tag = "Tablecloth";
            this.TableclothQtyUp.Text = "More";
            this.TableclothQtyUp.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(267, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 40);
            this.label1.TabIndex = 8;
            this.label1.Text = "Quantity\r\n                   ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableclothButton
            // 
            this.tableclothButton.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableclothButton.Image = global::DevBuild.PointOfSale_System.Properties.Resources.stock_tablecloth;
            this.tableclothButton.Location = new System.Drawing.Point(77, 266);
            this.tableclothButton.Name = "tableclothButton";
            this.tableclothButton.Size = new System.Drawing.Size(184, 188);
            this.tableclothButton.TabIndex = 7;
            this.tableclothButton.Tag = "Tablecloth";
            this.tableclothButton.Text = "Pretty big tablecloth";
            this.tableclothButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tableclothButton.UseCompatibleTextRendering = true;
            this.tableclothButton.UseVisualStyleBackColor = true;
            // 
            // soupButton
            // 
            this.soupButton.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soupButton.Image = global::DevBuild.PointOfSale_System.Properties.Resources.stock_soupcan;
            this.soupButton.Location = new System.Drawing.Point(77, 30);
            this.soupButton.Name = "soupButton";
            this.soupButton.Size = new System.Drawing.Size(184, 188);
            this.soupButton.TabIndex = 0;
            this.soupButton.Tag = "Soup";
            this.soupButton.Text = "Fancy-ass Soup";
            this.soupButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.soupButton.UseCompatibleTextRendering = true;
            this.soupButton.UseVisualStyleBackColor = true;
            // 
            // PointOfSaleMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TableclothQtyUp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableclothButton);
            this.Controls.Add(this.SubtotalTextBox);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.SoupQtyTextBox);
            this.Controls.Add(this.SoupQtyDown);
            this.Controls.Add(this.SoupQtyUp);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.soupButton);
            this.DoubleBuffered = true;
            this.Name = "PointOfSaleMain";
            this.Text = "DevBuild - Point of Sale (C) 2018";
            this.Load += new System.EventHandler(this.PointOfSaleMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button soupButton;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Button SoupQtyUp;
        private System.Windows.Forms.Button SoupQtyDown;
        private System.Windows.Forms.TextBox SoupQtyTextBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox SubtotalTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button TableclothQtyUp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button tableclothButton;
    }
}