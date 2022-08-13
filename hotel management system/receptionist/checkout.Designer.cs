namespace hotel_management_system.receptionist
{
    partial class checkout
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numday_txt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ldate = new System.Windows.Forms.DateTimePicker();
            this.bdate = new System.Windows.Forms.DateTimePicker();
            this.room_number = new System.Windows.Forms.TextBox();
            this.numperson = new System.Windows.Forms.TextBox();
            this.phone_txt = new System.Windows.Forms.TextBox();
            this.natid_txt = new System.Windows.Forms.TextBox();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.search_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.search_txt);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(806, 490);
            this.panel2.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(194, 433);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(374, 433);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "genrate bill";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(494, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(303, 320);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numday_txt);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.ldate);
            this.panel1.Controls.Add(this.bdate);
            this.panel1.Controls.Add(this.room_number);
            this.panel1.Controls.Add(this.numperson);
            this.panel1.Controls.Add(this.phone_txt);
            this.panel1.Controls.Add(this.natid_txt);
            this.panel1.Controls.Add(this.name_txt);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(9, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 320);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // numday_txt
            // 
            this.numday_txt.Location = new System.Drawing.Point(125, 288);
            this.numday_txt.Name = "numday_txt";
            this.numday_txt.ReadOnly = true;
            this.numday_txt.Size = new System.Drawing.Size(97, 20);
            this.numday_txt.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 291);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "no.days";
            // 
            // ldate
            // 
            this.ldate.Enabled = false;
            this.ldate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ldate.Location = new System.Drawing.Point(126, 250);
            this.ldate.Name = "ldate";
            this.ldate.Size = new System.Drawing.Size(97, 20);
            this.ldate.TabIndex = 15;
            // 
            // bdate
            // 
            this.bdate.Enabled = false;
            this.bdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.bdate.Location = new System.Drawing.Point(125, 215);
            this.bdate.Name = "bdate";
            this.bdate.Size = new System.Drawing.Size(97, 20);
            this.bdate.TabIndex = 14;
            // 
            // room_number
            // 
            this.room_number.Location = new System.Drawing.Point(125, 165);
            this.room_number.Name = "room_number";
            this.room_number.ReadOnly = true;
            this.room_number.Size = new System.Drawing.Size(97, 20);
            this.room_number.TabIndex = 13;
            // 
            // numperson
            // 
            this.numperson.Location = new System.Drawing.Point(125, 128);
            this.numperson.Name = "numperson";
            this.numperson.ReadOnly = true;
            this.numperson.Size = new System.Drawing.Size(97, 20);
            this.numperson.TabIndex = 12;
            // 
            // phone_txt
            // 
            this.phone_txt.Location = new System.Drawing.Point(125, 92);
            this.phone_txt.Name = "phone_txt";
            this.phone_txt.ReadOnly = true;
            this.phone_txt.Size = new System.Drawing.Size(151, 20);
            this.phone_txt.TabIndex = 11;
            // 
            // natid_txt
            // 
            this.natid_txt.Location = new System.Drawing.Point(125, 53);
            this.natid_txt.Name = "natid_txt";
            this.natid_txt.ReadOnly = true;
            this.natid_txt.Size = new System.Drawing.Size(261, 20);
            this.natid_txt.TabIndex = 10;
            // 
            // name_txt
            // 
            this.name_txt.Location = new System.Drawing.Point(125, 15);
            this.name_txt.Name = "name_txt";
            this.name_txt.ReadOnly = true;
            this.name_txt.Size = new System.Drawing.Size(261, 20);
            this.name_txt.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 256);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "leaving date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "booking date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "room number ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "name ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "national id ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "phone number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "no.person";
            // 
            // search_txt
            // 
            this.search_txt.Location = new System.Drawing.Point(89, 34);
            this.search_txt.Name = "search_txt";
            this.search_txt.Size = new System.Drawing.Size(432, 20);
            this.search_txt.TabIndex = 11;
            this.search_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.search_txt_KeyDown);
            this.search_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.search_txt_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "search ";
            // 
            // checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(830, 514);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.HelpButton = true;
            this.Name = "checkout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "checkout";
            this.Load += new System.EventHandler(this.checkout_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox numday_txt;
        public System.Windows.Forms.DateTimePicker ldate;
        public System.Windows.Forms.DateTimePicker bdate;
        public System.Windows.Forms.TextBox room_number;
        public System.Windows.Forms.TextBox numperson;
        public System.Windows.Forms.TextBox phone_txt;
        public System.Windows.Forms.TextBox natid_txt;
        public System.Windows.Forms.TextBox name_txt;
        public System.Windows.Forms.TextBox search_txt;
    }
}