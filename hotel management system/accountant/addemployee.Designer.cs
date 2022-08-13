namespace hotel_management_system.accountant
{
    partial class addemployee
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
            this.gender_txt = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.employeeType_txt = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.backbtn = new System.Windows.Forms.Button();
            this.savebtn = new System.Windows.Forms.Button();
            this.browesbtn = new System.Windows.Forms.Button();
            this.personalphoto_txt = new System.Windows.Forms.PictureBox();
            this.address_txt = new System.Windows.Forms.TextBox();
            this.salary_txt = new System.Windows.Forms.TextBox();
            this.birthdate_txt = new System.Windows.Forms.DateTimePicker();
            this.empdate_txt = new System.Windows.Forms.DateTimePicker();
            this.emial_txt = new System.Windows.Forms.TextBox();
            this.phone_txt = new System.Windows.Forms.TextBox();
            this.natid_txt = new System.Windows.Forms.TextBox();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personalphoto_txt)).BeginInit();
            this.SuspendLayout();
            // 
            // gender_txt
            // 
            this.gender_txt.AllowDrop = true;
            this.gender_txt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gender_txt.Items.AddRange(new object[] {
            "male",
            "female"});
            this.gender_txt.Location = new System.Drawing.Point(140, 300);
            this.gender_txt.Name = "gender_txt";
            this.gender_txt.Size = new System.Drawing.Size(105, 21);
            this.gender_txt.TabIndex = 31;
            this.gender_txt.Tag = "";
            this.gender_txt.SelectedIndexChanged += new System.EventHandler(this.genter_txt_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.employeeType_txt);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.gender_txt);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.backbtn);
            this.panel1.Controls.Add(this.savebtn);
            this.panel1.Controls.Add(this.browesbtn);
            this.panel1.Controls.Add(this.personalphoto_txt);
            this.panel1.Controls.Add(this.address_txt);
            this.panel1.Controls.Add(this.salary_txt);
            this.panel1.Controls.Add(this.birthdate_txt);
            this.panel1.Controls.Add(this.empdate_txt);
            this.panel1.Controls.Add(this.emial_txt);
            this.panel1.Controls.Add(this.phone_txt);
            this.panel1.Controls.Add(this.natid_txt);
            this.panel1.Controls.Add(this.name_txt);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 483);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // employeeType_txt
            // 
            this.employeeType_txt.AllowDrop = true;
            this.employeeType_txt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.employeeType_txt.Items.AddRange(new object[] {
            "receptionist",
            "chef ",
            "room service ",
            "house keeping ",
            "accountant ",
            "manage"});
            this.employeeType_txt.Location = new System.Drawing.Point(140, 393);
            this.employeeType_txt.Name = "employeeType_txt";
            this.employeeType_txt.Size = new System.Drawing.Size(105, 21);
            this.employeeType_txt.TabIndex = 33;
            this.employeeType_txt.Tag = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(66, 396);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "type";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(66, 303);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "gender";
            // 
            // backbtn
            // 
            this.backbtn.Location = new System.Drawing.Point(45, 433);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(75, 23);
            this.backbtn.TabIndex = 29;
            this.backbtn.Text = "back";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // savebtn
            // 
            this.savebtn.Location = new System.Drawing.Point(349, 433);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(75, 23);
            this.savebtn.TabIndex = 28;
            this.savebtn.Text = "save";
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // browesbtn
            // 
            this.browesbtn.Location = new System.Drawing.Point(652, 162);
            this.browesbtn.Name = "browesbtn";
            this.browesbtn.Size = new System.Drawing.Size(75, 23);
            this.browesbtn.TabIndex = 27;
            this.browesbtn.Text = "Browes";
            this.browesbtn.UseVisualStyleBackColor = true;
            this.browesbtn.Click += new System.EventHandler(this.browesbtn_Click);
            // 
            // personalphoto_txt
            // 
            this.personalphoto_txt.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.personalphoto_txt.Location = new System.Drawing.Point(596, 19);
            this.personalphoto_txt.Name = "personalphoto_txt";
            this.personalphoto_txt.Size = new System.Drawing.Size(179, 137);
            this.personalphoto_txt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.personalphoto_txt.TabIndex = 26;
            this.personalphoto_txt.TabStop = false;
            // 
            // address_txt
            // 
            this.address_txt.Location = new System.Drawing.Point(596, 226);
            this.address_txt.Multiline = true;
            this.address_txt.Name = "address_txt";
            this.address_txt.Size = new System.Drawing.Size(179, 129);
            this.address_txt.TabIndex = 25;
            // 
            // salary_txt
            // 
            this.salary_txt.Location = new System.Drawing.Point(140, 349);
            this.salary_txt.Name = "salary_txt";
            this.salary_txt.Size = new System.Drawing.Size(131, 20);
            this.salary_txt.TabIndex = 24;
            // 
            // birthdate_txt
            // 
            this.birthdate_txt.CustomFormat = "yyyy-MM-dd";
            this.birthdate_txt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.birthdate_txt.Location = new System.Drawing.Point(187, 256);
            this.birthdate_txt.Name = "birthdate_txt";
            this.birthdate_txt.Size = new System.Drawing.Size(97, 20);
            this.birthdate_txt.TabIndex = 23;
            // 
            // empdate_txt
            // 
            this.empdate_txt.CustomFormat = "yyyy-MM-dd";
            this.empdate_txt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.empdate_txt.Location = new System.Drawing.Point(187, 209);
            this.empdate_txt.Name = "empdate_txt";
            this.empdate_txt.Size = new System.Drawing.Size(97, 20);
            this.empdate_txt.TabIndex = 22;
            // 
            // emial_txt
            // 
            this.emial_txt.Location = new System.Drawing.Point(140, 162);
            this.emial_txt.Name = "emial_txt";
            this.emial_txt.Size = new System.Drawing.Size(247, 20);
            this.emial_txt.TabIndex = 21;
            // 
            // phone_txt
            // 
            this.phone_txt.Location = new System.Drawing.Point(140, 120);
            this.phone_txt.MaxLength = 11;
            this.phone_txt.Name = "phone_txt";
            this.phone_txt.Size = new System.Drawing.Size(131, 20);
            this.phone_txt.TabIndex = 20;
            this.phone_txt.TextChanged += new System.EventHandler(this.phone_txt_TextChanged);
            this.phone_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phone_txt_KeyPress);
            // 
            // natid_txt
            // 
            this.natid_txt.Location = new System.Drawing.Point(140, 78);
            this.natid_txt.MaxLength = 14;
            this.natid_txt.Name = "natid_txt";
            this.natid_txt.Size = new System.Drawing.Size(199, 20);
            this.natid_txt.TabIndex = 19;
            this.natid_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.natid_txt_KeyPress);
            // 
            // name_txt
            // 
            this.name_txt.Location = new System.Drawing.Point(140, 45);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(317, 20);
            this.name_txt.TabIndex = 18;
            this.name_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.name_txt_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(531, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "photo";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(531, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "address ";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(66, 352);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "salary ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "birth date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "date of employment";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "E-mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "phone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "national id ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "name";
            // 
            // addemployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 507);
            this.Controls.Add(this.panel1);
            this.Name = "addemployee";
            this.Text = "addemployee";
            this.Load += new System.EventHandler(this.addemployee_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personalphoto_txt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox address_txt;
        private System.Windows.Forms.TextBox salary_txt;
        private System.Windows.Forms.DateTimePicker birthdate_txt;
        private System.Windows.Forms.DateTimePicker empdate_txt;
        private System.Windows.Forms.TextBox emial_txt;
        private System.Windows.Forms.TextBox phone_txt;
        private System.Windows.Forms.TextBox natid_txt;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox personalphoto_txt;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.Button browesbtn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox gender_txt;
        private System.Windows.Forms.ComboBox employeeType_txt;
        private System.Windows.Forms.Label label11;
    }
}