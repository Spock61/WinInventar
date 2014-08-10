namespace WinInventar
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
            this.lblUeberschrift = new System.Windows.Forms.Label();
            this.tpHersteller = new System.Windows.Forms.TabPage();
            this.tpLieferanten = new System.Windows.Forms.TabPage();
            this.tpStandorte = new System.Windows.Forms.TabPage();
            this.tpKunden = new System.Windows.Forms.TabPage();
            this.tpInventar = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnResetInventarFilter = new System.Windows.Forms.Button();
            this.chbInaktive = new System.Windows.Forms.CheckBox();
            this.txtGeraet = new System.Windows.Forms.TextBox();
            this.cbbGruppierung = new System.Windows.Forms.ComboBox();
            this.cbbGattung = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trvGeraete = new System.Windows.Forms.TreeView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpInventar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUeberschrift
            // 
            this.lblUeberschrift.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUeberschrift.AutoSize = true;
            this.lblUeberschrift.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUeberschrift.ForeColor = System.Drawing.Color.Navy;
            this.lblUeberschrift.Location = new System.Drawing.Point(344, 5);
            this.lblUeberschrift.Name = "lblUeberschrift";
            this.lblUeberschrift.Size = new System.Drawing.Size(213, 26);
            this.lblUeberschrift.TabIndex = 2;
            this.lblUeberschrift.Text = "Inventarverwaltung";
            this.lblUeberschrift.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tpHersteller
            // 
            this.tpHersteller.Location = new System.Drawing.Point(4, 22);
            this.tpHersteller.Name = "tpHersteller";
            this.tpHersteller.Size = new System.Drawing.Size(930, 634);
            this.tpHersteller.TabIndex = 4;
            this.tpHersteller.Text = "Hersteller";
            this.tpHersteller.UseVisualStyleBackColor = true;
            // 
            // tpLieferanten
            // 
            this.tpLieferanten.Location = new System.Drawing.Point(4, 22);
            this.tpLieferanten.Name = "tpLieferanten";
            this.tpLieferanten.Size = new System.Drawing.Size(930, 634);
            this.tpLieferanten.TabIndex = 3;
            this.tpLieferanten.Text = "Lieferanten";
            this.tpLieferanten.UseVisualStyleBackColor = true;
            // 
            // tpStandorte
            // 
            this.tpStandorte.Location = new System.Drawing.Point(4, 22);
            this.tpStandorte.Name = "tpStandorte";
            this.tpStandorte.Size = new System.Drawing.Size(930, 634);
            this.tpStandorte.TabIndex = 2;
            this.tpStandorte.Text = "Standorte";
            this.tpStandorte.UseVisualStyleBackColor = true;
            // 
            // tpKunden
            // 
            this.tpKunden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tpKunden.Location = new System.Drawing.Point(4, 22);
            this.tpKunden.Name = "tpKunden";
            this.tpKunden.Padding = new System.Windows.Forms.Padding(3);
            this.tpKunden.Size = new System.Drawing.Size(930, 634);
            this.tpKunden.TabIndex = 1;
            this.tpKunden.Text = "Kunden";
            this.tpKunden.UseVisualStyleBackColor = true;
            // 
            // tpInventar
            // 
            this.tpInventar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tpInventar.Controls.Add(this.groupBox1);
            this.tpInventar.Controls.Add(this.trvGeraete);
            this.tpInventar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpInventar.Location = new System.Drawing.Point(4, 22);
            this.tpInventar.Name = "tpInventar";
            this.tpInventar.Padding = new System.Windows.Forms.Padding(3);
            this.tpInventar.Size = new System.Drawing.Size(930, 634);
            this.tpInventar.TabIndex = 0;
            this.tpInventar.Text = "Inventar";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnResetInventarFilter);
            this.groupBox1.Controls.Add(this.chbInaktive);
            this.groupBox1.Controls.Add(this.txtGeraet);
            this.groupBox1.Controls.Add(this.cbbGruppierung);
            this.groupBox1.Controls.Add(this.cbbGattung);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 129);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inventarfilter";
            // 
            // btnResetInventarFilter
            // 
            this.btnResetInventarFilter.Location = new System.Drawing.Point(280, 99);
            this.btnResetInventarFilter.Name = "btnResetInventarFilter";
            this.btnResetInventarFilter.Size = new System.Drawing.Size(99, 26);
            this.btnResetInventarFilter.TabIndex = 5;
            this.btnResetInventarFilter.Text = "Reset Filter";
            this.btnResetInventarFilter.UseVisualStyleBackColor = true;
            this.btnResetInventarFilter.Click += new System.EventHandler(this.BtnResetInventarFilterClick);
            // 
            // chbInaktive
            // 
            this.chbInaktive.AutoSize = true;
            this.chbInaktive.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chbInaktive.Location = new System.Drawing.Point(6, 103);
            this.chbInaktive.Name = "chbInaktive";
            this.chbInaktive.Size = new System.Drawing.Size(184, 19);
            this.chbInaktive.TabIndex = 4;
            this.chbInaktive.Text = "Deaktivierte Geräte anzeigen";
            this.chbInaktive.UseVisualStyleBackColor = true;
            this.chbInaktive.CheckedChanged += new System.EventHandler(this.ChbInaktiveCheckedChanged);
            // 
            // txtGeraet
            // 
            this.txtGeraet.Location = new System.Drawing.Point(104, 74);
            this.txtGeraet.Name = "txtGeraet";
            this.txtGeraet.Size = new System.Drawing.Size(275, 21);
            this.txtGeraet.TabIndex = 3;
            this.txtGeraet.TextChanged += new System.EventHandler(this.TxtGeraetTextChanged);
            // 
            // cbbGruppierung
            // 
            this.cbbGruppierung.FormattingEnabled = true;
            this.cbbGruppierung.Location = new System.Drawing.Point(104, 47);
            this.cbbGruppierung.Name = "cbbGruppierung";
            this.cbbGruppierung.Size = new System.Drawing.Size(275, 23);
            this.cbbGruppierung.TabIndex = 2;
            this.cbbGruppierung.SelectedIndexChanged += new System.EventHandler(this.CbbGruppierungSelectedIndexChanged);
            // 
            // cbbGattung
            // 
            this.cbbGattung.FormattingEnabled = true;
            this.cbbGattung.Location = new System.Drawing.Point(104, 21);
            this.cbbGattung.Name = "cbbGattung";
            this.cbbGattung.Size = new System.Drawing.Size(275, 23);
            this.cbbGattung.TabIndex = 1;
            this.cbbGattung.SelectedIndexChanged += new System.EventHandler(this.CbbGattungSelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gerät:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gruppierung:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gattung:";
            // 
            // trvGeraete
            // 
            this.trvGeraete.Location = new System.Drawing.Point(3, 141);
            this.trvGeraete.Name = "trvGeraete";
            this.trvGeraete.Size = new System.Drawing.Size(385, 493);
            this.trvGeraete.TabIndex = 10;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpInventar);
            this.tabControl1.Controls.Add(this.tpKunden);
            this.tabControl1.Controls.Add(this.tpStandorte);
            this.tabControl1.Controls.Add(this.tpLieferanten);
            this.tabControl1.Controls.Add(this.tpHersteller);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.MaximumSize = new System.Drawing.Size(1280, 1024);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(938, 660);
            this.tabControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(938, 660);
            this.Controls.Add(this.lblUeberschrift);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1Load);
            this.tpInventar.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUeberschrift;
        private System.Windows.Forms.TabPage tpHersteller;
        private System.Windows.Forms.TabPage tpLieferanten;
        private System.Windows.Forms.TabPage tpStandorte;
        private System.Windows.Forms.TabPage tpKunden;
        private System.Windows.Forms.TabPage tpInventar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnResetInventarFilter;
        private System.Windows.Forms.CheckBox chbInaktive;
        private System.Windows.Forms.TextBox txtGeraet;
        private System.Windows.Forms.ComboBox cbbGruppierung;
        private System.Windows.Forms.ComboBox cbbGattung;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView trvGeraete;
    }
}

