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
    public partial class Hallgató_window : Form
    {
        static string zeusz;
        static Adatkezelő adatKezelő = new Adatkezelő();
        static Tantárgykezelő tantárgykezelő = new Tantárgykezelő();
        static Üzenetkezelő üzenetKezelő = new Üzenetkezelő();
        static List<Hallgató> hallgatók = adatKezelő.hallgatóListázás();
        static Hallgató hallgató = belépve();
        static List<Üzenet> üzenetek = null;
        static List<Tantárgy> tantárgyak = null;
        static List<Tantárgy> felvettek = null;

        public Hallgató_window()
        {
            Login_window login = new Login_window();
            zeusz = login.txtb_azonosito.Text;
            InitializeComponent();     
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
                státusz = "aktív";
            else
                státusz = "passzív";
            int magassag_a = Screen.PrimaryScreen.Bounds.Height;
            int szelesseg_a = Screen.PrimaryScreen.Bounds.Width;
            int magassag_b = this.Size.Height / 2;
            int szelesseg_b = this.Size.Width / 2;
            Point kezd = new Point(szelesseg_a / 2 - szelesseg_b, magassag_a / 2 - magassag_b);
            Location = kezd;
            this.Text = "Belépve " + név + " néven.";
            lbl_zeusz2.Text = zeusz;
            lbl_statusz2.Text = státusz;
        }

        static Hallgató belépve()
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
        
        private void ÉrtesítésekTab_Click(object sender, EventArgs e)
        {
            try
            {
                üzenetek = üzenetKezelő.üzenetListázás(hallgató.Zeuszkód, true);
                lsb_lista.DataSource = üzenetek;
            }
            catch
            {
            }
        }

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
                        }
                        catch
                        {
                        }
                        break;
                    }
            }
        }
    }
}
