namespace hotel_management_system.receptionist
{
    partial class check_in
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.natid_txt = new System.Windows.Forms.TextBox();
            this.phone_txt = new System.Windows.Forms.TextBox();
            this.bookingdate_txt = new System.Windows.Forms.DateTimePicker();
            this.leavingdate_txt = new System.Windows.Forms.DateTimePicker();
            this.nodays_txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.noofperson_txt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.email_txt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.roomid_txt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "national id ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "phone number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "booking date ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "leaving sate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "no.days";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(453, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(336, 396);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // name_txt
            // 
            this.name_txt.Location = new System.Drawing.Point(123, 49);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(245, 20);
            this.name_txt.TabIndex = 10;
            this.name_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.name_txt_KeyPress);
            // 
            // natid_txt
            // 
            this.natid_txt.Location = new System.Drawing.Point(123, 81);
            this.natid_txt.MaxLength = 14;
            this.natid_txt.Name = "natid_txt";
            this.natid_txt.Size = new System.Drawing.Size(245, 20);
            this.natid_txt.TabIndex = 11;
            this.natid_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.natid_txt_KeyPress);
            // 
            // phone_txt
            // 
            this.phone_txt.Location = new System.Drawing.Point(123, 126);
            this.phone_txt.MaxLength = 11;
            this.phone_txt.Name = "phone_txt";
            this.phone_txt.Size = new System.Drawing.Size(172, 20);
            this.phone_txt.TabIndex = 12;
            this.phone_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phone_txt_KeyPress);
            // 
            // bookingdate_txt
            // 
            this.bookingdate_txt.CustomFormat = "yyyy-MM-dd";
            this.bookingdate_txt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.bookingdate_txt.Location = new System.Drawing.Point(123, 195);
            this.bookingdate_txt.MinDate = new System.DateTime(2021, 8, 6, 0, 5, 30, 0);
            this.bookingdate_txt.Name = "bookingdate_txt";
            this.bookingdate_txt.Size = new System.Drawing.Size(99, 20);
            this.bookingdate_txt.TabIndex = 12;
            this.bookingdate_txt.Value = new System.DateTime(2021, 8, 6, 0, 5, 30, 0);
            // 
            // leavingdate_txt
            // 
            this.leavingdate_txt.CustomFormat = "yyyy-MM-dd";
            this.leavingdate_txt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.leavingdate_txt.Location = new System.Drawing.Point(123, 236);
            this.leavingdate_txt.MinDate = new System.DateTime(2021, 8, 6, 0, 0, 0, 0);
            this.leavingdate_txt.Name = "leavingdate_txt";
            this.leavingdate_txt.Size = new System.Drawing.Size(99, 20);
            this.leavingdate_txt.TabIndex = 14;
            this.leavingdate_txt.ValueChanged += new System.EventHandler(this.leavingdate_txt_ValueChanged);
            // 
            // nodays_txt
            // 
            this.nodays_txt.Location = new System.Drawing.Point(123, 279);
            this.nodays_txt.Name = "nodays_txt";
            this.nodays_txt.ReadOnly = true;
            this.nodays_txt.Size = new System.Drawing.Size(153, 20);
            this.nodays_txt.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 326);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "no.of.person";
            // 
            // noofperson_txt
            // 
            this.noofperson_txt.Location = new System.Drawing.Point(123, 326);
            this.noofperson_txt.MaxLength = 1;
            this.noofperson_txt.Name = "noofperson_txt";
            this.noofperson_txt.Size = new System.Drawing.Size(38, 20);
            this.noofperson_txt.TabIndex = 17;
            this.noofperson_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.noofperson_txt_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "E-mail";
            // 
            // email_txt
            // 
            this.email_txt.Location = new System.Drawing.Point(123, 158);
            this.email_txt.Name = "email_txt";
            this.email_txt.Size = new System.Drawing.Size(172, 20);
            this.email_txt.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(362, 466);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "booking";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(31, 475);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(42, 375);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "room number";
            // 
            // roomid_txt
            // 
            this.roomid_txt.Location = new System.Drawing.Point(123, 372);
            this.roomid_txt.Name = "roomid_txt";
            this.roomid_txt.ReadOnly = true;
            this.roomid_txt.Size = new System.Drawing.Size(153, 20);
            this.roomid_txt.TabIndex = 23;
            // 
            // check_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 534);
            this.Controls.Add(this.roomid_txt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.email_txt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.noofperson_txt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nodays_txt);
            this.Controls.Add(this.leavingdate_txt);
            this.Controls.Add(this.bookingdate_txt);
            this.Controls.Add(this.phone_txt);
            this.Controls.Add(this.natid_txt);
            this.Controls.Add(this.name_txt);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "check_in";
            this.Text = "check_in";
            this.Load += new System.EventHandler(this.check_in_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.TextBox natid_txt;
        private System.Windows.Forms.TextBox phone_txt;
        private System.Windows.Forms.DateTimePicker bookingdate_txt;
        private System.Windows.Forms.DateTimePicker leavingdate_txt;
        private System.Windows.Forms.TextBox nodays_txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox noofperson_txt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox email_txt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.TextBox roomid_txt;
        public System.Windows.Forms.Button button2;
    }
}