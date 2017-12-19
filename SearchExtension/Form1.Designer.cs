namespace SearchExtension
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tBPath = new System.Windows.Forms.TextBox();
            this.bLoadPath = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lczas = new System.Windows.Forms.Label();
            this.cbWybranaOpcjaSprawdzania = new System.Windows.Forms.ComboBox();
            this.lMinuty = new System.Windows.Forms.Label();
            this.lWykonujCo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nUDCoIleMinut = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.cBSekunda = new System.Windows.Forms.ComboBox();
            this.cBGodzina = new System.Windows.Forms.ComboBox();
            this.cBMinuta = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.bEditEmail = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.bDeleteRecords = new System.Windows.Forms.Button();
            this.tBEditEmail = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.konfiguracjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.konfiguracjaKontaEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaEmailOdbiorcówToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacjaOAutorzeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grafikaUżytaWProjekcieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDCoIleMinut)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.tBPath);
            this.groupBox1.Controls.Add(this.bLoadPath);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            resources.ApplyResources(this.listBox1, "listBox1");
            this.listBox1.Name = "listBox1";
            // 
            // tBPath
            // 
            resources.ApplyResources(this.tBPath, "tBPath");
            this.tBPath.Name = "tBPath";
            // 
            // bLoadPath
            // 
            this.bLoadPath.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            resources.ApplyResources(this.bLoadPath, "bLoadPath");
            this.bLoadPath.Name = "bLoadPath";
            this.bLoadPath.UseVisualStyleBackColor = false;
            this.bLoadPath.Click += new System.EventHandler(this.bLoadPath_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.cbWybranaOpcjaSprawdzania);
            this.groupBox3.Controls.Add(this.lMinuty);
            this.groupBox3.Controls.Add(this.lWykonujCo);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.nUDCoIleMinut);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.cBSekunda);
            this.groupBox3.Controls.Add(this.cBGodzina);
            this.groupBox3.Controls.Add(this.cBMinuta);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lczas);
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // lczas
            // 
            resources.ApplyResources(this.lczas, "lczas");
            this.lczas.Name = "lczas";
            // 
            // cbWybranaOpcjaSprawdzania
            // 
            this.cbWybranaOpcjaSprawdzania.FormattingEnabled = true;
            this.cbWybranaOpcjaSprawdzania.Items.AddRange(new object[] {
            resources.GetString("cbWybranaOpcjaSprawdzania.Items"),
            resources.GetString("cbWybranaOpcjaSprawdzania.Items1")});
            resources.ApplyResources(this.cbWybranaOpcjaSprawdzania, "cbWybranaOpcjaSprawdzania");
            this.cbWybranaOpcjaSprawdzania.Name = "cbWybranaOpcjaSprawdzania";
            this.cbWybranaOpcjaSprawdzania.SelectedIndexChanged += new System.EventHandler(this.cbWybranaOpcjaSprawdzania_SelectedIndexChanged);
            // 
            // lMinuty
            // 
            resources.ApplyResources(this.lMinuty, "lMinuty");
            this.lMinuty.Name = "lMinuty";
            // 
            // lWykonujCo
            // 
            resources.ApplyResources(this.lWykonujCo, "lWykonujCo");
            this.lWykonujCo.Name = "lWykonujCo";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // nUDCoIleMinut
            // 
            resources.ApplyResources(this.nUDCoIleMinut, "nUDCoIleMinut");
            this.nUDCoIleMinut.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nUDCoIleMinut.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUDCoIleMinut.Name = "nUDCoIleMinut";
            this.nUDCoIleMinut.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // cBSekunda
            // 
            this.cBSekunda.DropDownHeight = 290;
            resources.ApplyResources(this.cBSekunda, "cBSekunda");
            this.cBSekunda.FormattingEnabled = true;
            this.cBSekunda.Items.AddRange(new object[] {
            resources.GetString("cBSekunda.Items"),
            resources.GetString("cBSekunda.Items1"),
            resources.GetString("cBSekunda.Items2"),
            resources.GetString("cBSekunda.Items3"),
            resources.GetString("cBSekunda.Items4"),
            resources.GetString("cBSekunda.Items5"),
            resources.GetString("cBSekunda.Items6"),
            resources.GetString("cBSekunda.Items7"),
            resources.GetString("cBSekunda.Items8"),
            resources.GetString("cBSekunda.Items9"),
            resources.GetString("cBSekunda.Items10"),
            resources.GetString("cBSekunda.Items11"),
            resources.GetString("cBSekunda.Items12"),
            resources.GetString("cBSekunda.Items13"),
            resources.GetString("cBSekunda.Items14"),
            resources.GetString("cBSekunda.Items15"),
            resources.GetString("cBSekunda.Items16"),
            resources.GetString("cBSekunda.Items17"),
            resources.GetString("cBSekunda.Items18"),
            resources.GetString("cBSekunda.Items19"),
            resources.GetString("cBSekunda.Items20"),
            resources.GetString("cBSekunda.Items21"),
            resources.GetString("cBSekunda.Items22"),
            resources.GetString("cBSekunda.Items23"),
            resources.GetString("cBSekunda.Items24"),
            resources.GetString("cBSekunda.Items25"),
            resources.GetString("cBSekunda.Items26"),
            resources.GetString("cBSekunda.Items27"),
            resources.GetString("cBSekunda.Items28"),
            resources.GetString("cBSekunda.Items29"),
            resources.GetString("cBSekunda.Items30"),
            resources.GetString("cBSekunda.Items31"),
            resources.GetString("cBSekunda.Items32"),
            resources.GetString("cBSekunda.Items33"),
            resources.GetString("cBSekunda.Items34"),
            resources.GetString("cBSekunda.Items35"),
            resources.GetString("cBSekunda.Items36"),
            resources.GetString("cBSekunda.Items37"),
            resources.GetString("cBSekunda.Items38"),
            resources.GetString("cBSekunda.Items39"),
            resources.GetString("cBSekunda.Items40"),
            resources.GetString("cBSekunda.Items41"),
            resources.GetString("cBSekunda.Items42"),
            resources.GetString("cBSekunda.Items43"),
            resources.GetString("cBSekunda.Items44"),
            resources.GetString("cBSekunda.Items45"),
            resources.GetString("cBSekunda.Items46"),
            resources.GetString("cBSekunda.Items47"),
            resources.GetString("cBSekunda.Items48"),
            resources.GetString("cBSekunda.Items49"),
            resources.GetString("cBSekunda.Items50"),
            resources.GetString("cBSekunda.Items51"),
            resources.GetString("cBSekunda.Items52"),
            resources.GetString("cBSekunda.Items53"),
            resources.GetString("cBSekunda.Items54"),
            resources.GetString("cBSekunda.Items55"),
            resources.GetString("cBSekunda.Items56"),
            resources.GetString("cBSekunda.Items57"),
            resources.GetString("cBSekunda.Items58"),
            resources.GetString("cBSekunda.Items59")});
            this.cBSekunda.Name = "cBSekunda";
            // 
            // cBGodzina
            // 
            this.cBGodzina.DisplayMember = "0";
            this.cBGodzina.DropDownHeight = 290;
            resources.ApplyResources(this.cBGodzina, "cBGodzina");
            this.cBGodzina.FormattingEnabled = true;
            this.cBGodzina.Items.AddRange(new object[] {
            resources.GetString("cBGodzina.Items"),
            resources.GetString("cBGodzina.Items1"),
            resources.GetString("cBGodzina.Items2"),
            resources.GetString("cBGodzina.Items3"),
            resources.GetString("cBGodzina.Items4"),
            resources.GetString("cBGodzina.Items5"),
            resources.GetString("cBGodzina.Items6"),
            resources.GetString("cBGodzina.Items7"),
            resources.GetString("cBGodzina.Items8"),
            resources.GetString("cBGodzina.Items9"),
            resources.GetString("cBGodzina.Items10"),
            resources.GetString("cBGodzina.Items11"),
            resources.GetString("cBGodzina.Items12"),
            resources.GetString("cBGodzina.Items13"),
            resources.GetString("cBGodzina.Items14"),
            resources.GetString("cBGodzina.Items15"),
            resources.GetString("cBGodzina.Items16"),
            resources.GetString("cBGodzina.Items17"),
            resources.GetString("cBGodzina.Items18"),
            resources.GetString("cBGodzina.Items19"),
            resources.GetString("cBGodzina.Items20"),
            resources.GetString("cBGodzina.Items21"),
            resources.GetString("cBGodzina.Items22"),
            resources.GetString("cBGodzina.Items23")});
            this.cBGodzina.Name = "cBGodzina";
            // 
            // cBMinuta
            // 
            this.cBMinuta.DropDownHeight = 290;
            resources.ApplyResources(this.cBMinuta, "cBMinuta");
            this.cBMinuta.FormattingEnabled = true;
            this.cBMinuta.Items.AddRange(new object[] {
            resources.GetString("cBMinuta.Items"),
            resources.GetString("cBMinuta.Items1"),
            resources.GetString("cBMinuta.Items2"),
            resources.GetString("cBMinuta.Items3"),
            resources.GetString("cBMinuta.Items4"),
            resources.GetString("cBMinuta.Items5"),
            resources.GetString("cBMinuta.Items6"),
            resources.GetString("cBMinuta.Items7"),
            resources.GetString("cBMinuta.Items8"),
            resources.GetString("cBMinuta.Items9"),
            resources.GetString("cBMinuta.Items10"),
            resources.GetString("cBMinuta.Items11"),
            resources.GetString("cBMinuta.Items12"),
            resources.GetString("cBMinuta.Items13"),
            resources.GetString("cBMinuta.Items14"),
            resources.GetString("cBMinuta.Items15"),
            resources.GetString("cBMinuta.Items16"),
            resources.GetString("cBMinuta.Items17"),
            resources.GetString("cBMinuta.Items18"),
            resources.GetString("cBMinuta.Items19"),
            resources.GetString("cBMinuta.Items20"),
            resources.GetString("cBMinuta.Items21"),
            resources.GetString("cBMinuta.Items22"),
            resources.GetString("cBMinuta.Items23"),
            resources.GetString("cBMinuta.Items24"),
            resources.GetString("cBMinuta.Items25"),
            resources.GetString("cBMinuta.Items26"),
            resources.GetString("cBMinuta.Items27"),
            resources.GetString("cBMinuta.Items28"),
            resources.GetString("cBMinuta.Items29"),
            resources.GetString("cBMinuta.Items30"),
            resources.GetString("cBMinuta.Items31"),
            resources.GetString("cBMinuta.Items32"),
            resources.GetString("cBMinuta.Items33"),
            resources.GetString("cBMinuta.Items34"),
            resources.GetString("cBMinuta.Items35"),
            resources.GetString("cBMinuta.Items36"),
            resources.GetString("cBMinuta.Items37"),
            resources.GetString("cBMinuta.Items38"),
            resources.GetString("cBMinuta.Items39"),
            resources.GetString("cBMinuta.Items40"),
            resources.GetString("cBMinuta.Items41"),
            resources.GetString("cBMinuta.Items42"),
            resources.GetString("cBMinuta.Items43"),
            resources.GetString("cBMinuta.Items44"),
            resources.GetString("cBMinuta.Items45"),
            resources.GetString("cBMinuta.Items46"),
            resources.GetString("cBMinuta.Items47"),
            resources.GetString("cBMinuta.Items48"),
            resources.GetString("cBMinuta.Items49"),
            resources.GetString("cBMinuta.Items50"),
            resources.GetString("cBMinuta.Items51"),
            resources.GetString("cBMinuta.Items52"),
            resources.GetString("cBMinuta.Items53"),
            resources.GetString("cBMinuta.Items54"),
            resources.GetString("cBMinuta.Items55"),
            resources.GetString("cBMinuta.Items56"),
            resources.GetString("cBMinuta.Items57"),
            resources.GetString("cBMinuta.Items58"),
            resources.GetString("cBMinuta.Items59")});
            this.cBMinuta.Name = "cBMinuta";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.bEditEmail);
            this.groupBox5.Controls.Add(this.dataGridView1);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.bDeleteRecords);
            this.groupBox5.Controls.Add(this.tBEditEmail);
            resources.ApplyResources(this.groupBox5, "groupBox5");
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.TabStop = false;
            // 
            // bEditEmail
            // 
            this.bEditEmail.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            resources.ApplyResources(this.bEditEmail, "bEditEmail");
            this.bEditEmail.Name = "bEditEmail";
            this.bEditEmail.UseVisualStyleBackColor = false;
            this.bEditEmail.Click += new System.EventHandler(this.bEditEmail_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // bDeleteRecords
            // 
            this.bDeleteRecords.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            resources.ApplyResources(this.bDeleteRecords, "bDeleteRecords");
            this.bDeleteRecords.Name = "bDeleteRecords";
            this.bDeleteRecords.UseVisualStyleBackColor = false;
            this.bDeleteRecords.Click += new System.EventHandler(this.bDeleteRecords_Click);
            // 
            // tBEditEmail
            // 
            resources.ApplyResources(this.tBEditEmail, "tBEditEmail");
            this.tBEditEmail.Name = "tBEditEmail";
            this.tBEditEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tBEditEmail_KeyDown);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Silver;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            resources.ApplyResources(this.toolStripStatusLabel1, "toolStripStatusLabel1");
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.konfiguracjaToolStripMenuItem,
            this.pomocToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            // 
            // konfiguracjaToolStripMenuItem
            // 
            this.konfiguracjaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.konfiguracjaKontaEmailToolStripMenuItem,
            this.listaEmailOdbiorcówToolStripMenuItem});
            this.konfiguracjaToolStripMenuItem.Image = global::SearchExtension.Properties.Resources.icons8_administrative_tools_35;
            resources.ApplyResources(this.konfiguracjaToolStripMenuItem, "konfiguracjaToolStripMenuItem");
            this.konfiguracjaToolStripMenuItem.Name = "konfiguracjaToolStripMenuItem";
            // 
            // konfiguracjaKontaEmailToolStripMenuItem
            // 
            this.konfiguracjaKontaEmailToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.konfiguracjaKontaEmailToolStripMenuItem, "konfiguracjaKontaEmailToolStripMenuItem");
            this.konfiguracjaKontaEmailToolStripMenuItem.Name = "konfiguracjaKontaEmailToolStripMenuItem";
            this.konfiguracjaKontaEmailToolStripMenuItem.Click += new System.EventHandler(this.konfiguracjaKontaEmailToolStripMenuItem_Click);
            // 
            // listaEmailOdbiorcówToolStripMenuItem
            // 
            this.listaEmailOdbiorcówToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.listaEmailOdbiorcówToolStripMenuItem, "listaEmailOdbiorcówToolStripMenuItem");
            this.listaEmailOdbiorcówToolStripMenuItem.Name = "listaEmailOdbiorcówToolStripMenuItem";
            this.listaEmailOdbiorcówToolStripMenuItem.Click += new System.EventHandler(this.listaEmailOdbiorcówToolStripMenuItem_Click);
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informacjaOAutorzeToolStripMenuItem,
            this.grafikaUżytaWProjekcieToolStripMenuItem});
            this.pomocToolStripMenuItem.Image = global::SearchExtension.Properties.Resources.icons8_informations_35;
            resources.ApplyResources(this.pomocToolStripMenuItem, "pomocToolStripMenuItem");
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            // 
            // informacjaOAutorzeToolStripMenuItem
            // 
            this.informacjaOAutorzeToolStripMenuItem.Name = "informacjaOAutorzeToolStripMenuItem";
            resources.ApplyResources(this.informacjaOAutorzeToolStripMenuItem, "informacjaOAutorzeToolStripMenuItem");
            this.informacjaOAutorzeToolStripMenuItem.Click += new System.EventHandler(this.informacjaOAutorzeToolStripMenuItem_Click);
            // 
            // grafikaUżytaWProjekcieToolStripMenuItem
            // 
            this.grafikaUżytaWProjekcieToolStripMenuItem.Name = "grafikaUżytaWProjekcieToolStripMenuItem";
            resources.ApplyResources(this.grafikaUżytaWProjekcieToolStripMenuItem, "grafikaUżytaWProjekcieToolStripMenuItem");
            this.grafikaUżytaWProjekcieToolStripMenuItem.Click += new System.EventHandler(this.grafikaUżytaWProjekcieToolStripMenuItem_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDCoIleMinut)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button bLoadPath;
        private System.Windows.Forms.TextBox tBPath;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lczas;
        private System.Windows.Forms.ComboBox cbWybranaOpcjaSprawdzania;
        private System.Windows.Forms.Label lMinuty;
        private System.Windows.Forms.Label lWykonujCo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nUDCoIleMinut;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cBSekunda;
        private System.Windows.Forms.ComboBox cBGodzina;
        private System.Windows.Forms.ComboBox cBMinuta;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button bEditEmail;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button bDeleteRecords;
        private System.Windows.Forms.TextBox tBEditEmail;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem konfiguracjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaEmailOdbiorcówToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informacjaOAutorzeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grafikaUżytaWProjekcieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem konfiguracjaKontaEmailToolStripMenuItem;
    }
}

