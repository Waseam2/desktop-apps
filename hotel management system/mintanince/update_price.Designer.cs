namespace hotel_management_system.receptionist
{
    partial class update_price
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.price_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.oneroom = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.typedroom = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.id_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.type_txt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(289, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(338, 450);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // price_txt
            // 
            this.price_txt.Location = new System.Drawing.Point(90, 173);
            this.price_txt.MaxLength = 10;
            this.price_txt.Name = "price_txt";
            this.price_txt.Size = new System.Drawing.Size(133, 20);
            this.price_txt.TabIndex = 1;
            this.price_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.price_txt_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "price ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // oneroom
            // 
            this.oneroom.AutoSize = true;
            this.oneroom.Checked = true;
            this.oneroom.Location = new System.Drawing.Point(6, 35);
            this.oneroom.Name = "oneroom";
            this.oneroom.Size = new System.Drawing.Size(106, 17);
            this.oneroom.TabIndex = 3;
            this.oneroom.TabStop = true;
            this.oneroom.Text = "update this room";
            this.oneroom.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.typedroom);
            this.groupBox1.Controls.Add(this.oneroom);
            this.groupBox1.Location = new System.Drawing.Point(12, 216);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "update type ";
            // 
            // typedroom
            // 
            this.typedroom.AutoSize = true;
            this.typedroom.Location = new System.Drawing.Point(130, 35);
            this.typedroom.Name = "typedroom";
            this.typedroom.Size = new System.Drawing.Size(102, 17);
            this.typedroom.TabIndex = 4;
            this.typedroom.Text = "update all room ";
            this.typedroom.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.typedroom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.typedroom.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(90, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "id";
            // 
            // id_txt
            // 
            this.id_txt.Enabled = false;
            this.id_txt.Location = new System.Drawing.Point(90, 93);
            this.id_txt.Name = "id_txt";
            this.id_txt.Size = new System.Drawing.Size(133, 20);
            this.id_txt.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "type";
            // 
            // type_txt
            // 
            this.type_txt.Enabled = false;
            this.type_txt.Location = new System.Drawing.Point(90, 133);
            this.type_txt.Name = "type_txt";
            this.type_txt.Size = new System.Drawing.Size(133, 20);
            this.type_txt.TabIndex = 8;
            // 
            // update_price
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 474);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.type_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.id_txt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.price_txt);
            this.Controls.Add(this.dataGridView1);
            this.Name = "update_price";
            this.Text = "update_price";
            this.Load += new System.EventHandler(this.update_price_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox price_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton oneroom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton typedroom;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox id_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox type_txt;
    }
}