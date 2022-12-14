namespace felhasznal_keppel
{
    partial class Form1
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
            this.listBox_adatok = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_nev = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox_profilkep = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.button_be = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_adatok
            // 
            this.listBox_adatok.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox_adatok.FormattingEnabled = true;
            this.listBox_adatok.Location = new System.Drawing.Point(0, 0);
            this.listBox_adatok.Name = "listBox_adatok";
            this.listBox_adatok.Size = new System.Drawing.Size(265, 429);
            this.listBox_adatok.TabIndex = 1;
            this.listBox_adatok.SelectedIndexChanged += new System.EventHandler(this.listBox_adatok_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(271, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "Új felhasználó";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(379, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 39);
            this.button2.TabIndex = 3;
            this.button2.Text = "Felhasznaló módosítása";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(325, 57);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 35);
            this.button3.TabIndex = 4;
            this.button3.Text = "Felhasználó törlése";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Location = new System.Drawing.Point(491, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(295, 429);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(356, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Név:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(307, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Születési dátum:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(270, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Profilkép(.kiterjesztéssel):";
            // 
            // textBox_nev
            // 
            this.textBox_nev.Location = new System.Drawing.Point(309, 215);
            this.textBox_nev.Name = "textBox_nev";
            this.textBox_nev.Size = new System.Drawing.Size(139, 20);
            this.textBox_nev.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(271, 298);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(214, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // textBox_profilkep
            // 
            this.textBox_profilkep.Location = new System.Drawing.Point(309, 379);
            this.textBox_profilkep.Name = "textBox_profilkep";
            this.textBox_profilkep.Size = new System.Drawing.Size(139, 20);
            this.textBox_profilkep.TabIndex = 11;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(363, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Id:";
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(309, 147);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.ReadOnly = true;
            this.textBox_id.Size = new System.Drawing.Size(139, 20);
            this.textBox_id.TabIndex = 13;
            // 
            // button_be
            // 
            this.button_be.Location = new System.Drawing.Point(332, 405);
            this.button_be.Name = "button_be";
            this.button_be.Size = new System.Drawing.Size(93, 23);
            this.button_be.TabIndex = 14;
            this.button_be.Text = "Kép berakás";
            this.button_be.UseVisualStyleBackColor = true;
            this.button_be.Click += new System.EventHandler(this.button_be_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(786, 429);
            this.Controls.Add(this.button_be);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_profilkep);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox_nev);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox_adatok);
            this.Name = "Form1";
            this.Text = "Felhasználók";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox listBox_adatok;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox textBox_nev;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.TextBox textBox_profilkep;
        public System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Button button_be;
    }
}

