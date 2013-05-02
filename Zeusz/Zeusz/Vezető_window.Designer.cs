namespace Zeusz
{
    partial class Vezető_window
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbc_vezeto = new System.Windows.Forms.TabControl();
            this.SajátAdatTab = new System.Windows.Forms.TabPage();
            this.AdatokTab = new System.Windows.Forms.TabPage();
            this.KérelmekTab = new System.Windows.Forms.TabPage();
            this.ÜzenetekTab = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_kérelmek = new System.Windows.Forms.Label();
            this.lsb_kerelmek = new System.Windows.Forms.ListBox();
            this.tbc_vezeto.SuspendLayout();
            this.KérelmekTab.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbc_vezeto
            // 
            this.tbc_vezeto.Controls.Add(this.SajátAdatTab);
            this.tbc_vezeto.Controls.Add(this.AdatokTab);
            this.tbc_vezeto.Controls.Add(this.KérelmekTab);
            this.tbc_vezeto.Controls.Add(this.ÜzenetekTab);
            this.tbc_vezeto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbc_vezeto.Location = new System.Drawing.Point(0, 0);
            this.tbc_vezeto.Name = "tbc_vezeto";
            this.tbc_vezeto.SelectedIndex = 0;
            this.tbc_vezeto.Size = new System.Drawing.Size(546, 377);
            this.tbc_vezeto.TabIndex = 0;
            this.tbc_vezeto.SelectedIndexChanged += new System.EventHandler(this.tbc_vezeto_SelectedIndexChanged);
            // 
            // SajátAdatTab
            // 
            this.SajátAdatTab.BackColor = System.Drawing.SystemColors.Control;
            this.SajátAdatTab.Location = new System.Drawing.Point(4, 22);
            this.SajátAdatTab.Name = "SajátAdatTab";
            this.SajátAdatTab.Padding = new System.Windows.Forms.Padding(3);
            this.SajátAdatTab.Size = new System.Drawing.Size(538, 287);
            this.SajátAdatTab.TabIndex = 0;
            this.SajátAdatTab.Text = "Saját adatok";
            // 
            // AdatokTab
            // 
            this.AdatokTab.BackColor = System.Drawing.SystemColors.Control;
            this.AdatokTab.Location = new System.Drawing.Point(4, 22);
            this.AdatokTab.Name = "AdatokTab";
            this.AdatokTab.Padding = new System.Windows.Forms.Padding(3);
            this.AdatokTab.Size = new System.Drawing.Size(276, 236);
            this.AdatokTab.TabIndex = 1;
            this.AdatokTab.Text = "Felhasználók kezelése";
            // 
            // KérelmekTab
            // 
            this.KérelmekTab.BackColor = System.Drawing.SystemColors.Control;
            this.KérelmekTab.Controls.Add(this.panel1);
            this.KérelmekTab.Location = new System.Drawing.Point(4, 22);
            this.KérelmekTab.Name = "KérelmekTab";
            this.KérelmekTab.Size = new System.Drawing.Size(538, 351);
            this.KérelmekTab.TabIndex = 2;
            this.KérelmekTab.Text = "Kérelmek kezelése";
            // 
            // ÜzenetekTab
            // 
            this.ÜzenetekTab.BackColor = System.Drawing.SystemColors.Control;
            this.ÜzenetekTab.Location = new System.Drawing.Point(4, 22);
            this.ÜzenetekTab.Name = "ÜzenetekTab";
            this.ÜzenetekTab.Size = new System.Drawing.Size(276, 236);
            this.ÜzenetekTab.TabIndex = 3;
            this.ÜzenetekTab.Text = "Üzenetek";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lsb_kerelmek);
            this.panel1.Controls.Add(this.lbl_kérelmek);
            this.panel1.Location = new System.Drawing.Point(8, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(147, 345);
            this.panel1.TabIndex = 0;
            // 
            // lbl_kérelmek
            // 
            this.lbl_kérelmek.AutoSize = true;
            this.lbl_kérelmek.Location = new System.Drawing.Point(3, 9);
            this.lbl_kérelmek.Name = "lbl_kérelmek";
            this.lbl_kérelmek.Size = new System.Drawing.Size(136, 13);
            this.lbl_kérelmek.TabIndex = 0;
            this.lbl_kérelmek.Text = "Beérkezett kérelmek listája:";
            // 
            // lsb_kerelmek
            // 
            this.lsb_kerelmek.FormattingEnabled = true;
            this.lsb_kerelmek.Location = new System.Drawing.Point(6, 25);
            this.lsb_kerelmek.Name = "lsb_kerelmek";
            this.lsb_kerelmek.Size = new System.Drawing.Size(133, 303);
            this.lsb_kerelmek.TabIndex = 1;
            // 
            // Vezető_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 377);
            this.Controls.Add(this.tbc_vezeto);
            this.Name = "Vezető_window";
            this.Text = "Vezető_window";
            this.tbc_vezeto.ResumeLayout(false);
            this.KérelmekTab.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbc_vezeto;
        private System.Windows.Forms.TabPage SajátAdatTab;
        private System.Windows.Forms.TabPage AdatokTab;
        private System.Windows.Forms.TabPage KérelmekTab;
        private System.Windows.Forms.TabPage ÜzenetekTab;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lsb_kerelmek;
        private System.Windows.Forms.Label lbl_kérelmek;
    }
}