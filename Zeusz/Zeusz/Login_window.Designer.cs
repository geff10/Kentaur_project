namespace Zeusz
{
    partial class Login_window
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
            this.lbl_azonosito = new System.Windows.Forms.Label();
            this.txtb_azonosito = new System.Windows.Forms.TextBox();
            this.lbl_jelszo = new System.Windows.Forms.Label();
            this.txtb_jelszo = new System.Windows.Forms.TextBox();
            this.btn_belepes = new System.Windows.Forms.Button();
            this.btn_hallgato = new System.Windows.Forms.Button();
            this.btn_tanar = new System.Windows.Forms.Button();
            this.btn_vezeto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_azonosito
            // 
            this.lbl_azonosito.AutoSize = true;
            this.lbl_azonosito.Location = new System.Drawing.Point(12, 9);
            this.lbl_azonosito.Name = "lbl_azonosito";
            this.lbl_azonosito.Size = new System.Drawing.Size(100, 13);
            this.lbl_azonosito.TabIndex = 0;
            this.lbl_azonosito.Text = "Belépési azonosító:";
            // 
            // txtb_azonosito
            // 
            this.txtb_azonosito.Location = new System.Drawing.Point(15, 25);
            this.txtb_azonosito.Name = "txtb_azonosito";
            this.txtb_azonosito.Size = new System.Drawing.Size(177, 20);
            this.txtb_azonosito.TabIndex = 1;
            // 
            // lbl_jelszo
            // 
            this.lbl_jelszo.AutoSize = true;
            this.lbl_jelszo.Location = new System.Drawing.Point(12, 48);
            this.lbl_jelszo.Name = "lbl_jelszo";
            this.lbl_jelszo.Size = new System.Drawing.Size(39, 13);
            this.lbl_jelszo.TabIndex = 2;
            this.lbl_jelszo.Text = "Jelszó:";
            // 
            // txtb_jelszo
            // 
            this.txtb_jelszo.Location = new System.Drawing.Point(15, 64);
            this.txtb_jelszo.Name = "txtb_jelszo";
            this.txtb_jelszo.PasswordChar = '*';
            this.txtb_jelszo.Size = new System.Drawing.Size(177, 20);
            this.txtb_jelszo.TabIndex = 3;
            // 
            // btn_belepes
            // 
            this.btn_belepes.Location = new System.Drawing.Point(15, 90);
            this.btn_belepes.Name = "btn_belepes";
            this.btn_belepes.Size = new System.Drawing.Size(75, 23);
            this.btn_belepes.TabIndex = 4;
            this.btn_belepes.Text = "Belépés";
            this.btn_belepes.UseVisualStyleBackColor = true;
            // 
            // btn_hallgato
            // 
            this.btn_hallgato.Location = new System.Drawing.Point(96, 90);
            this.btn_hallgato.Name = "btn_hallgato";
            this.btn_hallgato.Size = new System.Drawing.Size(97, 23);
            this.btn_hallgato.TabIndex = 5;
            this.btn_hallgato.Text = "Teszt hallgató";
            this.btn_hallgato.UseVisualStyleBackColor = true;
            this.btn_hallgato.Click += new System.EventHandler(this.btn_hallgato_Click);
            // 
            // btn_tanar
            // 
            this.btn_tanar.Location = new System.Drawing.Point(15, 119);
            this.btn_tanar.Name = "btn_tanar";
            this.btn_tanar.Size = new System.Drawing.Size(75, 23);
            this.btn_tanar.TabIndex = 6;
            this.btn_tanar.Text = "Teszt tanár";
            this.btn_tanar.UseVisualStyleBackColor = true;
            // 
            // btn_vezeto
            // 
            this.btn_vezeto.Location = new System.Drawing.Point(96, 119);
            this.btn_vezeto.Name = "btn_vezeto";
            this.btn_vezeto.Size = new System.Drawing.Size(96, 23);
            this.btn_vezeto.TabIndex = 7;
            this.btn_vezeto.Text = "Teszt vezető";
            this.btn_vezeto.UseVisualStyleBackColor = true;
            // 
            // Login_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(202, 160);
            this.Controls.Add(this.btn_vezeto);
            this.Controls.Add(this.btn_tanar);
            this.Controls.Add(this.btn_hallgato);
            this.Controls.Add(this.btn_belepes);
            this.Controls.Add(this.txtb_jelszo);
            this.Controls.Add(this.lbl_jelszo);
            this.Controls.Add(this.txtb_azonosito);
            this.Controls.Add(this.lbl_azonosito);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Login_window";
            this.Text = "Belépés";
            this.Load += new System.EventHandler(this.Login_window_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_azonosito;
        private System.Windows.Forms.Label lbl_jelszo;
        private System.Windows.Forms.TextBox txtb_jelszo;
        private System.Windows.Forms.Button btn_belepes;
        private System.Windows.Forms.Button btn_hallgato;
        private System.Windows.Forms.Button btn_tanar;
        private System.Windows.Forms.Button btn_vezeto;
        public System.Windows.Forms.TextBox txtb_azonosito;
    }
}

