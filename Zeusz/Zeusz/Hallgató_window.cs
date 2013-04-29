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
        public Hallgató_window()
        {
            InitializeComponent();
        }

        private void Hallgató_window_Load(object sender, EventArgs e)
        {
            string zeusz = null;
            string név = null;
            string státusz = null;
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
            lbl_zeusz2.Text = zeusz;
            lbl_statusz2.Text = státusz;
        }
    }
}
