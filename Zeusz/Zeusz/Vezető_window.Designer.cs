namespace Zeusz
{
    partial class Vezető_window
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
            this.tbc_vezeto = new System.Windows.Forms.TabControl();
            this.AdatokTab = new System.Windows.Forms.TabPage();
            this.gb_kezeles = new System.Windows.Forms.GroupBox();
            this.btn_felvetel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txb_beosztas = new System.Windows.Forms.TextBox();
            this.lbl_beosztas = new System.Windows.Forms.Label();
            this.dtp_szulido = new System.Windows.Forms.DateTimePicker();
            this.lbl_szulidő = new System.Windows.Forms.Label();
            this.txb_szulhely = new System.Windows.Forms.TextBox();
            this.lbl_szulhely = new System.Windows.Forms.Label();
            this.txb_lakhely = new System.Windows.Forms.TextBox();
            this.lbl_lakhely = new System.Windows.Forms.Label();
            this.txb_szig = new System.Windows.Forms.TextBox();
            this.lbl_szig = new System.Windows.Forms.Label();
            this.txb_nev = new System.Windows.Forms.TextBox();
            this.lbl_nev = new System.Windows.Forms.Label();
            this.cmb_tipus = new System.Windows.Forms.ComboBox();
            this.lbl_tipus = new System.Windows.Forms.Label();
            this.lsb_felhazsnalok = new System.Windows.Forms.ListBox();
            this.lbl_Felhasznalaok = new System.Windows.Forms.Label();
            this.tbc_vezeto.SuspendLayout();
            this.AdatokTab.SuspendLayout();
            this.gb_kezeles.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbc_vezeto
            // 
            this.tbc_vezeto.Controls.Add(this.AdatokTab);
            this.tbc_vezeto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbc_vezeto.Location = new System.Drawing.Point(0, 0);
            this.tbc_vezeto.Name = "tbc_vezeto";
            this.tbc_vezeto.SelectedIndex = 0;
            this.tbc_vezeto.Size = new System.Drawing.Size(675, 263);
            this.tbc_vezeto.TabIndex = 0;
            this.tbc_vezeto.SelectedIndexChanged += new System.EventHandler(this.tbc_vezeto_SelectedIndexChanged);
            // 
            // AdatokTab
            // 
            this.AdatokTab.BackColor = System.Drawing.SystemColors.Control;
            this.AdatokTab.Controls.Add(this.gb_kezeles);
            this.AdatokTab.Controls.Add(this.lsb_felhazsnalok);
            this.AdatokTab.Controls.Add(this.lbl_Felhasznalaok);
            this.AdatokTab.Location = new System.Drawing.Point(4, 22);
            this.AdatokTab.Name = "AdatokTab";
            this.AdatokTab.Padding = new System.Windows.Forms.Padding(3);
            this.AdatokTab.Size = new System.Drawing.Size(667, 237);
            this.AdatokTab.TabIndex = 1;
            this.AdatokTab.Text = "Felhasználók kezelése";
            // 
            // gb_kezeles
            // 
            this.gb_kezeles.Controls.Add(this.btn_felvetel);
            this.gb_kezeles.Controls.Add(this.groupBox1);
            this.gb_kezeles.Controls.Add(this.dtp_szulido);
            this.gb_kezeles.Controls.Add(this.lbl_szulidő);
            this.gb_kezeles.Controls.Add(this.txb_szulhely);
            this.gb_kezeles.Controls.Add(this.lbl_szulhely);
            this.gb_kezeles.Controls.Add(this.txb_lakhely);
            this.gb_kezeles.Controls.Add(this.lbl_lakhely);
            this.gb_kezeles.Controls.Add(this.txb_szig);
            this.gb_kezeles.Controls.Add(this.lbl_szig);
            this.gb_kezeles.Controls.Add(this.txb_nev);
            this.gb_kezeles.Controls.Add(this.lbl_nev);
            this.gb_kezeles.Controls.Add(this.cmb_tipus);
            this.gb_kezeles.Controls.Add(this.lbl_tipus);
            this.gb_kezeles.Location = new System.Drawing.Point(150, 12);
            this.gb_kezeles.Name = "gb_kezeles";
            this.gb_kezeles.Size = new System.Drawing.Size(509, 215);
            this.gb_kezeles.TabIndex = 2;
            this.gb_kezeles.TabStop = false;
            this.gb_kezeles.Text = "Kezelés";
            // 
            // btn_felvetel
            // 
            this.btn_felvetel.Location = new System.Drawing.Point(149, 104);
            this.btn_felvetel.Name = "btn_felvetel";
            this.btn_felvetel.Size = new System.Drawing.Size(75, 23);
            this.btn_felvetel.TabIndex = 2;
            this.btn_felvetel.Text = "Felvétel";
            this.btn_felvetel.UseVisualStyleBackColor = true;
            this.btn_felvetel.Click += new System.EventHandler(this.btn_felvetel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txb_beosztas);
            this.groupBox1.Controls.Add(this.lbl_beosztas);
            this.groupBox1.Location = new System.Drawing.Point(9, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(134, 89);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tanárok";
            // 
            // txb_beosztas
            // 
            this.txb_beosztas.Location = new System.Drawing.Point(6, 44);
            this.txb_beosztas.Name = "txb_beosztas";
            this.txb_beosztas.Size = new System.Drawing.Size(122, 20);
            this.txb_beosztas.TabIndex = 1;
            // 
            // lbl_beosztas
            // 
            this.lbl_beosztas.AutoSize = true;
            this.lbl_beosztas.Location = new System.Drawing.Point(6, 28);
            this.lbl_beosztas.Name = "lbl_beosztas";
            this.lbl_beosztas.Size = new System.Drawing.Size(53, 13);
            this.lbl_beosztas.TabIndex = 0;
            this.lbl_beosztas.Text = "Beosztás:";
            // 
            // dtp_szulido
            // 
            this.dtp_szulido.Location = new System.Drawing.Point(313, 78);
            this.dtp_szulido.Name = "dtp_szulido";
            this.dtp_szulido.Size = new System.Drawing.Size(190, 20);
            this.dtp_szulido.TabIndex = 11;
            // 
            // lbl_szulidő
            // 
            this.lbl_szulidő.AutoSize = true;
            this.lbl_szulidő.Location = new System.Drawing.Point(238, 81);
            this.lbl_szulidő.Name = "lbl_szulidő";
            this.lbl_szulidő.Size = new System.Drawing.Size(69, 13);
            this.lbl_szulidő.TabIndex = 10;
            this.lbl_szulidő.Text = "Születési idő:";
            // 
            // txb_szulhely
            // 
            this.txb_szulhely.Location = new System.Drawing.Point(318, 52);
            this.txb_szulhely.Name = "txb_szulhely";
            this.txb_szulhely.Size = new System.Drawing.Size(185, 20);
            this.txb_szulhely.TabIndex = 9;
            // 
            // lbl_szulhely
            // 
            this.lbl_szulhely.AutoSize = true;
            this.lbl_szulhely.Location = new System.Drawing.Point(238, 55);
            this.lbl_szulhely.Name = "lbl_szulhely";
            this.lbl_szulhely.Size = new System.Drawing.Size(74, 13);
            this.lbl_szulhely.TabIndex = 8;
            this.lbl_szulhely.Text = "Születési hely:";
            // 
            // txb_lakhely
            // 
            this.txb_lakhely.Location = new System.Drawing.Point(291, 25);
            this.txb_lakhely.Name = "txb_lakhely";
            this.txb_lakhely.Size = new System.Drawing.Size(212, 20);
            this.txb_lakhely.TabIndex = 7;
            // 
            // lbl_lakhely
            // 
            this.lbl_lakhely.AutoSize = true;
            this.lbl_lakhely.Location = new System.Drawing.Point(238, 28);
            this.lbl_lakhely.Name = "lbl_lakhely";
            this.lbl_lakhely.Size = new System.Drawing.Size(47, 13);
            this.lbl_lakhely.TabIndex = 6;
            this.lbl_lakhely.Text = "Lakhely:";
            // 
            // txb_szig
            // 
            this.txb_szig.Location = new System.Drawing.Point(149, 78);
            this.txb_szig.Name = "txb_szig";
            this.txb_szig.Size = new System.Drawing.Size(83, 20);
            this.txb_szig.TabIndex = 5;
            // 
            // lbl_szig
            // 
            this.lbl_szig.AutoSize = true;
            this.lbl_szig.Location = new System.Drawing.Point(6, 81);
            this.lbl_szig.Name = "lbl_szig";
            this.lbl_szig.Size = new System.Drawing.Size(137, 13);
            this.lbl_szig.TabIndex = 4;
            this.lbl_szig.Text = "Személyi igazolvány száma:";
            // 
            // txb_nev
            // 
            this.txb_nev.Location = new System.Drawing.Point(42, 52);
            this.txb_nev.Name = "txb_nev";
            this.txb_nev.Size = new System.Drawing.Size(190, 20);
            this.txb_nev.TabIndex = 3;
            // 
            // lbl_nev
            // 
            this.lbl_nev.AutoSize = true;
            this.lbl_nev.Location = new System.Drawing.Point(6, 55);
            this.lbl_nev.Name = "lbl_nev";
            this.lbl_nev.Size = new System.Drawing.Size(30, 13);
            this.lbl_nev.TabIndex = 2;
            this.lbl_nev.Text = "Név:";
            // 
            // cmb_tipus
            // 
            this.cmb_tipus.FormattingEnabled = true;
            this.cmb_tipus.Items.AddRange(new object[] {
            "Vezető",
            "Tanár",
            "Hallgató"});
            this.cmb_tipus.Location = new System.Drawing.Point(111, 25);
            this.cmb_tipus.Name = "cmb_tipus";
            this.cmb_tipus.Size = new System.Drawing.Size(121, 21);
            this.cmb_tipus.TabIndex = 1;
            this.cmb_tipus.SelectedIndexChanged += new System.EventHandler(this.cmb_tipus_SelectedIndexChanged);
            // 
            // lbl_tipus
            // 
            this.lbl_tipus.AutoSize = true;
            this.lbl_tipus.Location = new System.Drawing.Point(6, 28);
            this.lbl_tipus.Name = "lbl_tipus";
            this.lbl_tipus.Size = new System.Drawing.Size(99, 13);
            this.lbl_tipus.TabIndex = 0;
            this.lbl_tipus.Text = "Felhasználó típusa:";
            // 
            // lsb_felhazsnalok
            // 
            this.lsb_felhazsnalok.FormattingEnabled = true;
            this.lsb_felhazsnalok.Location = new System.Drawing.Point(8, 28);
            this.lsb_felhazsnalok.Name = "lsb_felhazsnalok";
            this.lsb_felhazsnalok.Size = new System.Drawing.Size(136, 199);
            this.lsb_felhazsnalok.TabIndex = 1;
            // 
            // lbl_Felhasznalaok
            // 
            this.lbl_Felhasznalaok.AutoSize = true;
            this.lbl_Felhasznalaok.Location = new System.Drawing.Point(8, 12);
            this.lbl_Felhasznalaok.Name = "lbl_Felhasznalaok";
            this.lbl_Felhasznalaok.Size = new System.Drawing.Size(98, 13);
            this.lbl_Felhasznalaok.TabIndex = 0;
            this.lbl_Felhasznalaok.Text = "Felhasználók lsitája";
            // 
            // Vezető_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 263);
            this.Controls.Add(this.tbc_vezeto);
            this.Name = "Vezető_window";
            this.Text = "Vezető_window";
            this.Load += new System.EventHandler(this.Vezető_window_Load);
            this.tbc_vezeto.ResumeLayout(false);
            this.AdatokTab.ResumeLayout(false);
            this.AdatokTab.PerformLayout();
            this.gb_kezeles.ResumeLayout(false);
            this.gb_kezeles.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbc_vezeto;
        private System.Windows.Forms.TabPage AdatokTab;
        private System.Windows.Forms.GroupBox gb_kezeles;
        private System.Windows.Forms.ListBox lsb_felhazsnalok;
        private System.Windows.Forms.Label lbl_Felhasznalaok;
        private System.Windows.Forms.TextBox txb_nev;
        private System.Windows.Forms.Label lbl_nev;
        private System.Windows.Forms.ComboBox cmb_tipus;
        private System.Windows.Forms.Label lbl_tipus;
        private System.Windows.Forms.TextBox txb_szig;
        private System.Windows.Forms.Label lbl_szig;
        private System.Windows.Forms.Label lbl_lakhely;
        private System.Windows.Forms.DateTimePicker dtp_szulido;
        private System.Windows.Forms.Label lbl_szulidő;
        private System.Windows.Forms.TextBox txb_szulhely;
        private System.Windows.Forms.Label lbl_szulhely;
        private System.Windows.Forms.TextBox txb_lakhely;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txb_beosztas;
        private System.Windows.Forms.Label lbl_beosztas;
        private System.Windows.Forms.Button btn_felvetel;
    }
}