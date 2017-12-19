namespace SearchExtension
{
    partial class EmailConfigurations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmailConfigurations));
            this.gbmoje = new System.Windows.Forms.GroupBox();
            this.mtbHaslo = new System.Windows.Forms.MaskedTextBox();
            this.tbPodpis = new System.Windows.Forms.TextBox();
            this.tbNazwaKonta = new System.Windows.Forms.TextBox();
            this.lPodpis = new System.Windows.Forms.Label();
            this.lHaslo = new System.Windows.Forms.Label();
            this.lNazwaKonta = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.gbustawienia = new System.Windows.Forms.GroupBox();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.tbSmtp = new System.Windows.Forms.TextBox();
            this.lPort = new System.Windows.Forms.Label();
            this.lSmtp = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bZapisz = new System.Windows.Forms.Button();
            this.gbmoje.SuspendLayout();
            this.gbustawienia.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbmoje
            // 
            this.gbmoje.Controls.Add(this.mtbHaslo);
            this.gbmoje.Controls.Add(this.tbPodpis);
            this.gbmoje.Controls.Add(this.tbNazwaKonta);
            this.gbmoje.Controls.Add(this.lPodpis);
            this.gbmoje.Controls.Add(this.lHaslo);
            this.gbmoje.Controls.Add(this.lNazwaKonta);
            this.gbmoje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.gbmoje.Location = new System.Drawing.Point(5, 25);
            this.gbmoje.Name = "gbmoje";
            this.gbmoje.Size = new System.Drawing.Size(324, 129);
            this.gbmoje.TabIndex = 21;
            this.gbmoje.TabStop = false;
            this.gbmoje.Text = "Konfiguracja adresu e-mail";
            // 
            // mtbHaslo
            // 
            this.mtbHaslo.Location = new System.Drawing.Point(66, 59);
            this.mtbHaslo.Name = "mtbHaslo";
            this.mtbHaslo.PasswordChar = '*';
            this.mtbHaslo.Size = new System.Drawing.Size(252, 23);
            this.mtbHaslo.TabIndex = 6;
            this.mtbHaslo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbPodpis
            // 
            this.tbPodpis.Location = new System.Drawing.Point(66, 97);
            this.tbPodpis.Name = "tbPodpis";
            this.tbPodpis.Size = new System.Drawing.Size(252, 23);
            this.tbPodpis.TabIndex = 5;
            this.tbPodpis.Text = "Your signature";
            this.tbPodpis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbNazwaKonta
            // 
            this.tbNazwaKonta.Location = new System.Drawing.Point(65, 22);
            this.tbNazwaKonta.Name = "tbNazwaKonta";
            this.tbNazwaKonta.Size = new System.Drawing.Size(253, 23);
            this.tbNazwaKonta.TabIndex = 3;
            this.tbNazwaKonta.Text = "xyz@gmail.com";
            this.tbNazwaKonta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lPodpis
            // 
            this.lPodpis.AutoSize = true;
            this.lPodpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lPodpis.Location = new System.Drawing.Point(5, 100);
            this.lPodpis.Name = "lPodpis";
            this.lPodpis.Size = new System.Drawing.Size(55, 17);
            this.lPodpis.TabIndex = 2;
            this.lPodpis.Text = "Podpis:";
            // 
            // lHaslo
            // 
            this.lHaslo.AutoSize = true;
            this.lHaslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lHaslo.Location = new System.Drawing.Point(5, 62);
            this.lHaslo.Name = "lHaslo";
            this.lHaslo.Size = new System.Drawing.Size(48, 17);
            this.lHaslo.TabIndex = 1;
            this.lHaslo.Text = "Hasło:";
            // 
            // lNazwaKonta
            // 
            this.lNazwaKonta.AutoSize = true;
            this.lNazwaKonta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lNazwaKonta.Location = new System.Drawing.Point(5, 25);
            this.lNazwaKonta.Name = "lNazwaKonta";
            this.lNazwaKonta.Size = new System.Drawing.Size(54, 17);
            this.lNazwaKonta.TabIndex = 0;
            this.lNazwaKonta.Text = "Nazwa:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(335, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 53);
            this.button1.TabIndex = 24;
            this.button1.Text = "Test konfiguracji";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // gbustawienia
            // 
            this.gbustawienia.Controls.Add(this.tbPort);
            this.gbustawienia.Controls.Add(this.tbSmtp);
            this.gbustawienia.Controls.Add(this.lPort);
            this.gbustawienia.Controls.Add(this.lSmtp);
            this.gbustawienia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.gbustawienia.Location = new System.Drawing.Point(335, 25);
            this.gbustawienia.Name = "gbustawienia";
            this.gbustawienia.Size = new System.Drawing.Size(194, 73);
            this.gbustawienia.TabIndex = 22;
            this.gbustawienia.TabStop = false;
            this.gbustawienia.Text = "Konfiguracja serwera";
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(56, 44);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(131, 23);
            this.tbPort.TabIndex = 3;
            this.tbPort.Text = "587";
            this.tbPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbSmtp
            // 
            this.tbSmtp.Location = new System.Drawing.Point(56, 17);
            this.tbSmtp.Name = "tbSmtp";
            this.tbSmtp.Size = new System.Drawing.Size(131, 23);
            this.tbSmtp.TabIndex = 2;
            this.tbSmtp.Text = "smtp.gmail.com";
            this.tbSmtp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lPort
            // 
            this.lPort.AutoSize = true;
            this.lPort.Location = new System.Drawing.Point(6, 46);
            this.lPort.Name = "lPort";
            this.lPort.Size = new System.Drawing.Size(38, 17);
            this.lPort.TabIndex = 1;
            this.lPort.Text = "Port:";
            // 
            // lSmtp
            // 
            this.lSmtp.AutoSize = true;
            this.lSmtp.Location = new System.Drawing.Point(6, 20);
            this.lSmtp.Name = "lSmtp";
            this.lSmtp.Size = new System.Drawing.Size(50, 17);
            this.lSmtp.TabIndex = 0;
            this.lSmtp.Text = "SMTP:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(533, 24);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(198, 20);
            this.optionsToolStripMenuItem.Text = "Załaduj konfiguracje poczty gmail";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // bZapisz
            // 
            this.bZapisz.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bZapisz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bZapisz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bZapisz.Location = new System.Drawing.Point(464, 101);
            this.bZapisz.Name = "bZapisz";
            this.bZapisz.Size = new System.Drawing.Size(66, 53);
            this.bZapisz.TabIndex = 23;
            this.bZapisz.UseVisualStyleBackColor = false;
            // 
            // EmailConfigurations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(533, 159);
            this.Controls.Add(this.gbmoje);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gbustawienia);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.bZapisz);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmailConfigurations";
            this.Text = "MD - Konfiguracja konta E-mail nadawcy";
            this.gbmoje.ResumeLayout(false);
            this.gbmoje.PerformLayout();
            this.gbustawienia.ResumeLayout(false);
            this.gbustawienia.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbmoje;
        private System.Windows.Forms.MaskedTextBox mtbHaslo;
        private System.Windows.Forms.TextBox tbPodpis;
        private System.Windows.Forms.TextBox tbNazwaKonta;
        private System.Windows.Forms.Label lPodpis;
        private System.Windows.Forms.Label lHaslo;
        private System.Windows.Forms.Label lNazwaKonta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gbustawienia;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.TextBox tbSmtp;
        private System.Windows.Forms.Label lPort;
        private System.Windows.Forms.Label lSmtp;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.Button bZapisz;
    }
}