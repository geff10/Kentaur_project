namespace Zeusz
{
    partial class Hallgató_window
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
            this.tabc_hallgato = new System.Windows.Forms.TabControl();
            this.SzemélyiAdatokTab = new System.Windows.Forms.TabPage();
            this.grb_adatok = new System.Windows.Forms.GroupBox();
            this.lbl_zeusz2 = new System.Windows.Forms.Label();
            this.txtb_személyiIgsz = new System.Windows.Forms.TextBox();
            this.lbl_zeusz = new System.Windows.Forms.Label();
            this.txtb_nev = new System.Windows.Forms.TextBox();
            this.lbl_nev = new System.Windows.Forms.Label();
            this.TantárgykezelőTab = new System.Windows.Forms.TabPage();
            this.ÓrarendTab = new System.Windows.Forms.TabPage();
            this.LeckekönyvTab = new System.Windows.Forms.TabPage();
            this.ÉrtesítésekTab = new System.Windows.Forms.TabPage();
            this.lbl_személyiIgsz = new System.Windows.Forms.Label();
            this.lbl_lakhely = new System.Windows.Forms.Label();
            this.txtb_lakhely = new System.Windows.Forms.TextBox();
            this.lbl_szulhely = new System.Windows.Forms.Label();
            this.txtb_szulhely = new System.Windows.Forms.TextBox();
            this.lbl_szuldatum = new System.Windows.Forms.Label();
            this.mc_szuldatum = new System.Windows.Forms.MonthCalendar();
            this.btn_kuldes = new System.Windows.Forms.Button();
            this.grb_kerelem = new System.Windows.Forms.GroupBox();
            this.lbl_statusz = new System.Windows.Forms.Label();
            this.lbl_statusz2 = new System.Windows.Forms.Label();
            this.rb_passziv = new System.Windows.Forms.RadioButton();
            this.rb_kijelentkezes = new System.Windows.Forms.RadioButton();
            this.btn_kerelem = new System.Windows.Forms.Button();
            this.tabc_hallgato.SuspendLayout();
            this.SzemélyiAdatokTab.SuspendLayout();
            this.grb_adatok.SuspendLayout();
            this.grb_kerelem.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabc_hallgato
            // 
            this.tabc_hallgato.Controls.Add(this.SzemélyiAdatokTab);
            this.tabc_hallgato.Controls.Add(this.TantárgykezelőTab);
            this.tabc_hallgato.Controls.Add(this.ÓrarendTab);
            this.tabc_hallgato.Controls.Add(this.LeckekönyvTab);
            this.tabc_hallgato.Controls.Add(this.ÉrtesítésekTab);
            this.tabc_hallgato.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabc_hallgato.Location = new System.Drawing.Point(0, 0);
            this.tabc_hallgato.Name = "tabc_hallgato";
            this.tabc_hallgato.SelectedIndex = 0;
            this.tabc_hallgato.Size = new System.Drawing.Size(449, 370);
            this.tabc_hallgato.TabIndex = 0;
            // 
            // SzemélyiAdatokTab
            // 
            this.SzemélyiAdatokTab.BackColor = System.Drawing.SystemColors.Control;
            this.SzemélyiAdatokTab.Controls.Add(this.grb_kerelem);
            this.SzemélyiAdatokTab.Controls.Add(this.grb_adatok);
            this.SzemélyiAdatokTab.Location = new System.Drawing.Point(4, 22);
            this.SzemélyiAdatokTab.Name = "SzemélyiAdatokTab";
            this.SzemélyiAdatokTab.Padding = new System.Windows.Forms.Padding(3);
            this.SzemélyiAdatokTab.Size = new System.Drawing.Size(441, 344);
            this.SzemélyiAdatokTab.TabIndex = 0;
            this.SzemélyiAdatokTab.Text = "Adatok kezelése";
            // 
            // grb_adatok
            // 
            this.grb_adatok.Controls.Add(this.btn_kuldes);
            this.grb_adatok.Controls.Add(this.mc_szuldatum);
            this.grb_adatok.Controls.Add(this.lbl_szuldatum);
            this.grb_adatok.Controls.Add(this.txtb_szulhely);
            this.grb_adatok.Controls.Add(this.lbl_szulhely);
            this.grb_adatok.Controls.Add(this.txtb_lakhely);
            this.grb_adatok.Controls.Add(this.lbl_lakhely);
            this.grb_adatok.Controls.Add(this.lbl_személyiIgsz);
            this.grb_adatok.Controls.Add(this.lbl_zeusz2);
            this.grb_adatok.Controls.Add(this.txtb_személyiIgsz);
            this.grb_adatok.Controls.Add(this.lbl_zeusz);
            this.grb_adatok.Controls.Add(this.txtb_nev);
            this.grb_adatok.Controls.Add(this.lbl_nev);
            this.grb_adatok.Location = new System.Drawing.Point(8, 6);
            this.grb_adatok.Name = "grb_adatok";
            this.grb_adatok.Size = new System.Drawing.Size(423, 219);
            this.grb_adatok.TabIndex = 4;
            this.grb_adatok.TabStop = false;
            this.grb_adatok.Text = "Személyi adatok megváltoztatása";
            // 
            // lbl_zeusz2
            // 
            this.lbl_zeusz2.AutoSize = true;
            this.lbl_zeusz2.Location = new System.Drawing.Point(72, 22);
            this.lbl_zeusz2.Name = "lbl_zeusz2";
            this.lbl_zeusz2.Size = new System.Drawing.Size(35, 13);
            this.lbl_zeusz2.TabIndex = 4;
            this.lbl_zeusz2.Text = "label1";
            // 
            // txtb_személyiIgsz
            // 
            this.txtb_személyiIgsz.Location = new System.Drawing.Point(9, 77);
            this.txtb_személyiIgsz.Name = "txtb_személyiIgsz";
            this.txtb_személyiIgsz.Size = new System.Drawing.Size(215, 20);
            this.txtb_személyiIgsz.TabIndex = 3;
            // 
            // lbl_zeusz
            // 
            this.lbl_zeusz.AutoSize = true;
            this.lbl_zeusz.Location = new System.Drawing.Point(6, 22);
            this.lbl_zeusz.Name = "lbl_zeusz";
            this.lbl_zeusz.Size = new System.Drawing.Size(60, 13);
            this.lbl_zeusz.TabIndex = 1;
            this.lbl_zeusz.Text = "Zeusz kód:";
            // 
            // txtb_nev
            // 
            this.txtb_nev.Location = new System.Drawing.Point(75, 38);
            this.txtb_nev.Name = "txtb_nev";
            this.txtb_nev.Size = new System.Drawing.Size(149, 20);
            this.txtb_nev.TabIndex = 2;
            // 
            // lbl_nev
            // 
            this.lbl_nev.AutoSize = true;
            this.lbl_nev.Location = new System.Drawing.Point(6, 41);
            this.lbl_nev.Name = "lbl_nev";
            this.lbl_nev.Size = new System.Drawing.Size(30, 13);
            this.lbl_nev.TabIndex = 0;
            this.lbl_nev.Text = "Név:";
            // 
            // TantárgykezelőTab
            // 
            this.TantárgykezelőTab.BackColor = System.Drawing.SystemColors.Control;
            this.TantárgykezelőTab.Location = new System.Drawing.Point(4, 22);
            this.TantárgykezelőTab.Name = "TantárgykezelőTab";
            this.TantárgykezelőTab.Padding = new System.Windows.Forms.Padding(3);
            this.TantárgykezelőTab.Size = new System.Drawing.Size(466, 304);
            this.TantárgykezelőTab.TabIndex = 1;
            this.TantárgykezelőTab.Text = "Tantárgyak kezelése";
            // 
            // ÓrarendTab
            // 
            this.ÓrarendTab.BackColor = System.Drawing.SystemColors.Control;
            this.ÓrarendTab.Location = new System.Drawing.Point(4, 22);
            this.ÓrarendTab.Name = "ÓrarendTab";
            this.ÓrarendTab.Size = new System.Drawing.Size(466, 304);
            this.ÓrarendTab.TabIndex = 2;
            this.ÓrarendTab.Text = "Órarend";
            // 
            // LeckekönyvTab
            // 
            this.LeckekönyvTab.BackColor = System.Drawing.SystemColors.Control;
            this.LeckekönyvTab.Location = new System.Drawing.Point(4, 22);
            this.LeckekönyvTab.Name = "LeckekönyvTab";
            this.LeckekönyvTab.Size = new System.Drawing.Size(466, 304);
            this.LeckekönyvTab.TabIndex = 3;
            this.LeckekönyvTab.Text = "Leckekönyv";
            // 
            // ÉrtesítésekTab
            // 
            this.ÉrtesítésekTab.BackColor = System.Drawing.SystemColors.Control;
            this.ÉrtesítésekTab.Location = new System.Drawing.Point(4, 22);
            this.ÉrtesítésekTab.Name = "ÉrtesítésekTab";
            this.ÉrtesítésekTab.Size = new System.Drawing.Size(466, 304);
            this.ÉrtesítésekTab.TabIndex = 4;
            this.ÉrtesítésekTab.Text = "Üzenetek";
            // 
            // lbl_személyiIgsz
            // 
            this.lbl_személyiIgsz.AutoSize = true;
            this.lbl_személyiIgsz.Location = new System.Drawing.Point(6, 61);
            this.lbl_személyiIgsz.Name = "lbl_személyiIgsz";
            this.lbl_személyiIgsz.Size = new System.Drawing.Size(131, 13);
            this.lbl_személyiIgsz.TabIndex = 5;
            this.lbl_személyiIgsz.Text = "Személyi igazolvány szám:";
            // 
            // lbl_lakhely
            // 
            this.lbl_lakhely.AutoSize = true;
            this.lbl_lakhely.Location = new System.Drawing.Point(6, 100);
            this.lbl_lakhely.Name = "lbl_lakhely";
            this.lbl_lakhely.Size = new System.Drawing.Size(47, 13);
            this.lbl_lakhely.TabIndex = 6;
            this.lbl_lakhely.Text = "Lakhely:";
            // 
            // txtb_lakhely
            // 
            this.txtb_lakhely.Location = new System.Drawing.Point(9, 116);
            this.txtb_lakhely.Name = "txtb_lakhely";
            this.txtb_lakhely.Size = new System.Drawing.Size(215, 20);
            this.txtb_lakhely.TabIndex = 7;
            // 
            // lbl_szulhely
            // 
            this.lbl_szulhely.AutoSize = true;
            this.lbl_szulhely.Location = new System.Drawing.Point(6, 139);
            this.lbl_szulhely.Name = "lbl_szulhely";
            this.lbl_szulhely.Size = new System.Drawing.Size(74, 13);
            this.lbl_szulhely.TabIndex = 8;
            this.lbl_szulhely.Text = "Születési hely:";
            // 
            // txtb_szulhely
            // 
            this.txtb_szulhely.Location = new System.Drawing.Point(9, 155);
            this.txtb_szulhely.Name = "txtb_szulhely";
            this.txtb_szulhely.Size = new System.Drawing.Size(215, 20);
            this.txtb_szulhely.TabIndex = 9;
            // 
            // lbl_szuldatum
            // 
            this.lbl_szuldatum.AutoSize = true;
            this.lbl_szuldatum.Location = new System.Drawing.Point(230, 22);
            this.lbl_szuldatum.Name = "lbl_szuldatum";
            this.lbl_szuldatum.Size = new System.Drawing.Size(84, 13);
            this.lbl_szuldatum.TabIndex = 10;
            this.lbl_szuldatum.Text = "Születési dátum:";
            // 
            // mc_szuldatum
            // 
            this.mc_szuldatum.Location = new System.Drawing.Point(236, 44);
            this.mc_szuldatum.Name = "mc_szuldatum";
            this.mc_szuldatum.ShowToday = false;
            this.mc_szuldatum.TabIndex = 11;
            // 
            // btn_kuldes
            // 
            this.btn_kuldes.Location = new System.Drawing.Point(9, 181);
            this.btn_kuldes.Name = "btn_kuldes";
            this.btn_kuldes.Size = new System.Drawing.Size(75, 23);
            this.btn_kuldes.TabIndex = 12;
            this.btn_kuldes.Text = "Küldés";
            this.btn_kuldes.UseVisualStyleBackColor = true;
            // 
            // grb_kerelem
            // 
            this.grb_kerelem.Controls.Add(this.btn_kerelem);
            this.grb_kerelem.Controls.Add(this.rb_kijelentkezes);
            this.grb_kerelem.Controls.Add(this.rb_passziv);
            this.grb_kerelem.Controls.Add(this.lbl_statusz2);
            this.grb_kerelem.Controls.Add(this.lbl_statusz);
            this.grb_kerelem.Location = new System.Drawing.Point(8, 231);
            this.grb_kerelem.Name = "grb_kerelem";
            this.grb_kerelem.Size = new System.Drawing.Size(423, 100);
            this.grb_kerelem.TabIndex = 5;
            this.grb_kerelem.TabStop = false;
            this.grb_kerelem.Text = "Státusz";
            // 
            // lbl_statusz
            // 
            this.lbl_statusz.AutoSize = true;
            this.lbl_statusz.Location = new System.Drawing.Point(6, 25);
            this.lbl_statusz.Name = "lbl_statusz";
            this.lbl_statusz.Size = new System.Drawing.Size(127, 13);
            this.lbl_statusz.TabIndex = 0;
            this.lbl_statusz.Text = "Jelenlegi hallgató státusz:";
            // 
            // lbl_statusz2
            // 
            this.lbl_statusz2.AutoSize = true;
            this.lbl_statusz2.Location = new System.Drawing.Point(139, 25);
            this.lbl_statusz2.Name = "lbl_statusz2";
            this.lbl_statusz2.Size = new System.Drawing.Size(35, 13);
            this.lbl_statusz2.TabIndex = 1;
            this.lbl_statusz2.Text = "label2";
            // 
            // rb_passziv
            // 
            this.rb_passziv.AutoSize = true;
            this.rb_passziv.Location = new System.Drawing.Point(222, 23);
            this.rb_passziv.Name = "rb_passziv";
            this.rb_passziv.Size = new System.Drawing.Size(147, 17);
            this.rb_passziv.TabIndex = 2;
            this.rb_passziv.TabStop = true;
            this.rb_passziv.Text = "Passzív kérelem 1 félévre";
            this.rb_passziv.UseVisualStyleBackColor = true;
            // 
            // rb_kijelentkezes
            // 
            this.rb_kijelentkezes.AutoSize = true;
            this.rb_kijelentkezes.Location = new System.Drawing.Point(222, 46);
            this.rb_kijelentkezes.Name = "rb_kijelentkezes";
            this.rb_kijelentkezes.Size = new System.Drawing.Size(145, 17);
            this.rb_kijelentkezes.TabIndex = 3;
            this.rb_kijelentkezes.TabStop = true;
            this.rb_kijelentkezes.Text = "Kijelentkezés az iskolából";
            this.rb_kijelentkezes.UseVisualStyleBackColor = true;
            // 
            // btn_kerelem
            // 
            this.btn_kerelem.Location = new System.Drawing.Point(236, 69);
            this.btn_kerelem.Name = "btn_kerelem";
            this.btn_kerelem.Size = new System.Drawing.Size(108, 23);
            this.btn_kerelem.TabIndex = 4;
            this.btn_kerelem.Text = "Kérelem elküldése";
            this.btn_kerelem.UseVisualStyleBackColor = true;
            // 
            // Hallgató_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 370);
            this.Controls.Add(this.tabc_hallgato);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Hallgató_window";
            this.Text = "Hallgató_window";
            this.Load += new System.EventHandler(this.Hallgató_window_Load);
            this.tabc_hallgato.ResumeLayout(false);
            this.SzemélyiAdatokTab.ResumeLayout(false);
            this.grb_adatok.ResumeLayout(false);
            this.grb_adatok.PerformLayout();
            this.grb_kerelem.ResumeLayout(false);
            this.grb_kerelem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabc_hallgato;
        private System.Windows.Forms.TabPage SzemélyiAdatokTab;
        private System.Windows.Forms.TabPage TantárgykezelőTab;
        private System.Windows.Forms.TabPage ÓrarendTab;
        private System.Windows.Forms.TabPage LeckekönyvTab;
        private System.Windows.Forms.TabPage ÉrtesítésekTab;
        private System.Windows.Forms.TextBox txtb_személyiIgsz;
        private System.Windows.Forms.TextBox txtb_nev;
        private System.Windows.Forms.Label lbl_zeusz;
        private System.Windows.Forms.Label lbl_nev;
        private System.Windows.Forms.GroupBox grb_adatok;
        private System.Windows.Forms.Label lbl_zeusz2;
        private System.Windows.Forms.Label lbl_személyiIgsz;
        private System.Windows.Forms.MonthCalendar mc_szuldatum;
        private System.Windows.Forms.Label lbl_szuldatum;
        private System.Windows.Forms.TextBox txtb_szulhely;
        private System.Windows.Forms.Label lbl_szulhely;
        private System.Windows.Forms.TextBox txtb_lakhely;
        private System.Windows.Forms.Label lbl_lakhely;
        private System.Windows.Forms.GroupBox grb_kerelem;
        private System.Windows.Forms.Button btn_kuldes;
        private System.Windows.Forms.Label lbl_statusz2;
        private System.Windows.Forms.Label lbl_statusz;
        private System.Windows.Forms.Button btn_kerelem;
        private System.Windows.Forms.RadioButton rb_kijelentkezes;
        private System.Windows.Forms.RadioButton rb_passziv;
    }
}