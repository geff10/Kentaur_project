﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Zeusz
{
    public partial class Hallgató_window : Form
    {
        static string zeusz;
        static Adatkezelő adatKezelő = new Adatkezelő();
        static Tantárgykezelő tantárgykezelő = new Tantárgykezelő();
        static Kérelemkezelő kérelemKezelő = new Kérelemkezelő();
        static Üzenetkezelő üzenetKezelő = new Üzenetkezelő();
        static List<Hallgató> hallgatók = adatKezelő.hallgatóListázás();
        static Hallgató hallgató;// = belépve();
        static List<Üzenet> üzenetek = null;
        static List<Tantárgy> tantárgyak = null;
        static List<Tantárgy> felvettek = null;
        //public Hallgató belépő;

        public Hallgató_window(Hallgató belépő)
        {
            Login_window login = new Login_window();
            zeusz = login.txtb_azonosito.Text;
            InitializeComponent();
            hallgató = belépő;
            zeusz = hallgató.Zeuszkód;
        }

        

        private void Hallgató_window_Load(object sender, EventArgs e)
        {
            
            string név = null;
            string státusz = null;
            //megírni a belépett hallgatót
            /*
             ide írd meg, hogy megkapja a név változóba a hallgató nevét
             kéne a zeusz vltozóba a hallgató zeusz kódja is
             szintén a státusz is kéne
             */
            név = hallgató.Név;
            if (hallgató.Aktiv)
            { 
                státusz = "aktív";
                rb_passziv.Enabled = true;
            }
            else
            {
                státusz = "passzív";
                rb_passziv.Enabled = false;
            }
            int magassag_a = Screen.PrimaryScreen.Bounds.Height;
            int szelesseg_a = Screen.PrimaryScreen.Bounds.Width;
            int magassag_b = this.Size.Height / 2;
            int szelesseg_b = this.Size.Width / 2;
            Point kezd = new Point(szelesseg_a / 2 - szelesseg_b, magassag_a / 2 - magassag_b);
            Location = kezd;
            this.Text = "Belépve " + név + " néven.";
            lbl_zeusz2.Text = zeusz;
            lbl_statusz2.Text = státusz;
            txb_nev.Text = hallgató.Név;
            txb_személyiIgsz.Text = hallgató.SzemélyIgsz;
            txb_lakhely.Text = hallgató.Lakhely;
            txb_szulhely.Text = hallgató.SzületésiHely;
            dtp_szulDatum.Value = hallgató.SzületésiDátum;
        }

        /*static Hallgató belépve()
        {
            Hallgató bent = null;
            foreach (Hallgató h in hallgatók)
            {
                if (h.Zeuszkód == zeusz)
                {
                    bent = h;
                }
            }
            return bent;
        }
        */

        private void btn_frissit_Click(object sender, EventArgs e)
        {
            try
            {
                lsb_lista.Items.Clear();
                üzenetek = üzenetKezelő.üzenetListázás(hallgató.Zeuszkód, true);
                lsb_lista.DataSource = üzenetek;
                btn_osszes.Enabled = false;
                btn_uj.Enabled = true;
                btn_torol.Enabled = false;
            }
            catch
            {
                lsb_lista.Items.Clear();
                lsb_lista.Items.Add("Nincs beérkezett üzenet");
                btn_osszes.Enabled = false;
                btn_uj.Enabled = false;
                btn_torol.Enabled = false;
            }
        }

        private void btn_osszes_Click(object sender, EventArgs e)
        {
            try
            {
                lsb_lista.Items.Clear();
                üzenetek = üzenetKezelő.üzenetListázás(hallgató.Zeuszkód, true);
                lsb_lista.DataSource = üzenetek;
                btn_osszes.Enabled = false;
                btn_uj.Enabled = true;
                btn_torol.Enabled = false;
            }
            catch
            {
                lsb_lista.Items.Clear();
                lsb_lista.Items.Add("Nincs beérkezett üzenet");
                btn_osszes.Enabled = false;
                btn_uj.Enabled = false;
                btn_torol.Enabled = false;
            }
        }

        private void btn_uj_Click(object sender, EventArgs e)
        {
            try
            {
                lsb_lista.Items.Clear();
                üzenetek = üzenetKezelő.üzenetListázás(hallgató.Zeuszkód, false);
                lsb_lista.DataSource = üzenetek;
                btn_osszes.Enabled = true;
                btn_uj.Enabled = false;
                btn_torol.Enabled = false;
            }
            catch
            {
                lsb_lista.Items.Clear();
                lsb_lista.Items.Add("Nincs új üzenet");
                btn_osszes.Enabled = false;
                btn_uj.Enabled = false;
                btn_torol.Enabled = false;
            }
        }

        private void tabc_hallgato_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabc_hallgato.SelectedIndex)
            {
                case 1:
                    {
                        try
                        {
                            lsb_felveheto.Items.Clear();
                            tantárgyak = tantárgykezelő.tantárgyListázás();
                            if (tantárgyak.First() == null)
                            {
                                lsb_felveheto.Items.Add("Nincs felvehető");
                            }
                            else
                            {
                                lsb_felveheto.DataSource = tantárgyak;
                            }

                        }
                        catch
                        {
                            lsb_felveheto.Items.Clear();
                            lsb_felveheto.Items.Add("Nincs felvehető");
                        }
                        try
                        {
                            lsb_felvett.Items.Clear();
                            felvettek = hallgató.FelvettTárgyak;
                            if (felvettek.First() == null)
                            {
                                lsb_felvett.Items.Add("Nincs felvett");
                            }
                            else
                            {
                                lsb_felvett.DataSource = tantárgyak;
                            }
                        }
                        catch
                        {
                            lsb_felvett.Items.Clear();
                            lsb_felvett.Items.Add("Nincs felvett");
                        }
                        break;
                    }
                case 4:
                    {
                        try
                        {
                            üzenetek = üzenetKezelő.üzenetListázás(hallgató.Zeuszkód, true);
                            lsb_lista.DataSource = üzenetek;
                        }
                        catch
                        {
                        }
                        break;
                    }
            }
        }

        private void btn_kuldes_Click(object sender, EventArgs e)
        {
            bool aktiv;
            if (lbl_statusz2.Text == "aktív")
                aktiv = true;
            else
                aktiv = false;
            Hallgató uj = new Hallgató(lbl_zeusz2.Text, txb_nev.Text, txb_lakhely.Text, txb_személyiIgsz.Text,
                dtp_szulDatum.Value, txb_szulhely.Text, aktiv, hallgató.Végzett);
            hallgMódKérelem kérelemmod = new hallgMódKérelem(hallgató.Zeuszkód,"Adatok módosítása",DateTime.Now,
                false, uj);
            kérelemKezelő.Kérelmezés("hallgatómód", kérelemmod);
        }

        private void btn_kerelem_Click(object sender, EventArgs e)
        {
            if (rb_passziv.Checked)
            {
                Kérelem passzív = new Kérelem(hallgató.Zeuszkód, "Passzív kérelem", DateTime.Now, false);
                kérelemKezelő.Kérelmezés("passzív", passzív);
            }
            else
            {
                Kérelem kijelentkezesi = new Kérelem(hallgató.Zeuszkód, "Passzív kérelem", DateTime.Now, true);
                kérelemKezelő.Kérelmezés("kijelentkezési", kijelentkezesi);
            }
        }
    }
}
