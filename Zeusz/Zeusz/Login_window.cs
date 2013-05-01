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
            Hallgató_window hallgató_Form = new Hallgató_window();
            hallgató_Form.ShowDialog();
        }

        private void btn_tanar_Click(object sender, EventArgs e)
        {
            Tanár_window tanár_Form = new Tanár_window();
            tanár_Form.ShowDialog();
        }
    }
}
