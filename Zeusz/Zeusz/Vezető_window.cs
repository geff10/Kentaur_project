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
    public partial class Vezető_window : Form
    {
        static Adatkezelő adatKezelő = new Adatkezelő();
        static Vezető belépve;
        
        public Vezető_window(Vezető belépő)
        {
            InitializeComponent();
            tbc_vezeto.SelectedIndex = 0;
            belépve = belépő;
        }

        private void tbc_vezeto_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tbc_vezeto.SelectedIndex)
            {
                case 1:
                    {
                        break;
                    }
            }
        }

        private void Vezető_window_Load(object sender, EventArgs e)
        {
            string név = belépve.Név;
            int magassag_a = Screen.PrimaryScreen.Bounds.Height;
            int szelesseg_a = Screen.PrimaryScreen.Bounds.Width;
            int magassag_b = this.Size.Height / 2;
            int szelesseg_b = this.Size.Width / 2;
            Point kezd = new Point(szelesseg_a / 2 - szelesseg_b, magassag_a / 2 - magassag_b);
            Location = kezd;
            cmb_tipus.SelectedIndex = 0;
            this.Text = "Belépve " + név + " néven.";


            //létező személyek listázása
            List<Vezető> vezetok = adatKezelő.vezetőListázás();
            List<Tanár> tanarok = adatKezelő.tanárListázás();
            List<Hallgató> hallgatok = adatKezelő.hallgatóListázás();

            foreach (var item in vezetok)
            {
                lsb_felhazsnalok.Items.Add(item.Név + " (vezető)");
            }

            foreach (var item in tanarok)
            {
                lsb_felhazsnalok.Items.Add(item.Név + " (tanár)");
            }

            foreach (var item in hallgatok)
            {
                lsb_felhazsnalok.Items.Add(item.Név + " (hallgató)");
            }
        }

        private void btn_felvetel_Click(object sender, EventArgs e)
        {
            try
            {
                switch (cmb_tipus.SelectedIndex)
                {
                    case 0:
                        {
                            Vezető vezető = new Vezető("", txb_nev.Text, txb_lakhely.Text, txb_szig.Text,
                                dtp_szulido.Value, txb_szulhely.Text);
                            adatKezelő.vezetőFelvétel(vezető);
                            lsb_felhazsnalok.Items.Add(vezető.Név + " (vezető)");
                            break;
                        }
                    case 1:
                        {
                            Tanár tanár = new Tanár("", txb_nev.Text, txb_lakhely.Text, txb_szig.Text,
                                dtp_szulido.Value, txb_szulhely.Text, txb_beosztas.Text);
                            adatKezelő.tanárFelvétel(tanár);
                            lsb_felhazsnalok.Items.Add(tanár.Név + " (tanár)");
                            break;
                        }
                    case 2:
                        {
                            Hallgató hallgató = new Hallgató("", txb_nev.Text, txb_lakhely.Text, txb_szig.Text,
                                dtp_szulido.Value, txb_szulhely.Text, true, false);
                            adatKezelő.hallgatóFelvétel(hallgató);
                            lsb_felhazsnalok.Items.Add(hallgató.Név + " (hallgató)");
                            break;
                        }
                }
            }
            catch
            {
                MessageBox.Show("A beírt adatok nem megfelelőek");
            }
            finally
            {
                txb_beosztas.Text = "";
                txb_lakhely.Text = "";
                txb_nev.Text = "";
                txb_szig.Text = "";
                txb_szulhely.Text = "";
                cmb_tipus.SelectedIndex = 0;
                dtp_szulido.Value = DateTime.Now;

                //listbox frissítése
                lsb_felhazsnalok.Refresh();
            }
        }

        private void cmb_tipus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_tipus.SelectedItem != "Tanár")
            {
                groupBox1.Visible = false;
            }
            else
            {
                groupBox1.Visible = true;
            }
        }
    }
}
