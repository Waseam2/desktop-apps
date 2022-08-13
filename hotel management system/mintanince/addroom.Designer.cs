namespace hotel_management_system.mintanince
{
    partial class addroom
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
            this.room_num = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.type = new System.Windows.Forms.ComboBox();
            this.avilable = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.roomlistview = new System.Windows.Forms.DataGridView();
            this.update_price = new System.Windows.Forms.Button();
            this.price_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.roomlistview)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "room number ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "phone";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "avilable";
            // 
            // room_num
            // 
            this.room_num.Location = new System.Drawing.Point(119, 41);
            this.room_num.Name = "room_num";
            this.room_num.Size = new System.Drawing.Size(155, 20);
            this.room_num.TabIndex = 4;
            this.room_num.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.room_num_KeyPress);
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(119, 80);
            this.phone.MaxLength = 11;
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(155, 20);
            this.phone.TabIndex = 5;
            this.phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phone_KeyPress);
            // 
            // type
            // 
            this.type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.type.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.type.ImeMode = System.Windows.Forms.ImeMode.On;
            this.type.Items.AddRange(new object[] {
            "single",
            "double",
            "third ",
            "fourth"});
            this.type.Location = new System.Drawing.Point(119, 121);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(121, 21);
            this.type.TabIndex = 6;
            this.type.Tag = "";
            this.type.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // avilable
            // 
            this.avilable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.avilable.FormattingEnabled = true;
            this.avilable.Items.AddRange(new object[] {
            "yes",
            "no"});
            this.avilable.Location = new System.Drawing.Point(119, 155);
            this.avilable.Name = "avilable";
            this.avilable.Size = new System.Drawing.Size(121, 21);
            this.avilable.TabIndex = 7;
            this.avilable.SelectedIndexChanged += new System.EventHandler(this.avilable_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(210, 226);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(29, 226);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(119, 226);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "save";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // roomlistview
            // 
            this.roomlistview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.roomlistview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomlistview.Location = new System.Drawing.Point(291, 25);
            this.roomlistview.Name = "roomlistview";
            this.roomlistview.Size = new System.Drawing.Size(450, 272);
            this.roomlistview.TabIndex = 12;
            this.roomlistview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.roomlistview_CellClick);
            this.roomlistview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.roomlistview_CellContentClick);
            // 
            // update_price
            // 
            this.update_price.Location = new System.Drawing.Point(119, 265);
            this.update_price.Name = "update_price";
            this.update_price.Size = new System.Drawing.Size(75, 23);
            this.update_price.TabIndex = 13;
            this.update_price.Text = "update price ";
            this.update_price.UseVisualStyleBackColor = true;
            this.update_price.Click += new System.EventHandler(this.update_price_Click);
            // 
            // price_txt
            // 
            this.price_txt.Location = new System.Drawing.Point(119, 191);
            this.price_txt.Name = "price_txt";
            this.price_txt.Size = new System.Drawing.Size(155, 20);
            this.price_txt.TabIndex = 15;
            this.price_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.price_txt_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "price ";
            // 
            // addroom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 332);
            this.Controls.Add(this.price_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.update_price);
            this.Controls.Add(this.roomlistview);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.avilable);
            this.Controls.Add(this.type);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.room_num);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "addroom";
            this.Text = "addroom";
            this.Load += new System.EventHandler(this.addroom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roomlistview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox room_num;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.ComboBox type;
        private System.Windows.Forms.ComboBox avilable;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView roomlistview;
        private System.Windows.Forms.Button update_price;
        private System.Windows.Forms.TextBox price_txt;
        private System.Windows.Forms.Label label5;
    }
}