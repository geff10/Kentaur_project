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
    public partial class Login_window : Form
    {
        public Login_window()
        {
            InitializeComponent();
        }

        private void Login_window_Load(object sender, EventArgs e)
        {
            int magassag_a = Screen.PrimaryScreen.Bounds.Height;
            int szelesseg_a = Screen.PrimaryScreen.Bounds.Width;
            int magassag_b = this.Size.Height / 2;
            int szelesseg_b = this.Size.Width / 2;
            Point kezd = new Point(szelesseg_a / 2 - szelesseg_b, magassag_a/2-magassag_b);
            Location = kezd;
        }

        private void btn_hallgato_Click(object sender, EventArgs e)
        {
            //Hallgató_window hallgató_Form = new Hallgató_window();
            Adatkezelő adatKezelő = new Adatkezelő();
            List<Hallgató> hallgatok = adatKezelő.hallgatóListázás();
            Hallgató_window hallgató_Form;
            foreach (Hallgató h in hallgatok)
            {
                if (h.Zeuszkód == txtb_azonosito.Text)
                {
                    Hallgató belépő = h;
                    hallgató_Form = new Hallgató_window(belépő);
                    hallgató_Form.ShowDialog();
                }
            }        
        }

        private void btn_tanar_Click(object sender, EventArgs e)
        {
            /*Tanár_window tanár_Form = new Tanár_window(belépő);
            tanár_Form.ShowDialog();*/
        }

        private void btn_belepes_Click(object sender, EventArgs e)
        {
            BejelenktkezésKezelő bejelentkezésKezelő = new BejelenktkezésKezelő();
            bejelentkezésKezelő.Beléptetés(txtb_azonosito.Text, txtb_jelszo.Text);
        }

        private void btn_belepes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

            }
        }




    }
}
