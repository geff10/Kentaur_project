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
        static Kérelemkezelő kérelemKezelő = new Kérelemkezelő();
        static List<Kérelem> kérelmek = kérelemKezelő.kérelemListázás();
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
                case 0:
                    {
                        foreach (Kérelem k in kérelmek)
                        {
                            lsb_kerelmek.Items.Add(k.KérelemAzonosító);
                        }
                        break;
                    }
            }
        }
    }
}
