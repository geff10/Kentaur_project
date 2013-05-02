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
            this.grb_kerelem = new System.Windows.Forms.GroupBox();
            this.btn_kerelem = new System.Windows.Forms.Button();
            this.rb_kijelentkezes = new System.Windows.Forms.RadioButton();
            this.rb_passziv = new System.Windows.Forms.RadioButton();
            this.lbl_statusz2 = new System.Windows.Forms.Label();
            this.lbl_statusz = new System.Windows.Forms.Label();
            this.grb_adatok = new System.Windows.Forms.GroupBox();
            this.dtp_szulDatum = new System.Windows.Forms.DateTimePicker();
            this.btn_kuldes = new System.Windows.Forms.Button();
            this.lbl_szuldatum = new System.Windows.Forms.Label();
            this.txb_szulhely = new System.Windows.Forms.TextBox();
            this.lbl_szulhely = new System.Windows.Forms.Label();
            this.txb_lakhely = new System.Windows.Forms.TextBox();
            this.lbl_lakhely = new System.Windows.Forms.Label();
            this.lbl_személyiIgsz = new System.Windows.Forms.Label();
            this.lbl_zeusz2 = new System.Windows.Forms.Label();
            this.txb_személyiIgsz = new System.Windows.Forms.TextBox();
            this.lbl_zeusz = new System.Windows.Forms.Label();
            this.txb_nev = new System.Windows.Forms.TextBox();
            this.lbl_nev = new System.Windows.Forms.Label();
            this.TantárgykezelőTab = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_nap2 = new System.Windows.Forms.Label();
            this.lbl_nap = new System.Windows.Forms.Label();
            this.txb_segedlet = new System.Windows.Forms.TextBox();
            this.lbl_segedlet = new System.Windows.Forms.Label();
            this.lbl_jegy = new System.Windows.Forms.Label();
            this.lbl_követelmeny = new System.Windows.Forms.Label();
            this.txb_befejezes = new System.Windows.Forms.TextBox();
            this.lbl_befejez = new System.Windows.Forms.Label();
            this.lbl_parose = new System.Windows.Forms.Label();
            this.lbl_het = new System.Windows.Forms.Label();
            this.txb_kezdes = new System.Windows.Forms.TextBox();
            this.lbl_kezdes = new System.Windows.Forms.Label();
            this.txb_tanar = new System.Windows.Forms.TextBox();
            this.lbl_felelös = new System.Windows.Forms.Label();
            this.txb_terem = new System.Windows.Forms.TextBox();
            this.lbl_terem = new System.Windows.Forms.Label();
            this.lbl_kod2 = new System.Windows.Forms.Label();
            this.lbl_kod = new System.Windows.Forms.Label();
            this.txb_targynev = new System.Windows.Forms.TextBox();
            this.lbl_targynev = new System.Windows.Forms.Label();
            this.btn_leadas = new System.Windows.Forms.Button();
            this.btn_felvetel = new System.Windows.Forms.Button();
            this.lsb_felvett = new System.Windows.Forms.ListBox();
            this.lbl_felvett = new System.Windows.Forms.Label();
            this.lsb_felveheto = new System.Windows.Forms.ListBox();
            this.lbl_felveheto = new System.Windows.Forms.Label();
            this.ÓrarendTab = new System.Windows.Forms.TabPage();
            this.LeckekönyvTab = new System.Windows.Forms.TabPage();
            this.ÉrtesítésekTab = new System.Windows.Forms.TabPage();
            this.btn_torol = new System.Windows.Forms.Button();
            this.rtxb_uzenet = new System.Windows.Forms.RichTextBox();
            this.lbl_üzenet = new System.Windows.Forms.Label();
            this.txb_kuldo = new System.Windows.Forms.TextBox();
            this.lbl_kuldo = new System.Windows.Forms.Label();
            this.txb_targy = new System.Windows.Forms.TextBox();
            this.lbl_tárgy = new System.Windows.Forms.Label();
            this.btn_uj = new System.Windows.Forms.Button();
            this.btn_osszes = new System.Windows.Forms.Button();
            this.btn_frissit = new System.Windows.Forms.Button();
            this.lsb_lista = new System.Windows.Forms.ListBox();
            this.lbl_üzenetbe = new System.Windows.Forms.Label();
            this.tabc_hallgato.SuspendLayout();
            this.SzemélyiAdatokTab.SuspendLayout();
            this.grb_kerelem.SuspendLayout();
            this.grb_adatok.SuspendLayout();
            this.TantárgykezelőTab.SuspendLayout();
            this.panel1.SuspendLayout();
            this.ÉrtesítésekTab.SuspendLayout();
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
            this.tabc_hallgato.SelectedIndexChanged += new System.EventHandler(this.tabc_hallgato_SelectedIndexChanged);
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
            // btn_kerelem
            // 
            this.btn_kerelem.Location = new System.Drawing.Point(236, 69);
            this.btn_kerelem.Name = "btn_kerelem";
            this.btn_kerelem.Size = new System.Drawing.Size(108, 23);
            this.btn_kerelem.TabIndex = 4;
            this.btn_kerelem.Text = "Kérelem elküldése";
            this.btn_kerelem.UseVisualStyleBackColor = true;
            this.btn_kerelem.Click += new System.EventHandler(this.btn_kerelem_Click);
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
            // rb_passziv
            // 
            this.rb_passziv.AutoSize = true;
            this.rb_passziv.Checked = true;
            this.rb_passziv.Location = new System.Drawing.Point(222, 23);
            this.rb_passziv.Name = "rb_passziv";
            this.rb_passziv.Size = new System.Drawing.Size(147, 17);
            this.rb_passziv.TabIndex = 2;
            this.rb_passziv.TabStop = true;
            this.rb_passziv.Text = "Passzív kérelem 1 félévre";
            this.rb_passziv.UseVisualStyleBackColor = true;
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
            // lbl_statusz
            // 
            this.lbl_statusz.AutoSize = true;
            this.lbl_statusz.Location = new System.Drawing.Point(6, 25);
            this.lbl_statusz.Name = "lbl_statusz";
            this.lbl_statusz.Size = new System.Drawing.Size(127, 13);
            this.lbl_statusz.TabIndex = 0;
            this.lbl_statusz.Text = "Jelenlegi hallgató státusz:";
            // 
            // grb_adatok
            // 
            this.grb_adatok.Controls.Add(this.dtp_szulDatum);
            this.grb_adatok.Controls.Add(this.btn_kuldes);
            this.grb_adatok.Controls.Add(this.lbl_szuldatum);
            this.grb_adatok.Controls.Add(this.txb_szulhely);
            this.grb_adatok.Controls.Add(this.lbl_szulhely);
            this.grb_adatok.Controls.Add(this.txb_lakhely);
            this.grb_adatok.Controls.Add(this.lbl_lakhely);
            this.grb_adatok.Controls.Add(this.lbl_személyiIgsz);
            this.grb_adatok.Controls.Add(this.lbl_zeusz2);
            this.grb_adatok.Controls.Add(this.txb_személyiIgsz);
            this.grb_adatok.Controls.Add(this.lbl_zeusz);
            this.grb_adatok.Controls.Add(this.txb_nev);
            this.grb_adatok.Controls.Add(this.lbl_nev);
            this.grb_adatok.Location = new System.Drawing.Point(8, 6);
            this.grb_adatok.Name = "grb_adatok";
            this.grb_adatok.Size = new System.Drawing.Size(423, 219);
            this.grb_adatok.TabIndex = 4;
            this.grb_adatok.TabStop = false;
            this.grb_adatok.Text = "Személyi adatok megváltoztatása";
            // 
            // dtp_szulDatum
            // 
            this.dtp_szulDatum.Enabled = false;
            this.dtp_szulDatum.Location = new System.Drawing.Point(233, 38);
            this.dtp_szulDatum.Name = "dtp_szulDatum";
            this.dtp_szulDatum.Size = new System.Drawing.Size(166, 20);
            this.dtp_szulDatum.TabIndex = 13;
            // 
            // btn_kuldes
            // 
            this.btn_kuldes.Location = new System.Drawing.Point(9, 181);
            this.btn_kuldes.Name = "btn_kuldes";
            this.btn_kuldes.Size = new System.Drawing.Size(75, 23);
            this.btn_kuldes.TabIndex = 12;
            this.btn_kuldes.Text = "Küldés";
            this.btn_kuldes.UseVisualStyleBackColor = true;
            this.btn_kuldes.Click += new System.EventHandler(this.btn_kuldes_Click);
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
            // txb_szulhely
            // 
            this.txb_szulhely.Location = new System.Drawing.Point(9, 155);
            this.txb_szulhely.Name = "txb_szulhely";
            this.txb_szulhely.Size = new System.Drawing.Size(215, 20);
            this.txb_szulhely.TabIndex = 9;
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
            // txb_lakhely
            // 
            this.txb_lakhely.Location = new System.Drawing.Point(9, 116);
            this.txb_lakhely.Name = "txb_lakhely";
            this.txb_lakhely.Size = new System.Drawing.Size(215, 20);
            this.txb_lakhely.TabIndex = 7;
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
            // lbl_személyiIgsz
            // 
            this.lbl_személyiIgsz.AutoSize = true;
            this.lbl_személyiIgsz.Location = new System.Drawing.Point(6, 61);
            this.lbl_személyiIgsz.Name = "lbl_személyiIgsz";
            this.lbl_személyiIgsz.Size = new System.Drawing.Size(131, 13);
            this.lbl_személyiIgsz.TabIndex = 5;
            this.lbl_személyiIgsz.Text = "Személyi igazolvány szám:";
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
            // txb_személyiIgsz
            // 
            this.txb_személyiIgsz.Location = new System.Drawing.Point(9, 77);
            this.txb_személyiIgsz.Name = "txb_személyiIgsz";
            this.txb_személyiIgsz.Size = new System.Drawing.Size(215, 20);
            this.txb_személyiIgsz.TabIndex = 3;
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
            // txb_nev
            // 
            this.txb_nev.Location = new System.Drawing.Point(75, 38);
            this.txb_nev.Name = "txb_nev";
            this.txb_nev.Size = new System.Drawing.Size(149, 20);
            this.txb_nev.TabIndex = 2;
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
            this.TantárgykezelőTab.Controls.Add(this.panel1);
            this.TantárgykezelőTab.Controls.Add(this.btn_leadas);
            this.TantárgykezelőTab.Controls.Add(this.btn_felvetel);
            this.TantárgykezelőTab.Controls.Add(this.lsb_felvett);
            this.TantárgykezelőTab.Controls.Add(this.lbl_felvett);
            this.TantárgykezelőTab.Controls.Add(this.lsb_felveheto);
            this.TantárgykezelőTab.Controls.Add(this.lbl_felveheto);
            this.TantárgykezelőTab.Location = new System.Drawing.Point(4, 22);
            this.TantárgykezelőTab.Name = "TantárgykezelőTab";
            this.TantárgykezelőTab.Padding = new System.Windows.Forms.Padding(3);
            this.TantárgykezelőTab.Size = new System.Drawing.Size(441, 344);
            this.TantárgykezelőTab.TabIndex = 1;
            this.TantárgykezelőTab.Text = "Tantárgyak kezelése";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbl_nap2);
            this.panel1.Controls.Add(this.lbl_nap);
            this.panel1.Controls.Add(this.txb_segedlet);
            this.panel1.Controls.Add(this.lbl_segedlet);
            this.panel1.Controls.Add(this.lbl_jegy);
            this.panel1.Controls.Add(this.lbl_követelmeny);
            this.panel1.Controls.Add(this.txb_befejezes);
            this.panel1.Controls.Add(this.lbl_befejez);
            this.panel1.Controls.Add(this.lbl_parose);
            this.panel1.Controls.Add(this.lbl_het);
            this.panel1.Controls.Add(this.txb_kezdes);
            this.panel1.Controls.Add(this.lbl_kezdes);
            this.panel1.Controls.Add(this.txb_tanar);
            this.panel1.Controls.Add(this.lbl_felelös);
            this.panel1.Controls.Add(this.txb_terem);
            this.panel1.Controls.Add(this.lbl_terem);
            this.panel1.Controls.Add(this.lbl_kod2);
            this.panel1.Controls.Add(this.lbl_kod);
            this.panel1.Controls.Add(this.txb_targynev);
            this.panel1.Controls.Add(this.lbl_targynev);
            this.panel1.Location = new System.Drawing.Point(8, 220);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(425, 116);
            this.panel1.TabIndex = 6;
            // 
            // lbl_nap2
            // 
            this.lbl_nap2.AutoSize = true;
            this.lbl_nap2.Location = new System.Drawing.Point(50, 60);
            this.lbl_nap2.Name = "lbl_nap2";
            this.lbl_nap2.Size = new System.Drawing.Size(0, 13);
            this.lbl_nap2.TabIndex = 19;
            // 
            // lbl_nap
            // 
            this.lbl_nap.AutoSize = true;
            this.lbl_nap.Location = new System.Drawing.Point(14, 60);
            this.lbl_nap.Name = "lbl_nap";
            this.lbl_nap.Size = new System.Drawing.Size(30, 13);
            this.lbl_nap.TabIndex = 18;
            this.lbl_nap.Text = "Nap:";
            // 
            // txb_segedlet
            // 
            this.txb_segedlet.Enabled = false;
            this.txb_segedlet.Location = new System.Drawing.Point(72, 83);
            this.txb_segedlet.Name = "txb_segedlet";
            this.txb_segedlet.Size = new System.Drawing.Size(344, 20);
            this.txb_segedlet.TabIndex = 17;
            // 
            // lbl_segedlet
            // 
            this.lbl_segedlet.AutoSize = true;
            this.lbl_segedlet.Location = new System.Drawing.Point(14, 86);
            this.lbl_segedlet.Name = "lbl_segedlet";
            this.lbl_segedlet.Size = new System.Drawing.Size(52, 13);
            this.lbl_segedlet.TabIndex = 16;
            this.lbl_segedlet.Text = "Segédlet:";
            // 
            // lbl_jegy
            // 
            this.lbl_jegy.AutoSize = true;
            this.lbl_jegy.Location = new System.Drawing.Point(355, 61);
            this.lbl_jegy.Name = "lbl_jegy";
            this.lbl_jegy.Size = new System.Drawing.Size(0, 13);
            this.lbl_jegy.TabIndex = 15;
            // 
            // lbl_követelmeny
            // 
            this.lbl_követelmeny.AutoSize = true;
            this.lbl_követelmeny.Location = new System.Drawing.Point(278, 60);
            this.lbl_követelmeny.Name = "lbl_követelmeny";
            this.lbl_követelmeny.Size = new System.Drawing.Size(71, 13);
            this.lbl_követelmeny.TabIndex = 14;
            this.lbl_követelmeny.Text = "Követelmény:";
            // 
            // txb_befejezes
            // 
            this.txb_befejezes.Enabled = false;
            this.txb_befejezes.Location = new System.Drawing.Point(238, 58);
            this.txb_befejezes.Name = "txb_befejezes";
            this.txb_befejezes.Size = new System.Drawing.Size(34, 20);
            this.txb_befejezes.TabIndex = 13;
            // 
            // lbl_befejez
            // 
            this.lbl_befejez.AutoSize = true;
            this.lbl_befejez.Location = new System.Drawing.Point(176, 60);
            this.lbl_befejez.Name = "lbl_befejez";
            this.lbl_befejez.Size = new System.Drawing.Size(56, 13);
            this.lbl_befejez.TabIndex = 12;
            this.lbl_befejez.Text = "Befejezés:";
            // 
            // lbl_parose
            // 
            this.lbl_parose.AutoSize = true;
            this.lbl_parose.Location = new System.Drawing.Point(355, 9);
            this.lbl_parose.Name = "lbl_parose";
            this.lbl_parose.Size = new System.Drawing.Size(0, 13);
            this.lbl_parose.TabIndex = 11;
            // 
            // lbl_het
            // 
            this.lbl_het.AutoSize = true;
            this.lbl_het.Location = new System.Drawing.Point(328, 9);
            this.lbl_het.Name = "lbl_het";
            this.lbl_het.Size = new System.Drawing.Size(27, 13);
            this.lbl_het.TabIndex = 10;
            this.lbl_het.Text = "Hét:";
            // 
            // txb_kezdes
            // 
            this.txb_kezdes.Enabled = false;
            this.txb_kezdes.Location = new System.Drawing.Point(136, 58);
            this.txb_kezdes.Name = "txb_kezdes";
            this.txb_kezdes.Size = new System.Drawing.Size(34, 20);
            this.txb_kezdes.TabIndex = 9;
            // 
            // lbl_kezdes
            // 
            this.lbl_kezdes.AutoSize = true;
            this.lbl_kezdes.Location = new System.Drawing.Point(85, 60);
            this.lbl_kezdes.Name = "lbl_kezdes";
            this.lbl_kezdes.Size = new System.Drawing.Size(45, 13);
            this.lbl_kezdes.TabIndex = 8;
            this.lbl_kezdes.Text = "Kezdés:";
            // 
            // txb_tanar
            // 
            this.txb_tanar.Enabled = false;
            this.txb_tanar.Location = new System.Drawing.Point(249, 32);
            this.txb_tanar.Name = "txb_tanar";
            this.txb_tanar.Size = new System.Drawing.Size(167, 20);
            this.txb_tanar.TabIndex = 7;
            // 
            // lbl_felelös
            // 
            this.lbl_felelös.AutoSize = true;
            this.lbl_felelös.Location = new System.Drawing.Point(158, 35);
            this.lbl_felelös.Name = "lbl_felelös";
            this.lbl_felelös.Size = new System.Drawing.Size(85, 13);
            this.lbl_felelös.TabIndex = 6;
            this.lbl_felelös.Text = "Tantárgy felelős:";
            // 
            // txb_terem
            // 
            this.txb_terem.Enabled = false;
            this.txb_terem.Location = new System.Drawing.Point(60, 32);
            this.txb_terem.Name = "txb_terem";
            this.txb_terem.Size = new System.Drawing.Size(92, 20);
            this.txb_terem.TabIndex = 5;
            // 
            // lbl_terem
            // 
            this.lbl_terem.AutoSize = true;
            this.lbl_terem.Location = new System.Drawing.Point(14, 35);
            this.lbl_terem.Name = "lbl_terem";
            this.lbl_terem.Size = new System.Drawing.Size(40, 13);
            this.lbl_terem.TabIndex = 4;
            this.lbl_terem.Text = "Terem:";
            // 
            // lbl_kod2
            // 
            this.lbl_kod2.AutoSize = true;
            this.lbl_kod2.Location = new System.Drawing.Point(283, 9);
            this.lbl_kod2.Name = "lbl_kod2";
            this.lbl_kod2.Size = new System.Drawing.Size(0, 13);
            this.lbl_kod2.TabIndex = 3;
            // 
            // lbl_kod
            // 
            this.lbl_kod.AutoSize = true;
            this.lbl_kod.Location = new System.Drawing.Point(211, 9);
            this.lbl_kod.Name = "lbl_kod";
            this.lbl_kod.Size = new System.Drawing.Size(66, 13);
            this.lbl_kod.TabIndex = 2;
            this.lbl_kod.Text = "Tárgy kódja:";
            // 
            // txb_targynev
            // 
            this.txb_targynev.Enabled = false;
            this.txb_targynev.Location = new System.Drawing.Point(84, 6);
            this.txb_targynev.Name = "txb_targynev";
            this.txb_targynev.Size = new System.Drawing.Size(121, 20);
            this.txb_targynev.TabIndex = 1;
            // 
            // lbl_targynev
            // 
            this.lbl_targynev.AutoSize = true;
            this.lbl_targynev.Location = new System.Drawing.Point(14, 9);
            this.lbl_targynev.Name = "lbl_targynev";
            this.lbl_targynev.Size = new System.Drawing.Size(64, 13);
            this.lbl_targynev.TabIndex = 0;
            this.lbl_targynev.Text = "Tárgy neve:";
            // 
            // btn_leadas
            // 
            this.btn_leadas.Location = new System.Drawing.Point(185, 57);
            this.btn_leadas.Name = "btn_leadas";
            this.btn_leadas.Size = new System.Drawing.Size(75, 23);
            this.btn_leadas.TabIndex = 5;
            this.btn_leadas.Text = "Leadás";
            this.btn_leadas.UseVisualStyleBackColor = true;
            this.btn_leadas.Click += new System.EventHandler(this.btn_leadas_Click);
            // 
            // btn_felvetel
            // 
            this.btn_felvetel.Location = new System.Drawing.Point(185, 28);
            this.btn_felvetel.Name = "btn_felvetel";
            this.btn_felvetel.Size = new System.Drawing.Size(75, 23);
            this.btn_felvetel.TabIndex = 4;
            this.btn_felvetel.Text = "Felvétel";
            this.btn_felvetel.UseVisualStyleBackColor = true;
            this.btn_felvetel.Click += new System.EventHandler(this.btn_felvetel_Click);
            // 
            // lsb_felvett
            // 
            this.lsb_felvett.FormattingEnabled = true;
            this.lsb_felvett.Location = new System.Drawing.Point(275, 28);
            this.lsb_felvett.Name = "lsb_felvett";
            this.lsb_felvett.Size = new System.Drawing.Size(158, 186);
            this.lsb_felvett.TabIndex = 3;
            this.lsb_felvett.SelectedIndexChanged += new System.EventHandler(this.lsb_felvett_SelectedIndexChanged);
            // 
            // lbl_felvett
            // 
            this.lbl_felvett.AutoSize = true;
            this.lbl_felvett.Location = new System.Drawing.Point(272, 12);
            this.lbl_felvett.Name = "lbl_felvett";
            this.lbl_felvett.Size = new System.Drawing.Size(77, 13);
            this.lbl_felvett.TabIndex = 2;
            this.lbl_felvett.Text = "Felvett tárgyak";
            // 
            // lsb_felveheto
            // 
            this.lsb_felveheto.FormattingEnabled = true;
            this.lsb_felveheto.Location = new System.Drawing.Point(8, 28);
            this.lsb_felveheto.Name = "lsb_felveheto";
            this.lsb_felveheto.Size = new System.Drawing.Size(161, 186);
            this.lsb_felveheto.TabIndex = 1;
            this.lsb_felveheto.SelectedIndexChanged += new System.EventHandler(this.lsb_felveheto_SelectedIndexChanged);
            // 
            // lbl_felveheto
            // 
            this.lbl_felveheto.AutoSize = true;
            this.lbl_felveheto.Location = new System.Drawing.Point(8, 12);
            this.lbl_felveheto.Name = "lbl_felveheto";
            this.lbl_felveheto.Size = new System.Drawing.Size(92, 13);
            this.lbl_felveheto.TabIndex = 0;
            this.lbl_felveheto.Text = "Felvehető tárgyak";
            // 
            // ÓrarendTab
            // 
            this.ÓrarendTab.BackColor = System.Drawing.SystemColors.Control;
            this.ÓrarendTab.Location = new System.Drawing.Point(4, 22);
            this.ÓrarendTab.Name = "ÓrarendTab";
            this.ÓrarendTab.Size = new System.Drawing.Size(441, 344);
            this.ÓrarendTab.TabIndex = 2;
            this.ÓrarendTab.Text = "Órarend";
            // 
            // LeckekönyvTab
            // 
            this.LeckekönyvTab.BackColor = System.Drawing.SystemColors.Control;
            this.LeckekönyvTab.Location = new System.Drawing.Point(4, 22);
            this.LeckekönyvTab.Name = "LeckekönyvTab";
            this.LeckekönyvTab.Size = new System.Drawing.Size(441, 344);
            this.LeckekönyvTab.TabIndex = 3;
            this.LeckekönyvTab.Text = "Leckekönyv";
            // 
            // ÉrtesítésekTab
            // 
            this.ÉrtesítésekTab.BackColor = System.Drawing.SystemColors.Control;
            this.ÉrtesítésekTab.Controls.Add(this.btn_torol);
            this.ÉrtesítésekTab.Controls.Add(this.rtxb_uzenet);
            this.ÉrtesítésekTab.Controls.Add(this.lbl_üzenet);
            this.ÉrtesítésekTab.Controls.Add(this.txb_kuldo);
            this.ÉrtesítésekTab.Controls.Add(this.lbl_kuldo);
            this.ÉrtesítésekTab.Controls.Add(this.txb_targy);
            this.ÉrtesítésekTab.Controls.Add(this.lbl_tárgy);
            this.ÉrtesítésekTab.Controls.Add(this.btn_uj);
            this.ÉrtesítésekTab.Controls.Add(this.btn_osszes);
            this.ÉrtesítésekTab.Controls.Add(this.btn_frissit);
            this.ÉrtesítésekTab.Controls.Add(this.lsb_lista);
            this.ÉrtesítésekTab.Controls.Add(this.lbl_üzenetbe);
            this.ÉrtesítésekTab.Location = new System.Drawing.Point(4, 22);
            this.ÉrtesítésekTab.Name = "ÉrtesítésekTab";
            this.ÉrtesítésekTab.Size = new System.Drawing.Size(441, 344);
            this.ÉrtesítésekTab.TabIndex = 4;
            this.ÉrtesítésekTab.Text = "Üzenetek";
            // 
            // btn_torol
            // 
            this.btn_torol.Location = new System.Drawing.Point(8, 313);
            this.btn_torol.Name = "btn_torol";
            this.btn_torol.Size = new System.Drawing.Size(120, 23);
            this.btn_torol.TabIndex = 11;
            this.btn_torol.Text = "Üzenet törlése";
            this.btn_torol.UseVisualStyleBackColor = true;
            // 
            // rtxb_uzenet
            // 
            this.rtxb_uzenet.Enabled = false;
            this.rtxb_uzenet.Location = new System.Drawing.Point(137, 106);
            this.rtxb_uzenet.Name = "rtxb_uzenet";
            this.rtxb_uzenet.Size = new System.Drawing.Size(296, 208);
            this.rtxb_uzenet.TabIndex = 10;
            this.rtxb_uzenet.Text = "";
            // 
            // lbl_üzenet
            // 
            this.lbl_üzenet.AutoSize = true;
            this.lbl_üzenet.Location = new System.Drawing.Point(134, 90);
            this.lbl_üzenet.Name = "lbl_üzenet";
            this.lbl_üzenet.Size = new System.Drawing.Size(44, 13);
            this.lbl_üzenet.TabIndex = 9;
            this.lbl_üzenet.Text = "Üzenet:";
            // 
            // txb_kuldo
            // 
            this.txb_kuldo.Enabled = false;
            this.txb_kuldo.Location = new System.Drawing.Point(134, 67);
            this.txb_kuldo.Name = "txb_kuldo";
            this.txb_kuldo.Size = new System.Drawing.Size(299, 20);
            this.txb_kuldo.TabIndex = 8;
            // 
            // lbl_kuldo
            // 
            this.lbl_kuldo.AutoSize = true;
            this.lbl_kuldo.Location = new System.Drawing.Point(134, 51);
            this.lbl_kuldo.Name = "lbl_kuldo";
            this.lbl_kuldo.Size = new System.Drawing.Size(37, 13);
            this.lbl_kuldo.TabIndex = 7;
            this.lbl_kuldo.Text = "Küldő:";
            // 
            // txb_targy
            // 
            this.txb_targy.Enabled = false;
            this.txb_targy.Location = new System.Drawing.Point(134, 28);
            this.txb_targy.Name = "txb_targy";
            this.txb_targy.Size = new System.Drawing.Size(299, 20);
            this.txb_targy.TabIndex = 6;
            // 
            // lbl_tárgy
            // 
            this.lbl_tárgy.AutoSize = true;
            this.lbl_tárgy.Location = new System.Drawing.Point(134, 12);
            this.lbl_tárgy.Name = "lbl_tárgy";
            this.lbl_tárgy.Size = new System.Drawing.Size(37, 13);
            this.lbl_tárgy.TabIndex = 5;
            this.lbl_tárgy.Text = "Tárgy:";
            // 
            // btn_uj
            // 
            this.btn_uj.Location = new System.Drawing.Point(8, 284);
            this.btn_uj.Name = "btn_uj";
            this.btn_uj.Size = new System.Drawing.Size(120, 23);
            this.btn_uj.TabIndex = 4;
            this.btn_uj.Text = "Csak az újak";
            this.btn_uj.UseVisualStyleBackColor = true;
            this.btn_uj.Click += new System.EventHandler(this.btn_uj_Click);
            // 
            // btn_osszes
            // 
            this.btn_osszes.Location = new System.Drawing.Point(8, 255);
            this.btn_osszes.Name = "btn_osszes";
            this.btn_osszes.Size = new System.Drawing.Size(120, 23);
            this.btn_osszes.TabIndex = 3;
            this.btn_osszes.Text = "Összes üzenet";
            this.btn_osszes.UseVisualStyleBackColor = true;
            this.btn_osszes.Click += new System.EventHandler(this.btn_osszes_Click);
            // 
            // btn_frissit
            // 
            this.btn_frissit.Location = new System.Drawing.Point(8, 226);
            this.btn_frissit.Name = "btn_frissit";
            this.btn_frissit.Size = new System.Drawing.Size(120, 23);
            this.btn_frissit.TabIndex = 2;
            this.btn_frissit.Text = "Frissítés";
            this.btn_frissit.UseVisualStyleBackColor = true;
            this.btn_frissit.Click += new System.EventHandler(this.btn_frissit_Click);
            // 
            // lsb_lista
            // 
            this.lsb_lista.FormattingEnabled = true;
            this.lsb_lista.Location = new System.Drawing.Point(8, 28);
            this.lsb_lista.Name = "lsb_lista";
            this.lsb_lista.Size = new System.Drawing.Size(120, 186);
            this.lsb_lista.TabIndex = 1;
            // 
            // lbl_üzenetbe
            // 
            this.lbl_üzenetbe.AutoSize = true;
            this.lbl_üzenetbe.Location = new System.Drawing.Point(5, 12);
            this.lbl_üzenetbe.Name = "lbl_üzenetbe";
            this.lbl_üzenetbe.Size = new System.Drawing.Size(105, 13);
            this.lbl_üzenetbe.TabIndex = 0;
            this.lbl_üzenetbe.Text = "Beérkezett üzenetek";
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
            this.grb_kerelem.ResumeLayout(false);
            this.grb_kerelem.PerformLayout();
            this.grb_adatok.ResumeLayout(false);
            this.grb_adatok.PerformLayout();
            this.TantárgykezelőTab.ResumeLayout(false);
            this.TantárgykezelőTab.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ÉrtesítésekTab.ResumeLayout(false);
            this.ÉrtesítésekTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabc_hallgato;
        private System.Windows.Forms.TabPage SzemélyiAdatokTab;
        private System.Windows.Forms.TabPage TantárgykezelőTab;
        private System.Windows.Forms.TabPage ÓrarendTab;
        private System.Windows.Forms.TabPage LeckekönyvTab;
        private System.Windows.Forms.TabPage ÉrtesítésekTab;
        private System.Windows.Forms.TextBox txb_személyiIgsz;
        private System.Windows.Forms.TextBox txb_nev;
        private System.Windows.Forms.Label lbl_zeusz;
        private System.Windows.Forms.Label lbl_nev;
        private System.Windows.Forms.GroupBox grb_adatok;
        private System.Windows.Forms.Label lbl_zeusz2;
        private System.Windows.Forms.Label lbl_személyiIgsz;
        private System.Windows.Forms.Label lbl_szuldatum;
        private System.Windows.Forms.TextBox txb_szulhely;
        private System.Windows.Forms.Label lbl_szulhely;
        private System.Windows.Forms.TextBox txb_lakhely;
        private System.Windows.Forms.Label lbl_lakhely;
        private System.Windows.Forms.GroupBox grb_kerelem;
        private System.Windows.Forms.Button btn_kuldes;
        private System.Windows.Forms.Label lbl_statusz2;
        private System.Windows.Forms.Label lbl_statusz;
        private System.Windows.Forms.Button btn_kerelem;
        private System.Windows.Forms.RadioButton rb_kijelentkezes;
        private System.Windows.Forms.RadioButton rb_passziv;
        private System.Windows.Forms.RichTextBox rtxb_uzenet;
        private System.Windows.Forms.Label lbl_üzenet;
        private System.Windows.Forms.TextBox txb_kuldo;
        private System.Windows.Forms.Label lbl_kuldo;
        private System.Windows.Forms.TextBox txb_targy;
        private System.Windows.Forms.Label lbl_tárgy;
        private System.Windows.Forms.Button btn_uj;
        private System.Windows.Forms.Button btn_osszes;
        private System.Windows.Forms.Button btn_frissit;
        private System.Windows.Forms.ListBox lsb_lista;
        private System.Windows.Forms.Label lbl_üzenetbe;
        private System.Windows.Forms.Button btn_torol;
        private System.Windows.Forms.Button btn_leadas;
        private System.Windows.Forms.Button btn_felvetel;
        private System.Windows.Forms.ListBox lsb_felvett;
        private System.Windows.Forms.Label lbl_felvett;
        private System.Windows.Forms.ListBox lsb_felveheto;
        private System.Windows.Forms.Label lbl_felveheto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_kod2;
        private System.Windows.Forms.Label lbl_kod;
        private System.Windows.Forms.TextBox txb_targynev;
        private System.Windows.Forms.Label lbl_targynev;
        private System.Windows.Forms.TextBox txb_terem;
        private System.Windows.Forms.Label lbl_terem;
        private System.Windows.Forms.TextBox txb_kezdes;
        private System.Windows.Forms.Label lbl_kezdes;
        private System.Windows.Forms.TextBox txb_tanar;
        private System.Windows.Forms.Label lbl_felelös;
        private System.Windows.Forms.Label lbl_het;
        private System.Windows.Forms.Label lbl_befejez;
        private System.Windows.Forms.Label lbl_parose;
        private System.Windows.Forms.TextBox txb_befejezes;
        private System.Windows.Forms.TextBox txb_segedlet;
        private System.Windows.Forms.Label lbl_segedlet;
        private System.Windows.Forms.Label lbl_jegy;
        private System.Windows.Forms.Label lbl_követelmeny;
        private System.Windows.Forms.DateTimePicker dtp_szulDatum;
        private System.Windows.Forms.Label lbl_nap2;
        private System.Windows.Forms.Label lbl_nap;
    }
}