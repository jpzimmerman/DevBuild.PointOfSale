namespace DevBuild.PointOfSale_System {
    partial class PaymentForm {
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
            this.GroupboxCash = new System.Windows.Forms.GroupBox();
            this.CurrencyButton100 = new System.Windows.Forms.Button();
            this.CurrencyButton50 = new System.Windows.Forms.Button();
            this.CurrencyButton20 = new System.Windows.Forms.Button();
            this.CashBalanceField = new System.Windows.Forms.Label();
            this.CurrencyButton10 = new System.Windows.Forms.Button();
            this.CurrencyButton5 = new System.Windows.Forms.Button();
            this.CurrencyButton1 = new System.Windows.Forms.Button();
            this.CashBalanceLabel = new System.Windows.Forms.Label();
            this.CashChangeField = new System.Windows.Forms.Label();
            this.CashChangeLabel = new System.Windows.Forms.Label();
            this.CashAmountField = new System.Windows.Forms.TextBox();
            this.GrandTotalValue = new System.Windows.Forms.Label();
            this.GrandTotalField = new System.Windows.Forms.Label();
            this.AmountTenderedLabel = new System.Windows.Forms.Label();
            this.GroupboxCredit = new System.Windows.Forms.GroupBox();
            this.CreditCardNumberField = new System.Windows.Forms.TextBox();
            this.CreditCardCVVField = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.CreditCardCVVLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CreditCardNumberLabel = new System.Windows.Forms.Label();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.GroupboxCheck = new System.Windows.Forms.GroupBox();
            this.CheckingAccountNumberField = new System.Windows.Forms.TextBox();
            this.CheckingRoutingNumberField = new System.Windows.Forms.TextBox();
            this.CheckAccountNumberLabel = new System.Windows.Forms.Label();
            this.CheckRoutingNumberLabel = new System.Windows.Forms.Label();
            this.GoBackButton = new System.Windows.Forms.Button();
            this.CashOptionButton = new System.Windows.Forms.Button();
            this.CreditCardOptionButton = new System.Windows.Forms.Button();
            this.CheckOptionButton = new System.Windows.Forms.Button();
            this.GiftCardOptionButton = new System.Windows.Forms.Button();
            this.GroupboxGiftCard = new System.Windows.Forms.GroupBox();
            this.GiftCardSwipeButton = new System.Windows.Forms.Button();
            this.GiftcardLabel = new System.Windows.Forms.Label();
            this.GroupboxCash.SuspendLayout();
            this.GroupboxCredit.SuspendLayout();
            this.GroupboxCheck.SuspendLayout();
            this.GroupboxGiftCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupboxCash
            // 
            this.GroupboxCash.Controls.Add(this.CurrencyButton100);
            this.GroupboxCash.Controls.Add(this.CurrencyButton50);
            this.GroupboxCash.Controls.Add(this.CurrencyButton20);
            this.GroupboxCash.Controls.Add(this.CashBalanceField);
            this.GroupboxCash.Controls.Add(this.CurrencyButton10);
            this.GroupboxCash.Controls.Add(this.CurrencyButton5);
            this.GroupboxCash.Controls.Add(this.CurrencyButton1);
            this.GroupboxCash.Controls.Add(this.CashBalanceLabel);
            this.GroupboxCash.Controls.Add(this.CashChangeField);
            this.GroupboxCash.Controls.Add(this.CashChangeLabel);
            this.GroupboxCash.Controls.Add(this.CashAmountField);
            this.GroupboxCash.Controls.Add(this.GrandTotalValue);
            this.GroupboxCash.Controls.Add(this.GrandTotalField);
            this.GroupboxCash.Controls.Add(this.AmountTenderedLabel);
            this.GroupboxCash.Location = new System.Drawing.Point(33, 129);
            this.GroupboxCash.Name = "GroupboxCash";
            this.GroupboxCash.Size = new System.Drawing.Size(239, 346);
            this.GroupboxCash.TabIndex = 0;
            this.GroupboxCash.TabStop = false;
            this.GroupboxCash.Tag = "Cash";
            this.GroupboxCash.Text = "Cash";
            // 
            // CurrencyButton100
            // 
            this.CurrencyButton100.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.CurrencyButton100.Image = global::DevBuild.PointOfSale_System.Properties.Resources.no_I_cant_break_your_benjamin2;
            this.CurrencyButton100.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CurrencyButton100.Location = new System.Drawing.Point(161, 142);
            this.CurrencyButton100.Name = "CurrencyButton100";
            this.CurrencyButton100.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.CurrencyButton100.Size = new System.Drawing.Size(71, 74);
            this.CurrencyButton100.TabIndex = 13;
            this.CurrencyButton100.Tag = "100.00";
            this.CurrencyButton100.Text = "$100";
            this.CurrencyButton100.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CurrencyButton100.UseVisualStyleBackColor = true;
            this.CurrencyButton100.Click += new System.EventHandler(this.CurrencyButton_Click);
            // 
            // CurrencyButton50
            // 
            this.CurrencyButton50.Location = new System.Drawing.Point(87, 142);
            this.CurrencyButton50.Name = "CurrencyButton50";
            this.CurrencyButton50.Size = new System.Drawing.Size(71, 35);
            this.CurrencyButton50.TabIndex = 12;
            this.CurrencyButton50.Tag = "50.00";
            this.CurrencyButton50.Text = "$50";
            this.CurrencyButton50.UseVisualStyleBackColor = true;
            this.CurrencyButton50.Click += new System.EventHandler(this.CurrencyButton_Click);
            // 
            // CurrencyButton20
            // 
            this.CurrencyButton20.Location = new System.Drawing.Point(14, 142);
            this.CurrencyButton20.Name = "CurrencyButton20";
            this.CurrencyButton20.Size = new System.Drawing.Size(71, 35);
            this.CurrencyButton20.TabIndex = 11;
            this.CurrencyButton20.Tag = "20.00";
            this.CurrencyButton20.Text = "$20";
            this.CurrencyButton20.UseVisualStyleBackColor = true;
            this.CurrencyButton20.Click += new System.EventHandler(this.CurrencyButton_Click);
            // 
            // CashBalanceField
            // 
            this.CashBalanceField.AutoSize = true;
            this.CashBalanceField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashBalanceField.Location = new System.Drawing.Point(170, 245);
            this.CashBalanceField.Name = "CashBalanceField";
            this.CashBalanceField.Size = new System.Drawing.Size(49, 20);
            this.CashBalanceField.TabIndex = 10;
            this.CashBalanceField.Text = "$0.00";
            this.CashBalanceField.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CurrencyButton10
            // 
            this.CurrencyButton10.Location = new System.Drawing.Point(162, 101);
            this.CurrencyButton10.Name = "CurrencyButton10";
            this.CurrencyButton10.Size = new System.Drawing.Size(71, 35);
            this.CurrencyButton10.TabIndex = 9;
            this.CurrencyButton10.Tag = "10.00";
            this.CurrencyButton10.Text = "$10";
            this.CurrencyButton10.UseVisualStyleBackColor = true;
            this.CurrencyButton10.Click += new System.EventHandler(this.CurrencyButton_Click);
            // 
            // CurrencyButton5
            // 
            this.CurrencyButton5.Location = new System.Drawing.Point(87, 101);
            this.CurrencyButton5.Name = "CurrencyButton5";
            this.CurrencyButton5.Size = new System.Drawing.Size(71, 35);
            this.CurrencyButton5.TabIndex = 8;
            this.CurrencyButton5.Tag = "5.00";
            this.CurrencyButton5.Text = "$5";
            this.CurrencyButton5.UseVisualStyleBackColor = true;
            this.CurrencyButton5.Click += new System.EventHandler(this.CurrencyButton_Click);
            // 
            // CurrencyButton1
            // 
            this.CurrencyButton1.Location = new System.Drawing.Point(14, 101);
            this.CurrencyButton1.Name = "CurrencyButton1";
            this.CurrencyButton1.Size = new System.Drawing.Size(71, 35);
            this.CurrencyButton1.TabIndex = 7;
            this.CurrencyButton1.Tag = "1.00";
            this.CurrencyButton1.Text = "$1";
            this.CurrencyButton1.UseVisualStyleBackColor = true;
            this.CurrencyButton1.Click += new System.EventHandler(this.CurrencyButton_Click);
            // 
            // CashBalanceLabel
            // 
            this.CashBalanceLabel.AutoSize = true;
            this.CashBalanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashBalanceLabel.Location = new System.Drawing.Point(24, 245);
            this.CashBalanceLabel.Name = "CashBalanceLabel";
            this.CashBalanceLabel.Size = new System.Drawing.Size(67, 20);
            this.CashBalanceLabel.TabIndex = 6;
            this.CashBalanceLabel.Text = "Balance";
            // 
            // CashChangeField
            // 
            this.CashChangeField.AutoSize = true;
            this.CashChangeField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashChangeField.Location = new System.Drawing.Point(166, 284);
            this.CashChangeField.Name = "CashChangeField";
            this.CashChangeField.Size = new System.Drawing.Size(49, 20);
            this.CashChangeField.TabIndex = 5;
            this.CashChangeField.Text = "$0.00";
            this.CashChangeField.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CashChangeField.Click += new System.EventHandler(this.CashChangeField_Click);
            // 
            // CashChangeLabel
            // 
            this.CashChangeLabel.AutoSize = true;
            this.CashChangeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashChangeLabel.Location = new System.Drawing.Point(20, 284);
            this.CashChangeLabel.Name = "CashChangeLabel";
            this.CashChangeLabel.Size = new System.Drawing.Size(65, 20);
            this.CashChangeLabel.TabIndex = 4;
            this.CashChangeLabel.Text = "Change";
            // 
            // CashAmountField
            // 
            this.CashAmountField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashAmountField.Location = new System.Drawing.Point(139, 73);
            this.CashAmountField.Name = "CashAmountField";
            this.CashAmountField.Size = new System.Drawing.Size(82, 26);
            this.CashAmountField.TabIndex = 3;
            this.CashAmountField.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CashAmountField.TextChanged += new System.EventHandler(this.CashAmountField_TextChanged);
            // 
            // GrandTotalValue
            // 
            this.GrandTotalValue.AutoSize = true;
            this.GrandTotalValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrandTotalValue.Location = new System.Drawing.Point(170, 48);
            this.GrandTotalValue.Name = "GrandTotalValue";
            this.GrandTotalValue.Size = new System.Drawing.Size(49, 20);
            this.GrandTotalValue.TabIndex = 2;
            this.GrandTotalValue.Text = "$0.00";
            // 
            // GrandTotalField
            // 
            this.GrandTotalField.AutoSize = true;
            this.GrandTotalField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrandTotalField.Location = new System.Drawing.Point(20, 48);
            this.GrandTotalField.Name = "GrandTotalField";
            this.GrandTotalField.Size = new System.Drawing.Size(52, 20);
            this.GrandTotalField.TabIndex = 1;
            this.GrandTotalField.Text = "Total: ";
            // 
            // AmountTenderedLabel
            // 
            this.AmountTenderedLabel.AutoSize = true;
            this.AmountTenderedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountTenderedLabel.Location = new System.Drawing.Point(20, 74);
            this.AmountTenderedLabel.Name = "AmountTenderedLabel";
            this.AmountTenderedLabel.Size = new System.Drawing.Size(113, 20);
            this.AmountTenderedLabel.TabIndex = 0;
            this.AmountTenderedLabel.Text = "Cash entered: ";
            // 
            // GroupboxCredit
            // 
            this.GroupboxCredit.Controls.Add(this.CreditCardNumberField);
            this.GroupboxCredit.Controls.Add(this.CreditCardCVVField);
            this.GroupboxCredit.Controls.Add(this.dateTimePicker1);
            this.GroupboxCredit.Controls.Add(this.CreditCardCVVLabel);
            this.GroupboxCredit.Controls.Add(this.label3);
            this.GroupboxCredit.Controls.Add(this.CreditCardNumberLabel);
            this.GroupboxCredit.Location = new System.Drawing.Point(290, 129);
            this.GroupboxCredit.Name = "GroupboxCredit";
            this.GroupboxCredit.Size = new System.Drawing.Size(253, 198);
            this.GroupboxCredit.TabIndex = 1;
            this.GroupboxCredit.TabStop = false;
            this.GroupboxCredit.Tag = "CreditCard";
            this.GroupboxCredit.Text = "Credit Card";
            this.GroupboxCredit.Enter += new System.EventHandler(this.GroupboxCredit_Enter);
            // 
            // CreditCardNumberField
            // 
            this.CreditCardNumberField.Location = new System.Drawing.Point(110, 32);
            this.CreditCardNumberField.MaxLength = 16;
            this.CreditCardNumberField.Name = "CreditCardNumberField";
            this.CreditCardNumberField.PasswordChar = '*';
            this.CreditCardNumberField.Size = new System.Drawing.Size(121, 20);
            this.CreditCardNumberField.TabIndex = 6;
            this.CreditCardNumberField.TextChanged += new System.EventHandler(this.CreditCardNumberField_TextChanged);
            // 
            // CreditCardCVVField
            // 
            this.CreditCardCVVField.Location = new System.Drawing.Point(135, 85);
            this.CreditCardCVVField.MaxLength = 3;
            this.CreditCardCVVField.Name = "CreditCardCVVField";
            this.CreditCardCVVField.Size = new System.Drawing.Size(96, 20);
            this.CreditCardCVVField.TabIndex = 5;
            this.CreditCardCVVField.TextChanged += new System.EventHandler(this.CreditCardCVVField_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM/yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(135, 58);
            this.dateTimePicker1.MinDate = new System.DateTime(2018, 11, 8, 11, 56, 5, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(96, 22);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.Value = new System.DateTime(2018, 11, 8, 11, 56, 5, 0);
            // 
            // CreditCardCVVLabel
            // 
            this.CreditCardCVVLabel.AutoSize = true;
            this.CreditCardCVVLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreditCardCVVLabel.Location = new System.Drawing.Point(6, 85);
            this.CreditCardCVVLabel.Name = "CreditCardCVVLabel";
            this.CreditCardCVVLabel.Size = new System.Drawing.Size(112, 20);
            this.CreditCardCVVLabel.TabIndex = 3;
            this.CreditCardCVVLabel.Text = "Security Code:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Expiration Date:";
            // 
            // CreditCardNumberLabel
            // 
            this.CreditCardNumberLabel.AutoSize = true;
            this.CreditCardNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreditCardNumberLabel.Location = new System.Drawing.Point(6, 32);
            this.CreditCardNumberLabel.Name = "CreditCardNumberLabel";
            this.CreditCardNumberLabel.Size = new System.Drawing.Size(111, 20);
            this.CreditCardNumberLabel.TabIndex = 1;
            this.CreditCardNumberLabel.Text = "Card Number: ";
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmButton.Location = new System.Drawing.Point(596, 524);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(192, 64);
            this.ConfirmButton.TabIndex = 3;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.CreditCardConfirmButton_Click);
            // 
            // GroupboxCheck
            // 
            this.GroupboxCheck.Controls.Add(this.CheckingAccountNumberField);
            this.GroupboxCheck.Controls.Add(this.CheckingRoutingNumberField);
            this.GroupboxCheck.Controls.Add(this.CheckAccountNumberLabel);
            this.GroupboxCheck.Controls.Add(this.CheckRoutingNumberLabel);
            this.GroupboxCheck.Location = new System.Drawing.Point(549, 129);
            this.GroupboxCheck.Name = "GroupboxCheck";
            this.GroupboxCheck.Size = new System.Drawing.Size(239, 346);
            this.GroupboxCheck.TabIndex = 2;
            this.GroupboxCheck.TabStop = false;
            this.GroupboxCheck.Tag = "Check";
            this.GroupboxCheck.Text = "Check";
            // 
            // CheckingAccountNumberField
            // 
            this.CheckingAccountNumberField.Location = new System.Drawing.Point(10, 128);
            this.CheckingAccountNumberField.Name = "CheckingAccountNumberField";
            this.CheckingAccountNumberField.Size = new System.Drawing.Size(87, 20);
            this.CheckingAccountNumberField.TabIndex = 10;
            // 
            // CheckingRoutingNumberField
            // 
            this.CheckingRoutingNumberField.Location = new System.Drawing.Point(10, 60);
            this.CheckingRoutingNumberField.Name = "CheckingRoutingNumberField";
            this.CheckingRoutingNumberField.Size = new System.Drawing.Size(87, 20);
            this.CheckingRoutingNumberField.TabIndex = 9;
            // 
            // CheckAccountNumberLabel
            // 
            this.CheckAccountNumberLabel.AutoSize = true;
            this.CheckAccountNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckAccountNumberLabel.Location = new System.Drawing.Point(6, 101);
            this.CheckAccountNumberLabel.Name = "CheckAccountNumberLabel";
            this.CheckAccountNumberLabel.Size = new System.Drawing.Size(136, 20);
            this.CheckAccountNumberLabel.TabIndex = 8;
            this.CheckAccountNumberLabel.Text = "Account Number: ";
            // 
            // CheckRoutingNumberLabel
            // 
            this.CheckRoutingNumberLabel.AutoSize = true;
            this.CheckRoutingNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckRoutingNumberLabel.Location = new System.Drawing.Point(6, 32);
            this.CheckRoutingNumberLabel.Name = "CheckRoutingNumberLabel";
            this.CheckRoutingNumberLabel.Size = new System.Drawing.Size(133, 20);
            this.CheckRoutingNumberLabel.TabIndex = 7;
            this.CheckRoutingNumberLabel.Text = "Routing Number: ";
            // 
            // GoBackButton
            // 
            this.GoBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoBackButton.Location = new System.Drawing.Point(33, 524);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(158, 64);
            this.GoBackButton.TabIndex = 3;
            this.GoBackButton.Text = "Go back";
            this.GoBackButton.UseVisualStyleBackColor = true;
            this.GoBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            // 
            // CashOptionButton
            // 
            this.CashOptionButton.Location = new System.Drawing.Point(33, 38);
            this.CashOptionButton.Name = "CashOptionButton";
            this.CashOptionButton.Size = new System.Drawing.Size(239, 85);
            this.CashOptionButton.TabIndex = 4;
            this.CashOptionButton.Tag = "Cash";
            this.CashOptionButton.Text = "Cash";
            this.CashOptionButton.UseVisualStyleBackColor = true;
            this.CashOptionButton.Click += new System.EventHandler(this.SelectPaymentMethodGroupbox);
            // 
            // CreditCardOptionButton
            // 
            this.CreditCardOptionButton.Location = new System.Drawing.Point(290, 38);
            this.CreditCardOptionButton.Name = "CreditCardOptionButton";
            this.CreditCardOptionButton.Size = new System.Drawing.Size(118, 85);
            this.CreditCardOptionButton.TabIndex = 5;
            this.CreditCardOptionButton.Tag = "CreditCard";
            this.CreditCardOptionButton.Text = "Credit Card";
            this.CreditCardOptionButton.UseVisualStyleBackColor = true;
            this.CreditCardOptionButton.Click += new System.EventHandler(this.SelectPaymentMethodGroupbox);
            // 
            // CheckOptionButton
            // 
            this.CheckOptionButton.Location = new System.Drawing.Point(549, 38);
            this.CheckOptionButton.Name = "CheckOptionButton";
            this.CheckOptionButton.Size = new System.Drawing.Size(239, 85);
            this.CheckOptionButton.TabIndex = 6;
            this.CheckOptionButton.Tag = "Check";
            this.CheckOptionButton.Text = "Check";
            this.CheckOptionButton.UseVisualStyleBackColor = true;
            this.CheckOptionButton.Click += new System.EventHandler(this.SelectPaymentMethodGroupbox);
            // 
            // GiftCardOptionButton
            // 
            this.GiftCardOptionButton.Location = new System.Drawing.Point(414, 38);
            this.GiftCardOptionButton.Name = "GiftCardOptionButton";
            this.GiftCardOptionButton.Size = new System.Drawing.Size(118, 85);
            this.GiftCardOptionButton.TabIndex = 7;
            this.GiftCardOptionButton.Tag = "GiftCard";
            this.GiftCardOptionButton.Text = "Gift Card";
            this.GiftCardOptionButton.UseVisualStyleBackColor = true;
            this.GiftCardOptionButton.Click += new System.EventHandler(this.SelectPaymentMethodGroupbox);
            // 
            // GroupboxGiftCard
            // 
            this.GroupboxGiftCard.Controls.Add(this.GiftCardSwipeButton);
            this.GroupboxGiftCard.Controls.Add(this.GiftcardLabel);
            this.GroupboxGiftCard.Location = new System.Drawing.Point(293, 333);
            this.GroupboxGiftCard.Name = "GroupboxGiftCard";
            this.GroupboxGiftCard.Size = new System.Drawing.Size(239, 142);
            this.GroupboxGiftCard.TabIndex = 4;
            this.GroupboxGiftCard.TabStop = false;
            this.GroupboxGiftCard.Tag = "GiftCard";
            this.GroupboxGiftCard.Text = "Gift Card";
            // 
            // GiftCardSwipeButton
            // 
            this.GiftCardSwipeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GiftCardSwipeButton.Location = new System.Drawing.Point(40, 58);
            this.GiftCardSwipeButton.Name = "GiftCardSwipeButton";
            this.GiftCardSwipeButton.Size = new System.Drawing.Size(174, 64);
            this.GiftCardSwipeButton.TabIndex = 2;
            this.GiftCardSwipeButton.Text = "Swipe";
            this.GiftCardSwipeButton.UseVisualStyleBackColor = true;
            // 
            // GiftcardLabel
            // 
            this.GiftcardLabel.AutoSize = true;
            this.GiftcardLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GiftcardLabel.Location = new System.Drawing.Point(6, 30);
            this.GiftcardLabel.Name = "GiftcardLabel";
            this.GiftcardLabel.Size = new System.Drawing.Size(227, 16);
            this.GiftcardLabel.TabIndex = 1;
            this.GiftcardLabel.Text = "idk just swipe I\'m sure there\'s enough";
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.GroupboxGiftCard);
            this.Controls.Add(this.GiftCardOptionButton);
            this.Controls.Add(this.CheckOptionButton);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.CreditCardOptionButton);
            this.Controls.Add(this.CashOptionButton);
            this.Controls.Add(this.GoBackButton);
            this.Controls.Add(this.GroupboxCheck);
            this.Controls.Add(this.GroupboxCredit);
            this.Controls.Add(this.GroupboxCash);
            this.Name = "PaymentForm";
            this.Text = "Select Form of Payment";
            this.GroupboxCash.ResumeLayout(false);
            this.GroupboxCash.PerformLayout();
            this.GroupboxCredit.ResumeLayout(false);
            this.GroupboxCredit.PerformLayout();
            this.GroupboxCheck.ResumeLayout(false);
            this.GroupboxCheck.PerformLayout();
            this.GroupboxGiftCard.ResumeLayout(false);
            this.GroupboxGiftCard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupboxCash;
        private System.Windows.Forms.GroupBox GroupboxCredit;
        private System.Windows.Forms.GroupBox GroupboxCheck;
        private System.Windows.Forms.Label GrandTotalValue;
        private System.Windows.Forms.Label GrandTotalField;
        private System.Windows.Forms.Label AmountTenderedLabel;
        private System.Windows.Forms.Label CreditCardCVVLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label CreditCardNumberLabel;
        private System.Windows.Forms.TextBox CashAmountField;
        private System.Windows.Forms.Button GoBackButton;
        private System.Windows.Forms.Button CashOptionButton;
        private System.Windows.Forms.Button CreditCardOptionButton;
        private System.Windows.Forms.Button CheckOptionButton;
        private System.Windows.Forms.Label CashChangeField;
        private System.Windows.Forms.Label CashChangeLabel;
        private System.Windows.Forms.Label CashBalanceLabel;
        private System.Windows.Forms.Button GiftCardOptionButton;
        private System.Windows.Forms.GroupBox GroupboxGiftCard;
        private System.Windows.Forms.Label GiftcardLabel;
        private System.Windows.Forms.Button GiftCardSwipeButton;
        private System.Windows.Forms.Button CurrencyButton10;
        private System.Windows.Forms.Button CurrencyButton5;
        private System.Windows.Forms.Button CurrencyButton1;
        private System.Windows.Forms.Label CashBalanceField;
        private System.Windows.Forms.Button CurrencyButton100;
        private System.Windows.Forms.Button CurrencyButton50;
        private System.Windows.Forms.Button CurrencyButton20;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox CreditCardCVVField;
        private System.Windows.Forms.TextBox CreditCardNumberField;
        private System.Windows.Forms.Label CheckAccountNumberLabel;
        private System.Windows.Forms.Label CheckRoutingNumberLabel;
        private System.Windows.Forms.TextBox CheckingAccountNumberField;
        private System.Windows.Forms.TextBox CheckingRoutingNumberField;
    }
}