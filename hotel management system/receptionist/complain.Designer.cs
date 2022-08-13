namespace hotel_management_system.receptionist
{
    partial class complain
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
            this.customer_name_txt = new System.Windows.Forms.TextBox();
            this.room_number_txt = new System.Windows.Forms.TextBox();
            this.phone_number_txt = new System.Windows.Forms.TextBox();
            this.email_txt = new System.Windows.Forms.TextBox();
            this.complain_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "custormer name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "room number ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "phone number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "E-mail";
            // 
            // customer_name_txt
            // 
            this.customer_name_txt.Location = new System.Drawing.Point(123, 54);
            this.customer_name_txt.Name = "customer_name_txt";
            this.customer_name_txt.Size = new System.Drawing.Size(226, 20);
            this.customer_name_txt.TabIndex = 4;
            // 
            // room_number_txt
            // 
            this.room_number_txt.Location = new System.Drawing.Point(123, 88);
            this.room_number_txt.Name = "room_number_txt";
            this.room_number_txt.Size = new System.Drawing.Size(138, 20);
            this.room_number_txt.TabIndex = 5;
            // 
            // phone_number_txt
            // 
            this.phone_number_txt.Location = new System.Drawing.Point(123, 120);
            this.phone_number_txt.Name = "phone_number_txt";
            this.phone_number_txt.Size = new System.Drawing.Size(138, 20);
            this.phone_number_txt.TabIndex = 6;
            // 
            // email_txt
            // 
            this.email_txt.Location = new System.Drawing.Point(123, 156);
            this.email_txt.Name = "email_txt";
            this.email_txt.Size = new System.Drawing.Size(226, 20);
            this.email_txt.TabIndex = 7;
            // 
            // complain_txt
            // 
            this.complain_txt.Location = new System.Drawing.Point(429, 41);
            this.complain_txt.Multiline = true;
            this.complain_txt.Name = "complain_txt";
            this.complain_txt.Size = new System.Drawing.Size(324, 277);
            this.complain_txt.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(547, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "complain text ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(274, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(25, 286);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 32);
            this.button2.TabIndex = 11;
            this.button2.Text = "back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // complain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 330);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.complain_txt);
            this.Controls.Add(this.email_txt);
            this.Controls.Add(this.phone_number_txt);
            this.Controls.Add(this.room_number_txt);
            this.Controls.Add(this.customer_name_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "complain";
            this.Text = "complain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox customer_name_txt;
        private System.Windows.Forms.TextBox room_number_txt;
        private System.Windows.Forms.TextBox phone_number_txt;
        private System.Windows.Forms.TextBox email_txt;
        private System.Windows.Forms.TextBox complain_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}