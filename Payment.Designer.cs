namespace MovieTicketApplication
{
    partial class Payment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnTicket = new System.Windows.Forms.Button();
            this.lblcreditNo = new System.Windows.Forms.Label();
            this.cbCardTyp = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCardType = new System.Windows.Forms.Label();
            this.txtamt = new System.Windows.Forms.TextBox();
            this.lblExpDate = new System.Windows.Forms.Label();
            this.txtCvvNo = new System.Windows.Forms.TextBox();
            this.lblCvvNo = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblamt = new System.Windows.Forms.Label();
            this.txtCreditNo = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dtpDate);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnTicket);
            this.panel1.Controls.Add(this.lblcreditNo);
            this.panel1.Controls.Add(this.cbCardTyp);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.lblCardType);
            this.panel1.Controls.Add(this.txtamt);
            this.panel1.Controls.Add(this.lblExpDate);
            this.panel1.Controls.Add(this.txtCvvNo);
            this.panel1.Controls.Add(this.lblCvvNo);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.lblamt);
            this.panel1.Controls.Add(this.txtCreditNo);
            this.panel1.Location = new System.Drawing.Point(390, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(575, 571);
            this.panel1.TabIndex = 1;
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "MM/yy";
            this.dtpDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(318, 298);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(192, 27);
            this.dtpDate.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MovieTicketApplication.Properties.Resources.paypal_credit_cards;
            this.pictureBox1.Location = new System.Drawing.Point(67, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(376, 115);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnTicket
            // 
            this.btnTicket.BackColor = System.Drawing.Color.Tomato;
            this.btnTicket.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTicket.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTicket.Location = new System.Drawing.Point(231, 514);
            this.btnTicket.Name = "btnTicket";
            this.btnTicket.Size = new System.Drawing.Size(110, 28);
            this.btnTicket.TabIndex = 6;
            this.btnTicket.Text = "Book Ticket";
            this.btnTicket.UseVisualStyleBackColor = false;
            this.btnTicket.Click += new System.EventHandler(this.btnTicket_Click);
            // 
            // lblcreditNo
            // 
            this.lblcreditNo.AutoSize = true;
            this.lblcreditNo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcreditNo.Location = new System.Drawing.Point(65, 276);
            this.lblcreditNo.Name = "lblcreditNo";
            this.lblcreditNo.Size = new System.Drawing.Size(145, 19);
            this.lblcreditNo.TabIndex = 9;
            this.lblcreditNo.Text = "Credit card number  :";
            // 
            // cbCardTyp
            // 
            this.cbCardTyp.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCardTyp.FormattingEnabled = true;
            this.cbCardTyp.Items.AddRange(new object[] {
            "---select---",
            "American Express Card",
            "VISA Card",
            "Master Card",
            "Discover Card"});
            this.cbCardTyp.Location = new System.Drawing.Point(67, 217);
            this.cbCardTyp.Name = "cbCardTyp";
            this.cbCardTyp.Size = new System.Drawing.Size(192, 27);
            this.cbCardTyp.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(314, 195);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(154, 19);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Name on Credit card  :";
            // 
            // lblCardType
            // 
            this.lblCardType.AutoSize = true;
            this.lblCardType.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardType.Location = new System.Drawing.Point(65, 195);
            this.lblCardType.Name = "lblCardType";
            this.lblCardType.Size = new System.Drawing.Size(128, 19);
            this.lblCardType.TabIndex = 7;
            this.lblCardType.Text = "Credit Card Type  :";
            // 
            // txtamt
            // 
            this.txtamt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtamt.Location = new System.Drawing.Point(67, 456);
            this.txtamt.Name = "txtamt";
            this.txtamt.Size = new System.Drawing.Size(192, 27);
            this.txtamt.TabIndex = 5;
            this.txtamt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtamt_KeyPress);
            // 
            // lblExpDate
            // 
            this.lblExpDate.AutoSize = true;
            this.lblExpDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpDate.Location = new System.Drawing.Point(314, 276);
            this.lblExpDate.Name = "lblExpDate";
            this.lblExpDate.Size = new System.Drawing.Size(95, 19);
            this.lblExpDate.TabIndex = 10;
            this.lblExpDate.Text = "Expiry Date  :";
            // 
            // txtCvvNo
            // 
            this.txtCvvNo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCvvNo.Location = new System.Drawing.Point(67, 376);
            this.txtCvvNo.Name = "txtCvvNo";
            this.txtCvvNo.Size = new System.Drawing.Size(192, 27);
            this.txtCvvNo.TabIndex = 4;
            this.txtCvvNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCvvNo_KeyPress);
            // 
            // lblCvvNo
            // 
            this.lblCvvNo.AutoSize = true;
            this.lblCvvNo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCvvNo.Location = new System.Drawing.Point(64, 354);
            this.lblCvvNo.Name = "lblCvvNo";
            this.lblCvvNo.Size = new System.Drawing.Size(103, 19);
            this.lblCvvNo.TabIndex = 11;
            this.lblCvvNo.Text = "CVV Number  :";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(318, 217);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(192, 27);
            this.txtName.TabIndex = 1;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // lblamt
            // 
            this.lblamt.AutoSize = true;
            this.lblamt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblamt.Location = new System.Drawing.Point(64, 434);
            this.lblamt.Name = "lblamt";
            this.lblamt.Size = new System.Drawing.Size(103, 19);
            this.lblamt.TabIndex = 12;
            this.lblamt.Text = "Amount Paid  :";
            // 
            // txtCreditNo
            // 
            this.txtCreditNo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreditNo.Location = new System.Drawing.Point(68, 298);
            this.txtCreditNo.Name = "txtCreditNo";
            this.txtCreditNo.Size = new System.Drawing.Size(192, 27);
            this.txtCreditNo.TabIndex = 2;
            this.txtCreditNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCreditNo_KeyPress);
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MovieTicketApplication.Properties.Resources.backcolor;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.panel1);
            this.Name = "Payment";
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Payment_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnTicket;
        private System.Windows.Forms.Label lblcreditNo;
        private System.Windows.Forms.ComboBox cbCardTyp;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCardType;
        private System.Windows.Forms.TextBox txtamt;
        private System.Windows.Forms.Label lblExpDate;
        private System.Windows.Forms.TextBox txtCvvNo;
        private System.Windows.Forms.Label lblCvvNo;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblamt;
        private System.Windows.Forms.TextBox txtCreditNo;
    }
}