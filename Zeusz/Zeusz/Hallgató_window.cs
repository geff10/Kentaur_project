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
        public Hallgató_window()
        {
            Login_window login = new Login_window();
            InitializeComponent();
            zeusz = login.txtb_azonosito.Text;
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
            int magassag_a = Screen.PrimaryScreen.Bounds.Height;
            int szelesseg_a = Screen.PrimaryScreen.Bounds.Width;
            int magassag_b = this.Size.Height / 2;
            int szelesseg_b = this.Size.Width / 2;
            Point kezd = new Point(szelesseg_a / 2 - szelesseg_b, magassag_a / 2 - magassag_b);
            Location = kezd;
            this.Text = "Belépve " + név + " néven.";
            //lbl_zeusz2.Text = zeusz;
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

        static Adatkezelő adatKezelő = new Adatkezelő();
        static Üzenetkezelő üzenetKezelő = new Üzenetkezelő();
        static List<Hallgató> hallgatók = adatKezelő.hallgatóListázás();
        static Hallgató hallgató = belépve();
        //static List<Üzenet> üzenetek = üzenetKezelő.üzenetListázás(hallgató.Zeuszkód, true);
        

        private void ÉrtesítésekTab_Click(object sender, EventArgs e)
        {        
            //lsb_lista.DataSource = üzenetek;
        }

        private void btn_frissit_Click(object sender, EventArgs e)
        {
            //lsb_lista.DataSource = üzenetek;
        }

        private void btn_osszes_Click(object sender, EventArgs e)
        {
            //lsb_lista.DataSource = üzenetek;
        }

        private void btn_uj_Click(object sender, EventArgs e)
        {
            //lsb_lista.DataSource = üzenetek;
        }

        private void lsb_lista_SelectedIndexChanged(object sender, EventArgs e)
        {
            //üzenetek.Find(); 
        }
    }
}
