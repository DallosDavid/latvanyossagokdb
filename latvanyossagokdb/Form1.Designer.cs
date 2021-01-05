namespace latvanyossagokdb
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.numericUpDown_lakos = new System.Windows.Forms.NumericUpDown();
            this.button_felvesz = new System.Windows.Forms.Button();
            this.textBox_nev = new System.Windows.Forms.TextBox();
            this.label_nev = new System.Windows.Forms.Label();
            this.label_lakos = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_modositasi = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_torlos_lat = new System.Windows.Forms.Button();
            this.button_latvany_modos = new System.Windows.Forms.Button();
            this.textBox_lerias = new System.Windows.Forms.TextBox();
            this.label_lerias_latvany = new System.Windows.Forms.Label();
            this.label_nev_lat = new System.Windows.Forms.Label();
            this.listBox_latvany = new System.Windows.Forms.ListBox();
            this.button_latvany_felvesz = new System.Windows.Forms.Button();
            this.label_latvany_ar = new System.Windows.Forms.Label();
            this.numericUpDown_ar = new System.Windows.Forms.NumericUpDown();
            this.textBox_latvany = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_lakos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ar)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(192, 39);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(195, 173);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // numericUpDown_lakos
            // 
            this.numericUpDown_lakos.Location = new System.Drawing.Point(29, 138);
            this.numericUpDown_lakos.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.numericUpDown_lakos.Name = "numericUpDown_lakos";
            this.numericUpDown_lakos.Size = new System.Drawing.Size(142, 20);
            this.numericUpDown_lakos.TabIndex = 1;
            this.numericUpDown_lakos.ValueChanged += new System.EventHandler(this.numericUpDown_lakos_ValueChanged);
            // 
            // button_felvesz
            // 
            this.button_felvesz.Location = new System.Drawing.Point(29, 185);
            this.button_felvesz.Name = "button_felvesz";
            this.button_felvesz.Size = new System.Drawing.Size(115, 33);
            this.button_felvesz.TabIndex = 2;
            this.button_felvesz.Text = "Felvesz";
            this.button_felvesz.UseVisualStyleBackColor = true;
            this.button_felvesz.Click += new System.EventHandler(this.button_felvesz_Click);
            // 
            // textBox_nev
            // 
            this.textBox_nev.Location = new System.Drawing.Point(29, 62);
            this.textBox_nev.Name = "textBox_nev";
            this.textBox_nev.Size = new System.Drawing.Size(142, 20);
            this.textBox_nev.TabIndex = 3;
            // 
            // label_nev
            // 
            this.label_nev.AutoSize = true;
            this.label_nev.Location = new System.Drawing.Point(26, 31);
            this.label_nev.Name = "label_nev";
            this.label_nev.Size = new System.Drawing.Size(27, 13);
            this.label_nev.TabIndex = 4;
            this.label_nev.Text = "Nev";
            // 
            // label_lakos
            // 
            this.label_lakos.AutoSize = true;
            this.label_lakos.Location = new System.Drawing.Point(26, 107);
            this.label_lakos.Name = "label_lakos";
            this.label_lakos.Size = new System.Drawing.Size(86, 13);
            this.label_lakos.TabIndex = 5;
            this.label_lakos.Text = "Lakossag szama";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_modositasi);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label_nev);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.button_felvesz);
            this.groupBox1.Controls.Add(this.label_lakos);
            this.groupBox1.Controls.Add(this.numericUpDown_lakos);
            this.groupBox1.Controls.Add(this.textBox_nev);
            this.groupBox1.Location = new System.Drawing.Point(27, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 317);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Város felvéte";
            // 
            // button_modositasi
            // 
            this.button_modositasi.Location = new System.Drawing.Point(112, 262);
            this.button_modositasi.Name = "button_modositasi";
            this.button_modositasi.Size = new System.Drawing.Size(115, 33);
            this.button_modositasi.TabIndex = 7;
            this.button_modositasi.Text = "Modositas";
            this.button_modositasi.UseVisualStyleBackColor = true;
            this.button_modositasi.Visible = false;
            this.button_modositasi.Click += new System.EventHandler(this.button_modositasi_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(249, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 33);
            this.button1.TabIndex = 6;
            this.button1.Text = "Törlés";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_torlos_lat);
            this.groupBox2.Controls.Add(this.button_latvany_modos);
            this.groupBox2.Controls.Add(this.textBox_lerias);
            this.groupBox2.Controls.Add(this.label_lerias_latvany);
            this.groupBox2.Controls.Add(this.label_nev_lat);
            this.groupBox2.Controls.Add(this.listBox_latvany);
            this.groupBox2.Controls.Add(this.button_latvany_felvesz);
            this.groupBox2.Controls.Add(this.label_latvany_ar);
            this.groupBox2.Controls.Add(this.numericUpDown_ar);
            this.groupBox2.Controls.Add(this.textBox_latvany);
            this.groupBox2.Location = new System.Drawing.Point(487, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(546, 317);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Látványosság";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button_torlos_lat
            // 
            this.button_torlos_lat.Location = new System.Drawing.Point(443, 46);
            this.button_torlos_lat.Name = "button_torlos_lat";
            this.button_torlos_lat.Size = new System.Drawing.Size(51, 20);
            this.button_torlos_lat.TabIndex = 8;
            this.button_torlos_lat.Text = "Törlés";
            this.button_torlos_lat.UseVisualStyleBackColor = true;
            this.button_torlos_lat.Visible = false;
            this.button_torlos_lat.Click += new System.EventHandler(this.button_torlos_lat_Click);
            // 
            // button_latvany_modos
            // 
            this.button_latvany_modos.Location = new System.Drawing.Point(415, 113);
            this.button_latvany_modos.Name = "button_latvany_modos";
            this.button_latvany_modos.Size = new System.Drawing.Size(115, 33);
            this.button_latvany_modos.TabIndex = 9;
            this.button_latvany_modos.Text = "Modositas";
            this.button_latvany_modos.UseVisualStyleBackColor = true;
            this.button_latvany_modos.Visible = false;
            this.button_latvany_modos.Click += new System.EventHandler(this.button_latvany_modos_Click);
            // 
            // textBox_lerias
            // 
            this.textBox_lerias.Location = new System.Drawing.Point(20, 120);
            this.textBox_lerias.Name = "textBox_lerias";
            this.textBox_lerias.Size = new System.Drawing.Size(142, 20);
            this.textBox_lerias.TabIndex = 9;
            // 
            // label_lerias_latvany
            // 
            this.label_lerias_latvany.AutoSize = true;
            this.label_lerias_latvany.Location = new System.Drawing.Point(27, 86);
            this.label_lerias_latvany.Name = "label_lerias_latvany";
            this.label_lerias_latvany.Size = new System.Drawing.Size(35, 13);
            this.label_lerias_latvany.TabIndex = 7;
            this.label_lerias_latvany.Text = "Leirás";
            // 
            // label_nev_lat
            // 
            this.label_nev_lat.AutoSize = true;
            this.label_nev_lat.Location = new System.Drawing.Point(26, 31);
            this.label_nev_lat.Name = "label_nev_lat";
            this.label_nev_lat.Size = new System.Drawing.Size(27, 13);
            this.label_nev_lat.TabIndex = 4;
            this.label_nev_lat.Text = "Nev";
            // 
            // listBox_latvany
            // 
            this.listBox_latvany.FormattingEnabled = true;
            this.listBox_latvany.Location = new System.Drawing.Point(189, 31);
            this.listBox_latvany.Name = "listBox_latvany";
            this.listBox_latvany.Size = new System.Drawing.Size(220, 251);
            this.listBox_latvany.TabIndex = 0;
            this.listBox_latvany.SelectedIndexChanged += new System.EventHandler(this.listBox_latvany_SelectedIndexChanged);
            // 
            // button_latvany_felvesz
            // 
            this.button_latvany_felvesz.Location = new System.Drawing.Point(29, 222);
            this.button_latvany_felvesz.Name = "button_latvany_felvesz";
            this.button_latvany_felvesz.Size = new System.Drawing.Size(115, 33);
            this.button_latvany_felvesz.TabIndex = 2;
            this.button_latvany_felvesz.Text = "Felvesz";
            this.button_latvany_felvesz.UseVisualStyleBackColor = true;
            this.button_latvany_felvesz.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_latvany_ar
            // 
            this.label_latvany_ar.AutoSize = true;
            this.label_latvany_ar.Location = new System.Drawing.Point(26, 169);
            this.label_latvany_ar.Name = "label_latvany_ar";
            this.label_latvany_ar.Size = new System.Drawing.Size(17, 13);
            this.label_latvany_ar.TabIndex = 5;
            this.label_latvany_ar.Text = "Ár";
            this.label_latvany_ar.Click += new System.EventHandler(this.label2_Click);
            // 
            // numericUpDown_ar
            // 
            this.numericUpDown_ar.Location = new System.Drawing.Point(20, 185);
            this.numericUpDown_ar.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.numericUpDown_ar.Name = "numericUpDown_ar";
            this.numericUpDown_ar.Size = new System.Drawing.Size(142, 20);
            this.numericUpDown_ar.TabIndex = 1;
            // 
            // textBox_latvany
            // 
            this.textBox_latvany.Location = new System.Drawing.Point(20, 47);
            this.textBox_latvany.Name = "textBox_latvany";
            this.textBox_latvany.Size = new System.Drawing.Size(142, 20);
            this.textBox_latvany.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 599);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_lakos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown_lakos;
        private System.Windows.Forms.Button button_felvesz;
        private System.Windows.Forms.TextBox textBox_nev;
        private System.Windows.Forms.Label label_nev;
        private System.Windows.Forms.Label label_lakos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_nev_lat;
        private System.Windows.Forms.ListBox listBox_latvany;
        private System.Windows.Forms.Button button_latvany_felvesz;
        private System.Windows.Forms.Label label_latvany_ar;
        private System.Windows.Forms.NumericUpDown numericUpDown_ar;
        private System.Windows.Forms.TextBox textBox_latvany;
        private System.Windows.Forms.Label label_lerias_latvany;
        private System.Windows.Forms.TextBox textBox_lerias;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_modositasi;
        private System.Windows.Forms.Button button_torlos_lat;
        private System.Windows.Forms.Button button_latvany_modos;
    }
}

