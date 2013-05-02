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
        static Kérelemkezelő kérelemKezelő = new Kérelemkezelő();
        static List<Kérelem> kérelmek;
        static Kérelem kérelem;
        
        public Vezető_window(Vezető belépő)
        {
            InitializeComponent();
            tbc_vezeto.SelectedIndex = 0;
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
            int magassag_a = Screen.PrimaryScreen.Bounds.Height;
            int szelesseg_a = Screen.PrimaryScreen.Bounds.Width;
            int magassag_b = this.Size.Height / 2;
            int szelesseg_b = this.Size.Width / 2;
            Point kezd = new Point(szelesseg_a / 2 - szelesseg_b, magassag_a / 2 - magassag_b);
            Location = kezd;
            cmb_tipus.SelectedIndex = 0;
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
                            break;
                        }
                    case 1:
                        {
                            Tanár tanár = new Tanár("", txb_nev.Text, txb_lakhely.Text, txb_szig.Text,
                                dtp_szulido.Value, txb_szulhely.Text,txb_beosztas.Text);
                            adatKezelő.tanárFelvétel(tanár);
                            break;
                        }
                    case 2:
                        {
                            Hallgató hallgató = new Hallgató("", txb_nev.Text, txb_lakhely.Text, txb_szig.Text,
                                dtp_szulido.Value, txb_szulhely.Text,true,false);
                            adatKezelő.hallgatóFelvétel(hallgató);
                            break;
                        }
                }
            }
            catch
            { }
        }
    }
}
