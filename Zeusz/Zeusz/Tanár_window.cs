using System;
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

        public Tanár_window(Tanár belépő)
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
            //lsb_tantargyak.DataSource = tárgyak;
            foreach (Tanár t in tanárok)
            {
                lsb_oktatok.Items.Add(t.Zeuszkód);// + "      " + t.Név);
            }
            //lsb_oktatok.DataSource = tanárok;
            //lsb_tantargyak.SelectedIndex = 0;
        }

        private void btn_targyplusz_Click(object sender, EventArgs e)
        {
            string nev = txb_nev.Text;
            string het = cmb_het.SelectedItem.ToString();
            string terem = txb_terem.Text;
            int kezdo = (int)nud_kora.Value;
            int kezdp = (int)nud_kperc.Value;
            int vego = (int)nud_vora.Value;
            int vegp = (int)nud_vperc.Value;
            string nap = cmb_nap.SelectedItem.ToString();
            string kovetelmeny = cmb_kovetelmeny.SelectedItem.ToString();
            string segedlet = txb_segedlet.Text;
            string[] tanár = new string[5];
            for (int i = 0; i < lsb_tanarok.Items.Count; i++)
            {
                tanár[i] = lsb_tanarok.Items[i].ToString();//tanárok.Find((Predicate<Tanár>)lsb_tanarok.SelectedItem).Zeuszkód;
            }
            //tanár[0] = "toma";
            Tantárgy tárgy = new Tantárgy(nev, terem, kezdo, kezdp, vego, vegp,
                nap, het, tanár, kovetelmeny, segedlet);
            tantárgyKezelő.Tárgyhozzáadás(tárgy);
            tantárgyHozzáadKérelem kérelem = new tantárgyHozzáadKérelem("toma", "új tárgy",
                DateTime.Now, false, tárgy);
            kérelemKezelő.Kérelmezés("újTárgy", kérelem);
            tárgyak = tantárgyKezelő.tantárgyListázás();
            lsb_tantargyak.Invalidate();
        }

        private void btn_modosit_Click(object sender, EventArgs e)
        {
            if (lsb_tantargyak.SelectedIndex != -1)
            {
                Tantárgy valasztott = tárgyak.Find((Predicate<Tantárgy>)lsb_tantargyak.SelectedItem); ;
                string nev = txb_nev.Text;
                string het = cmb_het.SelectedItem.ToString();
                string terem = txb_terem.Text;
                int kezdo = (int)nud_kora.Value;
                int kezdp = (int)nud_kperc.Value;
                int vego = (int)nud_vora.Value;
                int vegp = (int)nud_vperc.Value;
                string nap = cmb_nap.SelectedItem.ToString();
                string kovetelmeny = cmb_kovetelmeny.SelectedItem.ToString();
                string segedlet = txb_segedlet.Text;
                string[] tanár = null;
                for (int i = 0; i < lsb_tanarok.Items.Count; i++)
                {
                    tanár[i] = tanárok.Find((Predicate<Tanár>)lsb_tanarok.SelectedItem).Zeuszkód;
                }
                //tanár[0] = "toma";
                Tantárgy tárgy = new Tantárgy(nev, terem, kezdo, kezdp, vego, vegp,
                    nap, het, tanár, kovetelmeny, segedlet);
                tantárgyMódKérelem kérelem = new tantárgyMódKérelem("toma", "új tárgy",
                    DateTime.Now, false, tárgyak.Find((Predicate<Tantárgy>)lsb_tantargyak.SelectedItem).ToString(), tárgy);
                kérelemKezelő.Kérelmezés("újTárgy", kérelem);
                lsb_tantargyak.Invalidate();
            }
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
            cmb_nap.SelectedItem = cmb_nap.FindString(tárgy.Hétnapja);
            nud_kora.Value = tárgy.KezdésIdőpont.Hour;
            nud_kperc.Value = tárgy.KezdésIdőpont.Minute;
            nud_vora.Value = tárgy.VégeIdőpont.Hour;
            nud_vperc.Value = tárgy.VégeIdőpont.Minute;
            string[] tanarok = tárgy.Oktatók;
            for (int i = 0; i < tanarok.Length; i++)
            {
                lsb_tanarok.Items.Add(tanarok[i]);
            }
        }

        private void btn_hozzaad_Click(object sender, EventArgs e)
        {
            if (lsb_oktatok.SelectedIndex != -1)
            {
                lsb_tanarok.Items.Add(lsb_oktatok.SelectedItem);
                lsb_tanarok.Invalidate();
            }
        }

        private void btn_töröl_Click(object sender, EventArgs e)
        {
            if (lsb_tanarok.SelectedIndex != -1)
            {
                lsb_tanarok.Items.Remove(lsb_tanarok.SelectedItem);
                lsb_tanarok.Invalidate();
            }
        }

        private void btn_targytorol_Click(object sender, EventArgs e)
        {
            if (lsb_tantargyak.SelectedIndex != -1)
            {
                Tantárgy törlendő = tárgyak.Find((Predicate<Tantárgy>)lsb_tantargyak.SelectedItem);
                tantárgyKezelő.Tárgytörlés(törlendő);
                lsb_tantargyak.Invalidate();
            }
        }

        private void nud_kora_ValueChanged(object sender, EventArgs e)
        {
            nud_vora.Minimum = nud_kora.Value;
            if (nud_kora.Value < nud_vora.Value)
            {
                nud_vperc.Minimum = 0;
            }
            else
            {
                nud_vperc.Minimum = nud_kperc.Value;
            }
        }

        private void nud_kperc_ValueChanged(object sender, EventArgs e)
        {
            if (nud_kora.Value < nud_vora.Value)
            {
                nud_vperc.Minimum = 0;
            }
            else
            {
                nud_vperc.Minimum = nud_kperc.Value;
            }
        }
    }
}
