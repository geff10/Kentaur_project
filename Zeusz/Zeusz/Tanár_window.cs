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
    public partial class Tanár_window : Form
    {
        static Adatkezelő adatKezelő = new Adatkezelő();
        static Kérelemkezelő kérelemKezelő = new Kérelemkezelő();
        static Tantárgykezelő tantárgyKezelő = new Tantárgykezelő();
        static List<Tanár> tanárok = adatKezelő.tanárListázás();
        static List<Tantárgy> tárgyak = tantárgyKezelő.tantárgyListázás();

        public Tanár_window()
        {
            InitializeComponent();
        }

        private void Tanár_window_Load(object sender, EventArgs e)
        {
            string név = null;
            int magassag_a = Screen.PrimaryScreen.Bounds.Height;
            int szelesseg_a = Screen.PrimaryScreen.Bounds.Width;
            int magassag_b = this.Size.Height / 2;
            int szelesseg_b = this.Size.Width / 2;
            Point kezd = new Point(szelesseg_a / 2 - szelesseg_b, magassag_a / 2 - magassag_b);
            Location = kezd;
            cmb_het.SelectedIndex = 0;
            cmb_kovetelmeny.SelectedIndex = 0;
            this.Text = "Belépve " + név + " néven.";
            lsb_tantargyak.DataSource = tárgyak;
            //lsb_tantargyak.SelectedIndex = 0;
        }

        private void btn_targyplusz_Click(object sender, EventArgs e)
        {
            string nev = txb_nev.Text;
            string het = cmb_het.SelectedItem.ToString();
            string terem = txb_terem.Text;
            DateTime kezd = new DateTime(2000,02,02,int.Parse(nud_kora.Value.ToString()),
                int.Parse(nud_kperc.Value.ToString()),30);
            DateTime vege = new DateTime(2000, 02, 02, int.Parse(nud_vora.Value.ToString()),
                int.Parse(nud_vperc.Value.ToString()), 30);
            string kovetelmeny = cmb_kovetelmeny.SelectedItem.ToString();
            string segedlet = txb_segedlet.Text;
            string[] tanár = new string[5];
            for (int i = 0; i < lsb_tanirok.Items.Count; i++)
            {
                tanár[i] = tanárok.Find((Predicate<Tanár>)lsb_tanirok.SelectedItem).Zeuszkód;
            }
            tanár[0] = "toma";
            Tantárgy tárgy = new Tantárgy(nev, terem, kezd, vege, het, tanár, kovetelmeny, segedlet);
            tantárgyKezelő.Tárgyhozzáadás(tárgy);
            tantárgyHozzáadKérelem kérelem = new tantárgyHozzáadKérelem("toma", "új tárgy",
                DateTime.Now, false, tárgy);
            kérelemKezelő.Kérelmezés("újTárgy", kérelem);
            tárgyak = tantárgyKezelő.tantárgyListázás();
            lsb_tantargyak.Invalidate();
        }

        private void btn_modosit_Click(object sender, EventArgs e)
        {
            //Tantárgy valasztott = ;
            string nev = txb_nev.Text;
            string het = cmb_het.SelectedItem.ToString();
            string terem = txb_terem.Text;
            DateTime kezd = new DateTime(0, 0, 0, int.Parse(nud_kora.Value.ToString()),
                int.Parse(nud_kperc.Value.ToString()), 0);
            DateTime vege = new DateTime(0, 0, 0, int.Parse(nud_vora.Value.ToString()),
                int.Parse(nud_vperc.Value.ToString()), 0);
            string kovetelmeny = cmb_kovetelmeny.SelectedItem.ToString();
            string segedlet = txb_segedlet.Text;
            string[] tanár = null;
            for (int i = 0; i < lsb_tanirok.Items.Count; i++)
            {
                tanár[i] = tanárok.Find((Predicate<Tanár>)lsb_tanirok.SelectedItem).Zeuszkód;
            }
            //tanár[0] = "toma";
            Tantárgy tárgy = new Tantárgy(nev, terem, kezd, vege, het, tanár, kovetelmeny, segedlet);
            tantárgyMódKérelem kérelem = new tantárgyMódKérelem("toma", "új tárgy",
                DateTime.Now, false, tárgyak.Find((Predicate<Tantárgy>)lsb_tantargyak.SelectedItem).ToString(), tárgy);
            kérelemKezelő.Kérelmezés("újTárgy", kérelem);
        }

        private void lsb_tantargyak_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tantárgy tárgy = tárgyak.Find((Predicate<Tantárgy>)lsb_tantargyak.SelectedItem);
            lbl_kod2.Text = tárgy.Tárgykód;
            txb_nev.Text = tárgy.Tárgynév;
            cmb_het.SelectedItem = cmb_het.FindString(tárgy.Hét);
            txb_terem.Text = tárgy.Helyszín;
            txb_segedlet.Text = tárgy.Segédletek;
            cmb_kovetelmeny.SelectedItem = cmb_kovetelmeny.FindString(tárgy.Követelmények);
            nud_kora.Value = tárgy.KezdésIdőpont.Hour;
            nud_kperc.Value = tárgy.KezdésIdőpont.Minute;
            nud_vora.Value = tárgy.VégeIdőpont.Hour;
            nud_vperc.Value = tárgy.VégeIdőpont.Minute;
            string[] tanarok = new string[5];
        }
    }
}
