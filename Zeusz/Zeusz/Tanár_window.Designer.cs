namespace Zeusz
{
    partial class Tanár_window
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TantárgyakTab = new System.Windows.Forms.TabPage();
            this.grb_kezel = new System.Windows.Forms.GroupBox();
            this.btn_targytorol = new System.Windows.Forms.Button();
            this.btn_modosit = new System.Windows.Forms.Button();
            this.btn_targyplusz = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_töröl = new System.Windows.Forms.Button();
            this.btn_hozzaad = new System.Windows.Forms.Button();
            this.lsb_tanirok = new System.Windows.Forms.ListBox();
            this.lbl_tanárok = new System.Windows.Forms.Label();
            this.lsb_oktatok = new System.Windows.Forms.ListBox();
            this.lbl_oktatók = new System.Windows.Forms.Label();
            this.txb_segedlet = new System.Windows.Forms.TextBox();
            this.lbl_segedlet = new System.Windows.Forms.Label();
            this.cmb_kovetelmeny = new System.Windows.Forms.ComboBox();
            this.lbl_kovetelmeny = new System.Windows.Forms.Label();
            this.nud_vperc = new System.Windows.Forms.NumericUpDown();
            this.nud_vora = new System.Windows.Forms.NumericUpDown();
            this.nud_kperc = new System.Windows.Forms.NumericUpDown();
            this.nud_kora = new System.Windows.Forms.NumericUpDown();
            this.lbl_idok = new System.Windows.Forms.Label();
            this.txb_terem = new System.Windows.Forms.TextBox();
            this.lbl_terem = new System.Windows.Forms.Label();
            this.cmb_het = new System.Windows.Forms.ComboBox();
            this.lbl_het = new System.Windows.Forms.Label();
            this.txb_nev = new System.Windows.Forms.TextBox();
            this.lbl_nev = new System.Windows.Forms.Label();
            this.lbl_kod2 = new System.Windows.Forms.Label();
            this.lbl_kod = new System.Windows.Forms.Label();
            this.lsb_tantargyak = new System.Windows.Forms.ListBox();
            this.lbl_tanitot = new System.Windows.Forms.Label();
            this.ÜzenetTab = new System.Windows.Forms.TabPage();
            this.ÉrtékelésTab = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.TantárgyakTab.SuspendLayout();
            this.grb_kezel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_vperc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_vora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_kperc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_kora)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TantárgyakTab);
            this.tabControl1.Controls.Add(this.ÜzenetTab);
            this.tabControl1.Controls.Add(this.ÉrtékelésTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(633, 391);
            this.tabControl1.TabIndex = 0;
            // 
            // TantárgyakTab
            // 
            this.TantárgyakTab.BackColor = System.Drawing.SystemColors.Control;
            this.TantárgyakTab.Controls.Add(this.grb_kezel);
            this.TantárgyakTab.Controls.Add(this.lsb_tantargyak);
            this.TantárgyakTab.Controls.Add(this.lbl_tanitot);
            this.TantárgyakTab.Location = new System.Drawing.Point(4, 22);
            this.TantárgyakTab.Name = "TantárgyakTab";
            this.TantárgyakTab.Padding = new System.Windows.Forms.Padding(3);
            this.TantárgyakTab.Size = new System.Drawing.Size(625, 365);
            this.TantárgyakTab.TabIndex = 0;
            this.TantárgyakTab.Text = "Tantárgyak kezelése";
            // 
            // grb_kezel
            // 
            this.grb_kezel.Controls.Add(this.btn_targytorol);
            this.grb_kezel.Controls.Add(this.btn_modosit);
            this.grb_kezel.Controls.Add(this.btn_targyplusz);
            this.grb_kezel.Controls.Add(this.panel1);
            this.grb_kezel.Controls.Add(this.txb_segedlet);
            this.grb_kezel.Controls.Add(this.lbl_segedlet);
            this.grb_kezel.Controls.Add(this.cmb_kovetelmeny);
            this.grb_kezel.Controls.Add(this.lbl_kovetelmeny);
            this.grb_kezel.Controls.Add(this.nud_vperc);
            this.grb_kezel.Controls.Add(this.nud_vora);
            this.grb_kezel.Controls.Add(this.nud_kperc);
            this.grb_kezel.Controls.Add(this.nud_kora);
            this.grb_kezel.Controls.Add(this.lbl_idok);
            this.grb_kezel.Controls.Add(this.txb_terem);
            this.grb_kezel.Controls.Add(this.lbl_terem);
            this.grb_kezel.Controls.Add(this.cmb_het);
            this.grb_kezel.Controls.Add(this.lbl_het);
            this.grb_kezel.Controls.Add(this.txb_nev);
            this.grb_kezel.Controls.Add(this.lbl_nev);
            this.grb_kezel.Controls.Add(this.lbl_kod2);
            this.grb_kezel.Controls.Add(this.lbl_kod);
            this.grb_kezel.Location = new System.Drawing.Point(145, 13);
            this.grb_kezel.Name = "grb_kezel";
            this.grb_kezel.Size = new System.Drawing.Size(472, 344);
            this.grb_kezel.TabIndex = 2;
            this.grb_kezel.TabStop = false;
            this.grb_kezel.Text = "Kezelés";
            // 
            // btn_targytorol
            // 
            this.btn_targytorol.Location = new System.Drawing.Point(10, 301);
            this.btn_targytorol.Name = "btn_targytorol";
            this.btn_targytorol.Size = new System.Drawing.Size(117, 23);
            this.btn_targytorol.TabIndex = 20;
            this.btn_targytorol.Text = "Tantárgy törlése";
            this.btn_targytorol.UseVisualStyleBackColor = true;
            // 
            // btn_modosit
            // 
            this.btn_modosit.Location = new System.Drawing.Point(10, 272);
            this.btn_modosit.Name = "btn_modosit";
            this.btn_modosit.Size = new System.Drawing.Size(117, 23);
            this.btn_modosit.TabIndex = 19;
            this.btn_modosit.Text = "Tantárgy módosítása";
            this.btn_modosit.UseVisualStyleBackColor = true;
            this.btn_modosit.Click += new System.EventHandler(this.btn_modosit_Click);
            // 
            // btn_targyplusz
            // 
            this.btn_targyplusz.Location = new System.Drawing.Point(10, 243);
            this.btn_targyplusz.Name = "btn_targyplusz";
            this.btn_targyplusz.Size = new System.Drawing.Size(117, 23);
            this.btn_targyplusz.TabIndex = 18;
            this.btn_targyplusz.Text = "Tantárgy felvétele";
            this.btn_targyplusz.UseVisualStyleBackColor = true;
            this.btn_targyplusz.Click += new System.EventHandler(this.btn_targyplusz_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_töröl);
            this.panel1.Controls.Add(this.btn_hozzaad);
            this.panel1.Controls.Add(this.lsb_tanirok);
            this.panel1.Controls.Add(this.lbl_tanárok);
            this.panel1.Controls.Add(this.lsb_oktatok);
            this.panel1.Controls.Add(this.lbl_oktatók);
            this.panel1.Location = new System.Drawing.Point(229, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 308);
            this.panel1.TabIndex = 17;
            // 
            // btn_töröl
            // 
            this.btn_töröl.Location = new System.Drawing.Point(124, 140);
            this.btn_töröl.Name = "btn_töröl";
            this.btn_töröl.Size = new System.Drawing.Size(75, 23);
            this.btn_töröl.TabIndex = 5;
            this.btn_töröl.Text = "Töröl";
            this.btn_töröl.UseVisualStyleBackColor = true;
            // 
            // btn_hozzaad
            // 
            this.btn_hozzaad.Location = new System.Drawing.Point(16, 140);
            this.btn_hozzaad.Name = "btn_hozzaad";
            this.btn_hozzaad.Size = new System.Drawing.Size(75, 23);
            this.btn_hozzaad.TabIndex = 4;
            this.btn_hozzaad.Text = "Hozzáad";
            this.btn_hozzaad.UseVisualStyleBackColor = true;
            this.btn_hozzaad.Click += new System.EventHandler(this.btn_hozzaad_Click);
            // 
            // lsb_tanirok
            // 
            this.lsb_tanirok.FormattingEnabled = true;
            this.lsb_tanirok.Location = new System.Drawing.Point(64, 198);
            this.lsb_tanirok.Name = "lsb_tanirok";
            this.lsb_tanirok.Size = new System.Drawing.Size(135, 95);
            this.lsb_tanirok.TabIndex = 3;
            // 
            // lbl_tanárok
            // 
            this.lbl_tanárok.AutoSize = true;
            this.lbl_tanárok.Location = new System.Drawing.Point(13, 182);
            this.lbl_tanárok.Name = "lbl_tanárok";
            this.lbl_tanárok.Size = new System.Drawing.Size(93, 13);
            this.lbl_tanárok.TabIndex = 2;
            this.lbl_tanárok.Text = "A tárgyat oktatják:";
            // 
            // lsb_oktatok
            // 
            this.lsb_oktatok.FormattingEnabled = true;
            this.lsb_oktatok.Location = new System.Drawing.Point(64, 13);
            this.lsb_oktatok.Name = "lsb_oktatok";
            this.lsb_oktatok.Size = new System.Drawing.Size(135, 121);
            this.lsb_oktatok.TabIndex = 1;
            // 
            // lbl_oktatók
            // 
            this.lbl_oktatók.AutoSize = true;
            this.lbl_oktatók.Location = new System.Drawing.Point(13, 13);
            this.lbl_oktatók.Name = "lbl_oktatók";
            this.lbl_oktatók.Size = new System.Drawing.Size(45, 13);
            this.lbl_oktatók.TabIndex = 0;
            this.lbl_oktatók.Text = "Oktatók";
            // 
            // txb_segedlet
            // 
            this.txb_segedlet.Location = new System.Drawing.Point(9, 217);
            this.txb_segedlet.Name = "txb_segedlet";
            this.txb_segedlet.Size = new System.Drawing.Size(214, 20);
            this.txb_segedlet.TabIndex = 16;
            // 
            // lbl_segedlet
            // 
            this.lbl_segedlet.AutoSize = true;
            this.lbl_segedlet.Location = new System.Drawing.Point(6, 201);
            this.lbl_segedlet.Name = "lbl_segedlet";
            this.lbl_segedlet.Size = new System.Drawing.Size(52, 13);
            this.lbl_segedlet.TabIndex = 15;
            this.lbl_segedlet.Text = "Segédlet:";
            // 
            // cmb_kovetelmeny
            // 
            this.cmb_kovetelmeny.FormattingEnabled = true;
            this.cmb_kovetelmeny.Items.AddRange(new object[] {
            "Aláírás",
            "Évközi jegy",
            "Vizsga"});
            this.cmb_kovetelmeny.Location = new System.Drawing.Point(83, 176);
            this.cmb_kovetelmeny.Name = "cmb_kovetelmeny";
            this.cmb_kovetelmeny.Size = new System.Drawing.Size(140, 21);
            this.cmb_kovetelmeny.TabIndex = 14;
            // 
            // lbl_kovetelmeny
            // 
            this.lbl_kovetelmeny.AutoSize = true;
            this.lbl_kovetelmeny.Location = new System.Drawing.Point(6, 179);
            this.lbl_kovetelmeny.Name = "lbl_kovetelmeny";
            this.lbl_kovetelmeny.Size = new System.Drawing.Size(71, 13);
            this.lbl_kovetelmeny.TabIndex = 13;
            this.lbl_kovetelmeny.Text = "Követelmény:";
            // 
            // nud_vperc
            // 
            this.nud_vperc.Location = new System.Drawing.Point(52, 150);
            this.nud_vperc.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nud_vperc.Name = "nud_vperc";
            this.nud_vperc.Size = new System.Drawing.Size(45, 20);
            this.nud_vperc.TabIndex = 12;
            // 
            // nud_vora
            // 
            this.nud_vora.Location = new System.Drawing.Point(9, 150);
            this.nud_vora.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nud_vora.Name = "nud_vora";
            this.nud_vora.Size = new System.Drawing.Size(37, 20);
            this.nud_vora.TabIndex = 11;
            // 
            // nud_kperc
            // 
            this.nud_kperc.Location = new System.Drawing.Point(52, 124);
            this.nud_kperc.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nud_kperc.Name = "nud_kperc";
            this.nud_kperc.Size = new System.Drawing.Size(45, 20);
            this.nud_kperc.TabIndex = 10;
            // 
            // nud_kora
            // 
            this.nud_kora.Location = new System.Drawing.Point(9, 124);
            this.nud_kora.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nud_kora.Name = "nud_kora";
            this.nud_kora.Size = new System.Drawing.Size(37, 20);
            this.nud_kora.TabIndex = 9;
            this.nud_kora.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // lbl_idok
            // 
            this.lbl_idok.AutoSize = true;
            this.lbl_idok.Location = new System.Drawing.Point(6, 108);
            this.lbl_idok.Name = "lbl_idok";
            this.lbl_idok.Size = new System.Drawing.Size(132, 13);
            this.lbl_idok.TabIndex = 8;
            this.lbl_idok.Text = "Kezdés és befejezés ideje:";
            // 
            // txb_terem
            // 
            this.txb_terem.Location = new System.Drawing.Point(52, 85);
            this.txb_terem.Name = "txb_terem";
            this.txb_terem.Size = new System.Drawing.Size(100, 20);
            this.txb_terem.TabIndex = 7;
            // 
            // lbl_terem
            // 
            this.lbl_terem.AutoSize = true;
            this.lbl_terem.Location = new System.Drawing.Point(6, 88);
            this.lbl_terem.Name = "lbl_terem";
            this.lbl_terem.Size = new System.Drawing.Size(40, 13);
            this.lbl_terem.TabIndex = 6;
            this.lbl_terem.Text = "Terem:";
            // 
            // cmb_het
            // 
            this.cmb_het.FormattingEnabled = true;
            this.cmb_het.Items.AddRange(new object[] {
            "Páros",
            "Páratlan",
            "Minden hét"});
            this.cmb_het.Location = new System.Drawing.Point(39, 58);
            this.cmb_het.Name = "cmb_het";
            this.cmb_het.Size = new System.Drawing.Size(88, 21);
            this.cmb_het.TabIndex = 5;
            // 
            // lbl_het
            // 
            this.lbl_het.AutoSize = true;
            this.lbl_het.Location = new System.Drawing.Point(6, 61);
            this.lbl_het.Name = "lbl_het";
            this.lbl_het.Size = new System.Drawing.Size(27, 13);
            this.lbl_het.TabIndex = 4;
            this.lbl_het.Text = "Hét:";
            // 
            // txb_nev
            // 
            this.txb_nev.Location = new System.Drawing.Point(91, 32);
            this.txb_nev.Name = "txb_nev";
            this.txb_nev.Size = new System.Drawing.Size(132, 20);
            this.txb_nev.TabIndex = 3;
            // 
            // lbl_nev
            // 
            this.lbl_nev.AutoSize = true;
            this.lbl_nev.Location = new System.Drawing.Point(6, 35);
            this.lbl_nev.Name = "lbl_nev";
            this.lbl_nev.Size = new System.Drawing.Size(79, 13);
            this.lbl_nev.TabIndex = 2;
            this.lbl_nev.Text = "Tantárgy neve:";
            // 
            // lbl_kod2
            // 
            this.lbl_kod2.AutoSize = true;
            this.lbl_kod2.Location = new System.Drawing.Point(78, 16);
            this.lbl_kod2.Name = "lbl_kod2";
            this.lbl_kod2.Size = new System.Drawing.Size(49, 13);
            this.lbl_kod2.TabIndex = 1;
            this.lbl_kod2.Text = "AAAAAA";
            // 
            // lbl_kod
            // 
            this.lbl_kod.AutoSize = true;
            this.lbl_kod.Location = new System.Drawing.Point(6, 16);
            this.lbl_kod.Name = "lbl_kod";
            this.lbl_kod.Size = new System.Drawing.Size(66, 13);
            this.lbl_kod.TabIndex = 0;
            this.lbl_kod.Text = "Tárgy kódja:";
            // 
            // lsb_tantargyak
            // 
            this.lsb_tantargyak.FormattingEnabled = true;
            this.lsb_tantargyak.Location = new System.Drawing.Point(6, 29);
            this.lsb_tantargyak.Name = "lsb_tantargyak";
            this.lsb_tantargyak.Size = new System.Drawing.Size(133, 329);
            this.lsb_tantargyak.TabIndex = 1;
            this.lsb_tantargyak.SelectedIndexChanged += new System.EventHandler(this.lsb_tantargyak_SelectedIndexChanged);
            // 
            // lbl_tanitot
            // 
            this.lbl_tanitot.AutoSize = true;
            this.lbl_tanitot.Location = new System.Drawing.Point(3, 13);
            this.lbl_tanitot.Name = "lbl_tanitot";
            this.lbl_tanitot.Size = new System.Drawing.Size(101, 13);
            this.lbl_tanitot.TabIndex = 0;
            this.lbl_tanitot.Text = "Tanított tantárgyak:";
            // 
            // ÜzenetTab
            // 
            this.ÜzenetTab.BackColor = System.Drawing.SystemColors.Control;
            this.ÜzenetTab.Location = new System.Drawing.Point(4, 22);
            this.ÜzenetTab.Name = "ÜzenetTab";
            this.ÜzenetTab.Padding = new System.Windows.Forms.Padding(3);
            this.ÜzenetTab.Size = new System.Drawing.Size(625, 365);
            this.ÜzenetTab.TabIndex = 1;
            this.ÜzenetTab.Text = "Üzenetek";
            // 
            // ÉrtékelésTab
            // 
            this.ÉrtékelésTab.BackColor = System.Drawing.SystemColors.Control;
            this.ÉrtékelésTab.Location = new System.Drawing.Point(4, 22);
            this.ÉrtékelésTab.Name = "ÉrtékelésTab";
            this.ÉrtékelésTab.Size = new System.Drawing.Size(625, 365);
            this.ÉrtékelésTab.TabIndex = 2;
            this.ÉrtékelésTab.Text = "Tanulók értékelése";
            // 
            // Tanár_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 391);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Tanár_window";
            this.Text = "Tanár_window";
            this.Load += new System.EventHandler(this.Tanár_window_Load);
            this.tabControl1.ResumeLayout(false);
            this.TantárgyakTab.ResumeLayout(false);
            this.TantárgyakTab.PerformLayout();
            this.grb_kezel.ResumeLayout(false);
            this.grb_kezel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_vperc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_vora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_kperc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_kora)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TantárgyakTab;
        private System.Windows.Forms.TabPage ÜzenetTab;
        private System.Windows.Forms.TabPage ÉrtékelésTab;
        private System.Windows.Forms.GroupBox grb_kezel;
        private System.Windows.Forms.TextBox txb_nev;
        private System.Windows.Forms.Label lbl_nev;
        private System.Windows.Forms.Label lbl_kod2;
        private System.Windows.Forms.Label lbl_kod;
        private System.Windows.Forms.ListBox lsb_tantargyak;
        private System.Windows.Forms.Label lbl_tanitot;
        private System.Windows.Forms.ComboBox cmb_het;
        private System.Windows.Forms.Label lbl_het;
        private System.Windows.Forms.NumericUpDown nud_vperc;
        private System.Windows.Forms.NumericUpDown nud_vora;
        private System.Windows.Forms.NumericUpDown nud_kperc;
        private System.Windows.Forms.NumericUpDown nud_kora;
        private System.Windows.Forms.Label lbl_idok;
        private System.Windows.Forms.TextBox txb_terem;
        private System.Windows.Forms.Label lbl_terem;
        private System.Windows.Forms.ComboBox cmb_kovetelmeny;
        private System.Windows.Forms.Label lbl_kovetelmeny;
        private System.Windows.Forms.TextBox txb_segedlet;
        private System.Windows.Forms.Label lbl_segedlet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lsb_tanirok;
        private System.Windows.Forms.Label lbl_tanárok;
        private System.Windows.Forms.ListBox lsb_oktatok;
        private System.Windows.Forms.Label lbl_oktatók;
        private System.Windows.Forms.Button btn_targytorol;
        private System.Windows.Forms.Button btn_modosit;
        private System.Windows.Forms.Button btn_targyplusz;
        private System.Windows.Forms.Button btn_töröl;
        private System.Windows.Forms.Button btn_hozzaad;
    }
}