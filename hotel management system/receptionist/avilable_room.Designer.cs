namespace hotel_management_system.receptionist
{
    partial class avilable_room
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
            this.search = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.not_radio = new System.Windows.Forms.RadioButton();
            this.avilable_radio = new System.Windows.Forms.RadioButton();
            this.all_radio = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "search";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(95, 31);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(366, 20);
            this.search.TabIndex = 1;
            this.search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.not_radio);
            this.panel1.Controls.Add(this.avilable_radio);
            this.panel1.Controls.Add(this.all_radio);
            this.panel1.Location = new System.Drawing.Point(57, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 31);
            this.panel1.TabIndex = 3;
            // 
            // not_radio
            // 
            this.not_radio.AutoSize = true;
            this.not_radio.Location = new System.Drawing.Point(213, 11);
            this.not_radio.Name = "not_radio";
            this.not_radio.Size = new System.Drawing.Size(80, 17);
            this.not_radio.TabIndex = 7;
            this.not_radio.Text = "not avilable";
            this.not_radio.UseVisualStyleBackColor = true;
            this.not_radio.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // avilable_radio
            // 
            this.avilable_radio.AutoSize = true;
            this.avilable_radio.Location = new System.Drawing.Point(100, 11);
            this.avilable_radio.Name = "avilable_radio";
            this.avilable_radio.Size = new System.Drawing.Size(61, 17);
            this.avilable_radio.TabIndex = 6;
            this.avilable_radio.Text = "avilable";
            this.avilable_radio.UseVisualStyleBackColor = true;
            this.avilable_radio.CheckedChanged += new System.EventHandler(this.avilable_radio_CheckedChanged);
            // 
            // all_radio
            // 
            this.all_radio.AutoSize = true;
            this.all_radio.Checked = true;
            this.all_radio.Location = new System.Drawing.Point(14, 11);
            this.all_radio.Name = "all_radio";
            this.all_radio.Size = new System.Drawing.Size(35, 17);
            this.all_radio.TabIndex = 5;
            this.all_radio.TabStop = true;
            this.all_radio.Text = "all";
            this.all_radio.UseVisualStyleBackColor = true;
            this.all_radio.CheckedChanged += new System.EventHandler(this.all_radio_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(446, 214);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick_1);
            // 
            // avilable_room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 344);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label1);
            this.Name = "avilable_room";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "avilable_room";
            this.Load += new System.EventHandler(this.avilable_room_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton not_radio;
        private System.Windows.Forms.RadioButton avilable_radio;
        private System.Windows.Forms.RadioButton all_radio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}