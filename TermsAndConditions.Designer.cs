namespace MovieTicketApplication
{
    partial class TermsAndConditions
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblterms = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.White;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "         ",
            "         1) Tickets once purchased cannot be cancelled, exchanged or refunded.",
            "",
            "         2) Tickets purchased  are not eligible for discounts, schemes or promoti" +
                "ons of any kind.",
            "",
            "         3) Children below the age of 18 years cannot be admitted for movies cert" +
                "ified \'A\'.",
            "",
            "         4) Please carry proof of age for movies certified \'A\'.",
            "",
            "         5) Please purchase tickets for children above the age of 3 years.",
            "",
            "         6) Entry is allowed only for valid ticket holders.",
            "",
            "         7) To counter unforeseen delays, please collect your tickets half an hou" +
                "r before show time.",
            "",
            "         8) Outside food and beverages are not allowed inside the cinema premises" +
                ".",
            "",
            "         9) In case a ticket is lost or misplaced, a duplicate ticket cannot be i" +
                "ssued.",
            "",
            "         10) Rights of admission reserved.",
            " "});
            this.listBox1.Location = new System.Drawing.Point(304, 173);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(746, 440);
            this.listBox1.TabIndex = 3;
            // 
            // lblterms
            // 
            this.lblterms.AutoSize = true;
            this.lblterms.BackColor = System.Drawing.Color.Transparent;
            this.lblterms.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblterms.Location = new System.Drawing.Point(589, 119);
            this.lblterms.Name = "lblterms";
            this.lblterms.Size = new System.Drawing.Size(181, 23);
            this.lblterms.TabIndex = 2;
            this.lblterms.Text = "Terms And Conditions";
            // 
            // TermsAndConditions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MovieTicketApplication.Properties.Resources.backcolor;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblterms);
            this.Name = "TermsAndConditions";
            this.Text = "TermsAndConditions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblterms;
    }
}