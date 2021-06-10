namespace MovieTicketApplication
{
    partial class SeatBooking
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
            this.lblRupees = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtNo_of_Ticket = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtShowTiming = new System.Windows.Forms.TextBox();
            this.txtMovie = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cbCinema = new System.Windows.Forms.ComboBox();
            this.cbClass = new System.Windows.Forms.ComboBox();
            this.cbCities = new System.Windows.Forms.ComboBox();
            this.lblNo_of_Ticket = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblShowTiming = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblMovie = new System.Windows.Forms.Label();
            this.lblCinema = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblRupees);
            this.panel1.Controls.Add(this.lblPrice);
            this.panel1.Controls.Add(this.txtAmount);
            this.panel1.Controls.Add(this.lblAmount);
            this.panel1.Controls.Add(this.txtNo_of_Ticket);
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Controls.Add(this.txtShowTiming);
            this.panel1.Controls.Add(this.txtMovie);
            this.panel1.Controls.Add(this.dtpDate);
            this.panel1.Controls.Add(this.cbCinema);
            this.panel1.Controls.Add(this.cbClass);
            this.panel1.Controls.Add(this.cbCities);
            this.panel1.Controls.Add(this.lblNo_of_Ticket);
            this.panel1.Controls.Add(this.lblClass);
            this.panel1.Controls.Add(this.lblShowTiming);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.lblMovie);
            this.panel1.Controls.Add(this.lblCinema);
            this.panel1.Controls.Add(this.lblCity);
            this.panel1.Location = new System.Drawing.Point(411, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(533, 474);
            this.panel1.TabIndex = 1;
            // 
            // lblRupees
            // 
            this.lblRupees.AutoSize = true;
            this.lblRupees.Location = new System.Drawing.Point(428, 363);
            this.lblRupees.Name = "lblRupees";
            this.lblRupees.Size = new System.Drawing.Size(23, 13);
            this.lblRupees.TabIndex = 18;
            this.lblRupees.Text = "Rs.";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(428, 274);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 9;
            this.lblPrice.Text = "Price";
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(233, 356);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(185, 27);
            this.txtAmount.TabIndex = 7;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(147, 359);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(71, 19);
            this.lblAmount.TabIndex = 17;
            this.lblAmount.Text = "Amount  :";
            // 
            // txtNo_of_Ticket
            // 
            this.txtNo_of_Ticket.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNo_of_Ticket.Location = new System.Drawing.Point(233, 311);
            this.txtNo_of_Ticket.Name = "txtNo_of_Ticket";
            this.txtNo_of_Ticket.Size = new System.Drawing.Size(185, 27);
            this.txtNo_of_Ticket.TabIndex = 6;
            this.txtNo_of_Ticket.Leave += new System.EventHandler(this.txtNo_of_Ticket_Leave);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Tomato;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubmit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(233, 412);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 28);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtShowTiming
            // 
            this.txtShowTiming.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShowTiming.Location = new System.Drawing.Point(233, 224);
            this.txtShowTiming.Name = "txtShowTiming";
            this.txtShowTiming.Size = new System.Drawing.Size(185, 27);
            this.txtShowTiming.TabIndex = 4;
            // 
            // txtMovie
            // 
            this.txtMovie.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMovie.Location = new System.Drawing.Point(233, 135);
            this.txtMovie.Name = "txtMovie";
            this.txtMovie.Size = new System.Drawing.Size(185, 27);
            this.txtMovie.TabIndex = 2;
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd/MM/yy";
            this.dtpDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(233, 179);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(185, 27);
            this.dtpDate.TabIndex = 3;
            // 
            // cbCinema
            // 
            this.cbCinema.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCinema.FormattingEnabled = true;
            this.cbCinema.Items.AddRange(new object[] {
            "Cinemax(Eternity Mall)",
            "Inox",
            "PVR(Empress Mall)"});
            this.cbCinema.Location = new System.Drawing.Point(233, 88);
            this.cbCinema.Name = "cbCinema";
            this.cbCinema.Size = new System.Drawing.Size(185, 27);
            this.cbCinema.TabIndex = 1;
            // 
            // cbClass
            // 
            this.cbClass.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbClass.FormattingEnabled = true;
            this.cbClass.Items.AddRange(new object[] {
            "Silver",
            "Gold",
            "Platinum"});
            this.cbClass.Location = new System.Drawing.Point(233, 267);
            this.cbClass.Name = "cbClass";
            this.cbClass.Size = new System.Drawing.Size(185, 27);
            this.cbClass.TabIndex = 5;
            this.cbClass.SelectedIndexChanged += new System.EventHandler(this.cbClass_SelectedIndexChanged);
            // 
            // cbCities
            // 
            this.cbCities.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCities.FormattingEnabled = true;
            this.cbCities.Items.AddRange(new object[] {
            "Nagpur",
            "Pune",
            "Mumbai",
            "Ahmedabad",
            "Aurangabad",
            "Hyderabad",
            "Banglore"});
            this.cbCities.Location = new System.Drawing.Point(233, 44);
            this.cbCities.Name = "cbCities";
            this.cbCities.Size = new System.Drawing.Size(185, 27);
            this.cbCities.TabIndex = 0;
            // 
            // lblNo_of_Ticket
            // 
            this.lblNo_of_Ticket.AutoSize = true;
            this.lblNo_of_Ticket.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNo_of_Ticket.Location = new System.Drawing.Point(120, 314);
            this.lblNo_of_Ticket.Name = "lblNo_of_Ticket";
            this.lblNo_of_Ticket.Size = new System.Drawing.Size(98, 19);
            this.lblNo_of_Ticket.TabIndex = 16;
            this.lblNo_of_Ticket.Text = "No of Ticket  :";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass.Location = new System.Drawing.Point(162, 270);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(56, 19);
            this.lblClass.TabIndex = 15;
            this.lblClass.Text = "Class  :";
            // 
            // lblShowTiming
            // 
            this.lblShowTiming.AutoSize = true;
            this.lblShowTiming.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowTiming.Location = new System.Drawing.Point(115, 227);
            this.lblShowTiming.Name = "lblShowTiming";
            this.lblShowTiming.Size = new System.Drawing.Size(103, 19);
            this.lblShowTiming.TabIndex = 14;
            this.lblShowTiming.Text = "Show Timing  :";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(166, 185);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(52, 19);
            this.lblDate.TabIndex = 13;
            this.lblDate.Text = "Date  :";
            // 
            // lblMovie
            // 
            this.lblMovie.AutoSize = true;
            this.lblMovie.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovie.Location = new System.Drawing.Point(157, 138);
            this.lblMovie.Name = "lblMovie";
            this.lblMovie.Size = new System.Drawing.Size(61, 19);
            this.lblMovie.TabIndex = 12;
            this.lblMovie.Text = "Movie  :";
            // 
            // lblCinema
            // 
            this.lblCinema.AutoSize = true;
            this.lblCinema.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCinema.Location = new System.Drawing.Point(148, 91);
            this.lblCinema.Name = "lblCinema";
            this.lblCinema.Size = new System.Drawing.Size(70, 19);
            this.lblCinema.TabIndex = 11;
            this.lblCinema.Text = "Cinema  :";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(172, 47);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(46, 19);
            this.lblCity.TabIndex = 10;
            this.lblCity.Text = "City  :";
            // 
            // SeatBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MovieTicketApplication.Properties.Resources.backcolor;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1354, 594);
            this.Controls.Add(this.panel1);
            this.Name = "SeatBooking";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SeatBooking_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblRupees;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtNo_of_Ticket;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtShowTiming;
        private System.Windows.Forms.TextBox txtMovie;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ComboBox cbCinema;
        private System.Windows.Forms.ComboBox cbClass;
        private System.Windows.Forms.ComboBox cbCities;
        private System.Windows.Forms.Label lblNo_of_Ticket;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblShowTiming;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblMovie;
        private System.Windows.Forms.Label lblCinema;
        private System.Windows.Forms.Label lblCity;
    }
}

